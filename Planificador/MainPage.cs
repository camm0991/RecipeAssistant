using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Planificador
{
    public partial class MainPage : Form
    {
        private bool _handledKey;
        private int _multiplier;
        private string _recipesPath;

        public MainPage()
        {
            InitializeComponent();
            ConfigureElements();
        }

        private void ConfigureElements()
        {
            _recipesPath = (Directory.GetCurrentDirectory() + "\\Recetas");
            if (!Directory.Exists(_recipesPath))
                Directory.CreateDirectory(_recipesPath);
            if (!Directory.Exists(_recipesPath + "\\Imagenes"))
                Directory.CreateDirectory(_recipesPath + "\\Imagenes");

            openRecipeImageFile.Filter = @"Todas|*.png;*.jpg|Imagen png|*.png|Imagen jpg|*.jpg";

            openRecipeForCostDialog.Title = @"Abrir receta";
            openRecipeForCostDialog.InitialDirectory = _recipesPath;
            openRecipeForCostDialog.Filter = @"Receta xml|*.xml";

            openRecipeFile.Title = @"Abrir receta";
            openRecipeFile.InitialDirectory = _recipesPath;
            openRecipeFile.Filter = @"Receta xml|*.xml";

            saveRecipeFile.Title = @"Guardar receta";
            saveRecipeFile.InitialDirectory = _recipesPath;
            saveRecipeFile.Filter = @"Receta xml|*.xml";

            UpdateItemList();

            if (IngridientList.Items.Count > 0)
            {
                IngridientList.SelectedIndex = 0;
            }
        }

        private void ReloadTable(TableNamesEnum.TableName tableNames)
        {
            switch (tableNames)
            {
                case TableNamesEnum.TableName.Provider:
                    providerTableAdapter.Fill(resourcesDataSet.Provider);
                    break;
                case TableNamesEnum.TableName.Item:
                    itemTableAdapter.Fill(resourcesDataSet.Item);
                    break;
            }
        }

        private void UpdateItemList()
        {
            using (var dataTable = new ResourcesDataSet.ItemDataTable())
            {
                IngridientList.Items.Clear();
                itemTableAdapter.FillByNameSet(dataTable);
                var nameSet = dataTable.Select(item => item.Nombre).Distinct().ToList();
                foreach (var itemName in nameSet)
                {
                    IngridientList.Items.Add(itemName);
                }

                if (IngridientList.Items.Count > 0)
                {
                    IngridientList.SelectedIndex = 0;
                }
                else
                {
                    IngridientList.Text = "";
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'resourcesDataSet.Provider' table. You can move, or remove it, as needed.
                providerTableAdapter.Fill(resourcesDataSet.Provider);
                // TODO: This line of code loads data into the 'resourcesDataSet.Item' table. You can move, or remove it, as needed.
                itemTableAdapter.Fill(resourcesDataSet.Item);
            }
            catch (Exception exception)
            {
                throw exception.GetBaseException();
            }
        }

        /* < General section >
         * Here are the methods and events that affects
         * both tables or other things in the interface.
         */

        private int DeleteOperation(TableNamesEnum.TableName tableName, string columnName, string rowId)
        {
            //Generate conection string for the Data Base from the 'App.config' file
            var connectionString =
                ConfigurationManager.ConnectionStrings[
                    "Planificador.Properties.Settings.ResourcesDBConnectionString"]
                    .ConnectionString;

            //Conecting to the SQL database
            using (var connection = new SqlConnection(connectionString))
            {
                //Body of the insert action
                var sql = "DELETE FROM " + tableName + " WHERE " + columnName + "= @rName";

                connection.Open();

                //Association of the conection string and the SQL query
                var command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@rName", rowId);

                //Try to execute the query
                try
                {
                    var rowsAffected = command.ExecuteNonQuery();
                    //The user is informed that the query was made correctly
                    ReloadTable(tableName);
                    return rowsAffected;
                }
                catch (SqlException exception)
                {
                    //The user is informed that there was a problem when executing the query
                    MessageBox.Show(@"Error al eliminar el registro");
                    throw exception.GetBaseException();
                }
            }
        }

        /* < Providers section >
         * Here are the methods and events that affects
         * the 'Provider' table.
         */

        private void ProviderAdd_Click(object sender, EventArgs e)
        {
            var addProvider = new AddProvider(ReloadTable);
            addProvider.Show();
        }

        private void ProviderDelete_Click(object sender, EventArgs e)
        {
            if (ProviderGridView.SelectedRows.Count <= 0)
                return;
            try
            {
                var providersId =
                    (from DataGridViewRow provider in ProviderGridView.SelectedRows
                        select provider.Cells[0].Value.ToString()).ToList();

                foreach (var providerId in providersId)
                {
                    DeleteOperation(TableNamesEnum.TableName.Provider, @"IdProveedor", providerId);
                    MessageBox.Show(@"Registro de proveedor eliminado correctamente");
                    if (DeleteOperation(TableNamesEnum.TableName.Item, @"IdProveedor", providerId) <= 0)
                        continue;
                    MessageBox.Show(@"Registros de insumos asociados al proveedor eliminados correctamente");
                    UpdateItemList();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error al eliminar registro(s)");
                Console.Error.WriteLine(exception.GetBaseException());
            }
        }

        private void ProviderQueryByName_KeyUp(object sender, KeyEventArgs e)
        {
            providerTableAdapter.FillByName(resourcesDataSet.Provider, ProviderQueryByName.Text);
        }

        /* < Item section >
         * Here are the methods and events that affects
         * the 'Item' table.
         */

        private void ItemAdd_Click(object sender, EventArgs e)
        {
            var addProduct = new AddItem(ReloadTable, UpdateItemList);
            addProduct.Show();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            if (itemGridView.SelectedRows.Count <= 0)
                return;
            try
            {
                var itemsId =
                    (from DataGridViewRow item in itemGridView.SelectedRows select item.Cells[0].Value.ToString())
                        .ToList();

                foreach (var itemId in itemsId)
                {
                    DeleteOperation(TableNamesEnum.TableName.Item, @"IdInsumo", itemId);
                }
                UpdateItemList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error al eliminar registro(s)");
                Console.Error.WriteLine(exception.GetBaseException());
            }
        }

        private void ItemQueryByGroup_KeyUp(object sender, KeyEventArgs e)
        {
            itemTableAdapter.FillByIntersection(resourcesDataSet.Item, ItemQueryByNameBox.Text, ItemQueryByGroup.Text,
                ItemQueryByProvider.Text);
        }

        private void ItemQueryByNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            itemTableAdapter.FillByIntersection(resourcesDataSet.Item, ItemQueryByNameBox.Text, ItemQueryByGroup.Text,
                ItemQueryByProvider.Text);
        }

        private void ItemQueryByProvider_KeyUp(object sender, KeyEventArgs e)
        {
            itemTableAdapter.FillByIntersection(resourcesDataSet.Item, ItemQueryByNameBox.Text, ItemQueryByGroup.Text,
                ItemQueryByProvider.Text);
        }

        /* < Recipe section >
         * Here are the methods and events that affects
         * the 'Item' table.
         */

        private void RecipeAddIngridient_Click(object sender, EventArgs e)
        {
            if (IngridientList.SelectedItem == null)
            {
                MessageBox.Show(@"Ingrediente no existente o campo vacio");
                return;
            }

            if (string.IsNullOrWhiteSpace(QuantityBox.Text))
            {
                MessageBox.Show(@"Ingrese una cantidad");
                return;
            }

            double weight;
            if (!double.TryParse(QuantityBox.Text, out weight))
                return;
            var item = IngridientList.SelectedItem.ToString();
            var itemQuantity = string.Format("{0:0.000}", weight);
            var itemUnit = (from ingredient in resourcesDataSet.Item
                where ingredient.Nombre.Equals(item)
                select ingredient.Unidad).FirstOrDefault();
            dataGridView3.Rows.Add(item, itemQuantity, itemUnit);
        }

        private void RecipeRemoveIngredient_Click(object sender, EventArgs e)
        {
            var rows = dataGridView3.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                dataGridView3.Rows.RemoveAt(row.Index);
            }
        }

        private void RecipeIngridientListComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar.ToString().ToUpper();
            e.KeyChar = key[0];
        }

        private void RecipeLoadButton_Click(object sender, EventArgs e)
        {
            openRecipeFile.FileName = null;
            openRecipeFile.ShowDialog();
        }

        private void RecipeSaveButton_Click(object sender, EventArgs e)
        {
            CheckAndSaveRecipe();
        }

        private void QuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.');
        }

        private void itemGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double itemNewPrice;

            if (!itemGridView.Columns[e.ColumnIndex].Name.Equals("precioDataGridViewTextBoxColumn"))
                return;
            if (double.TryParse(itemGridView.Rows[e.RowIndex].Cells[5].Value.ToString(), out itemNewPrice))
            {
                //Generate conection string for the Data Base from the 'App.config' file
                var connectionString =
                    ConfigurationManager.ConnectionStrings[
                        "Planificador.Properties.Settings.ResourcesDBConnectionString"]
                        .ConnectionString;

                //Conecting to the SQL database
                using (var connection = new SqlConnection(connectionString))
                {
                    //Body of the insert action
                    const string sql = "UPDATE Item SET Precio = @newPrice WHERE IdInsumo = @id";
                    connection.Open();

                    //Association of the conection string and the SQL query
                    var command = new SqlCommand(sql, connection);

                    var itemId = itemGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    command.Parameters.AddWithValue("@newPrice", string.Format("{0:0.00}", itemNewPrice));
                    command.Parameters.AddWithValue("@id", itemId);

                    //Try to execute the query
                    try
                    {
                        command.ExecuteNonQuery();
                        //The user is informed that the query was made correctly
                        ReloadTable(TableNamesEnum.TableName.Item);
                    }
                    catch (SqlException exception)
                    {
                        //The user is informed that there was a problem when executing the query
                        MessageBox.Show(@"Error al modificar el registro");
                        throw exception.GetBaseException();
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Por favor ingrese un valor numérico");
            }
        }

        private void ProviderGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!ProviderGridView.Columns[e.ColumnIndex].Name.Equals("dataGridViewTextBoxColumn9"))
                return;
            var newContactPerson = ProviderGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            //Generate conection string for the Data Base from the 'App.config' file
            var connectionString =
                ConfigurationManager.ConnectionStrings[
                    "Planificador.Properties.Settings.ResourcesDBConnectionString"]
                    .ConnectionString;

            //Conecting to the SQL database
            using (var connection = new SqlConnection(connectionString))
            {
                //Body of the insert action
                const string sql = "UPDATE Provider SET PersonaContacto = @newContact WHERE IdProveedor = @id";
                connection.Open();

                //Association of the conection string and the SQL query
                var command = new SqlCommand(sql, connection);

                var providerId = ProviderGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                command.Parameters.AddWithValue("@newContact", newContactPerson);
                command.Parameters.AddWithValue("@id", providerId);

                //Try to execute the query
                try
                {
                    command.ExecuteNonQuery();
                    //The user is informed that the query was made correctly
                    ReloadTable(TableNamesEnum.TableName.Item);
                }
                catch (SqlException exception)
                {
                    //The user is informed that there was a problem when executing the query
                    MessageBox.Show(@"Error al modificar el registro");
                    throw exception.GetBaseException();
                }
            }
        }

        private void ResetForm_Click(object sender, EventArgs e)
        {
            RecipeNameBox.Text = null;
            dataGridView3.Rows.Clear();
            richTextBox1.Text = null;
            QuantityBox.Text = null;

            if (recipePictureBox.Image != null)
                recipePictureBox.Image.Dispose();
            recipePictureBox.ImageLocation = "";
            recipePictureBox.Image = null;
        }

        private void saveRecipeFile_FileOk(object sender, CancelEventArgs e)
        {
            var file = saveRecipeFile.FileName;
            using (
                var writer =
                    XmlWriter.Create(file))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("Receta");
                writer.WriteAttributeString("nombre", RecipeNameBox.Text);

                writer.WriteStartElement("Imagen");
                if (recipePictureBox.Image == null)
                {
                    writer.WriteAttributeString("nombre", "-");
                }
                else
                {
                    var imageFileExtension = Path.GetExtension(recipePictureBox.ImageLocation);
                    var imageOriginalFile = new string(recipePictureBox.ImageLocation.ToCharArray());
                    var imageTargetFile = _recipesPath + "\\Imagenes\\" + RecipeNameBox.Text.Replace(' ', '_') +
                                          imageFileExtension;
                    if (imageOriginalFile != imageTargetFile)
                        File.Copy(imageOriginalFile, imageTargetFile, true);

                    writer.WriteAttributeString("nombre", RecipeNameBox.Text.Replace(' ', '_') + imageFileExtension);
                }
                writer.WriteEndElement();

                writer.WriteStartElement("Ingredientes");
                foreach (DataGridViewRow ingredienteRow in dataGridView3.Rows)
                {
                    writer.WriteStartElement("ingrediente");
                    writer.WriteAttributeString("nombre", ingredienteRow.Cells[0].Value.ToString());
                    writer.WriteAttributeString("cantidad", ingredienteRow.Cells[1].Value.ToString());
                    writer.WriteAttributeString("medida", ingredienteRow.Cells[2].Value.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("Procedimiento");
                writer.WriteElementString("pasos", richTextBox1.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
            MessageBox.Show(@"Receta guardada correctamente");
            ChangeRecipeStatusToOk();
        }

        private void PictureMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            openRecipeImageFile.FileName = null;
            PictureMenuStrip.Hide();
            switch ((PictureImageBox) PictureMenuStrip.Items.IndexOf(e.ClickedItem))
            {
                case PictureImageBox.Add:
                    LoadImageOnRecipePictureBox();
                    break;
                case PictureImageBox.Delete:
                    DeleteImageOnRecipePictureBox();
                    break;
            }
        }

        private void LoadImageOnRecipePictureBox()
        {
            openRecipeImageFile.ShowDialog();
        }

        private void DeleteImageOnRecipePictureBox()
        {
            if (recipePictureBox.Image != null)
                recipePictureBox.Image.Dispose();
            recipePictureBox.ImageLocation = "";
            recipePictureBox.Image = null;
        }

        private void openRecipeImageFile_FileOk(object sender, CancelEventArgs e)
        {
            recipePictureBox.ImageLocation = new string(openRecipeImageFile.FileName.ToCharArray());
            recipePictureBox.Image = Image.FromFile(openRecipeImageFile.FileName);
        }

        private void openRecipeFile_FileOk(object sender, CancelEventArgs e)
        {
            using (var reader = XmlReader.Create(openRecipeFile.FileName))
            {
                var index = 0;
                dataGridView3.Rows.Clear();

                while (reader.Read())
                {
                    if (reader.Name.Equals("Receta") && (reader.NodeType == XmlNodeType.Element))
                    {
                        RecipeNameBox.Text = reader.GetAttribute("nombre");
                    }

                    if (reader.Name.Equals("Imagen") && (reader.NodeType == XmlNodeType.Element))
                    {
                        var imageFileName = reader.GetAttribute("nombre");
                        if (imageFileName != "-")
                        {
                            var imageFilePath = _recipesPath + "\\Imagenes\\" + imageFileName;
                            recipePictureBox.ImageLocation = imageFilePath;
                            recipePictureBox.Image = Image.FromFile(imageFilePath);
                        }
                    }

                    if (reader.Name.Equals("ingrediente") && (reader.NodeType == XmlNodeType.Element))
                    {
                        dataGridView3.Rows.Insert(index++, reader.GetAttribute("nombre"),
                            reader.GetAttribute("cantidad"),
                            reader.GetAttribute("medida"));
                    }

                    if (!reader.Name.Equals("Procedimiento") || (reader.NodeType != XmlNodeType.Element))
                        continue;
                    richTextBox1.Text = null;
                    richTextBox1.Text = reader.ReadElementString();
                    reader.ReadEndElement();
                }

                MainInterface.TabPages["RecipeTab"].Text = @"Recetas";
            }
        }

        private void LoadRecipeButton_Click(object sender, EventArgs e)
        {
            openRecipeForCostDialog.FileName = null;
            openRecipeForCostDialog.ShowDialog();
        }

        private void openRecipeForCostDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (var reader = XmlReader.Create(openRecipeForCostDialog.FileName))
            {
                var index = 0;
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    if (reader.Name.Equals("Receta") && (reader.NodeType == XmlNodeType.Element))
                    {
                        RecipeNameLabel.Text = reader.GetAttribute("nombre");
                        continue;
                    }

                    if (reader.Name.Equals("Imagen") && (reader.NodeType == XmlNodeType.Element))
                    {
                        var imageFileName = reader.GetAttribute("nombre");
                        if (imageFileName == "-")
                        {
                            CostPictureBox.ImageLocation = "";
                            CostPictureBox.Image = null;
                            continue;
                        }
                        var imageFilePath = _recipesPath + "\\Imagenes\\" + imageFileName;
                        CostPictureBox.ImageLocation = imageFilePath;
                        CostPictureBox.Image = Image.FromFile(imageFilePath);
                        continue;
                    }

                    if (!reader.Name.Equals("ingrediente") || (reader.NodeType != XmlNodeType.Element)) continue;
                    var item = reader.GetAttribute("nombre");
                    var quantity = reader.GetAttribute("cantidad");
                    var unit = reader.GetAttribute("medida");
                    var pricePer = (from ingredient in resourcesDataSet.Item
                        where
                            ingredient.Nombre.Equals(item)
                        select new
                        {
                            ingredient.Precio,
                            ingredient.IdProveedor
                        }).ToList();

                    if (pricePer.Count <= 0)
                    {
                        MessageBox.Show(@"Faltan precios de ingredientes para calcular costos");
                        return;
                    }

                    pricePer.Sort((a, b) => double.Parse(a.Precio).CompareTo(double.Parse(b.Precio)));
                    if (quantity == null)
                        continue;
                    var realPrice = double.Parse(quantity)*double.Parse(pricePer[0].Precio);
                    dataGridView1.Rows.Insert(index++,
                        item,
                        unit,
                        quantity,
                        string.Format("{0:0.00}", realPrice),
                        pricePer[0].IdProveedor);
                }
            }
            var totalCost = 0.0;
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalCost += Convert.ToDouble(dataGridView1.Rows[i].Cells["CostoPorcion"].Value);
            }
            var suggestedPrice = (totalCost*3)*1.02;
            RecipeCostLabel.Text = string.Format("{0:$0.00}", totalCost);
            SuggestedPriceLabel.Text = string.Format("{0:$0.00}", suggestedPrice);
            NumberOfPersons.Text = @"1";
            NumberOfPersons.Enabled = true;
            _multiplier = 1;
        }

        private void PrintRecipe_Click(object sender, EventArgs e)
        {
            var printer = new RecipePrinter(dataGridView3, RecipeNameBox.Text, richTextBox1.Text,
                recipePictureBox.ImageLocation);
            printer.Show();
        }

        //Update values for cost's and quantityes
        private void NumberOfPersons_KeyUp(object sender, KeyEventArgs e)
        {
            if (_handledKey) return;
            if (string.IsNullOrEmpty(NumberOfPersons.Text)) return;

            var oldMultiplier = _multiplier;

            if (!int.TryParse(NumberOfPersons.Text, out _multiplier))
            {
                _multiplier = 1;
                return;
            }

            if (_multiplier.Equals(0))
            {
                _multiplier = 1;
            }

            RecipeCostLabel.Text = string.Format("{0:$0.00}",
                (double.Parse(RecipeCostLabel.Text.TrimStart('$'))/oldMultiplier)*_multiplier);
            SuggestedPriceLabel.Text = string.Format("{0:$0.00}",
                (double.Parse(SuggestedPriceLabel.Text.TrimStart('$'))/oldMultiplier)*_multiplier);

            foreach (DataGridViewRow recipeRow in dataGridView1.Rows)
            {
                recipeRow.Cells[2].Value = (double.Parse(recipeRow.Cells[2].Value.ToString())/oldMultiplier)*_multiplier;
                recipeRow.Cells[3].Value = (double.Parse(recipeRow.Cells[3].Value.ToString())/oldMultiplier)*_multiplier;
            }
        }

        private void NumberOfPersons_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _handledKey = e.Handled;
        }

        private void RecipeNameBox_TextChanged(object sender, EventArgs e)
        {
            ChangeRecipeStatusToChanged();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeRecipeStatusToChanged();
        }

        private void recipePictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ChangeRecipeStatusToChanged();
        }

        private void dataGridView3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ChangeRecipeStatusToChanged();
        }

        private void dataGridView3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChangeRecipeStatusToChanged();
        }

        private void ChangeRecipeStatusToChanged()
        {
            if (MainInterface.TabPages["RecipeTab"].Text[MainInterface.TabPages["RecipeTab"].Text.Length - 1] == '*')
                return;
            MainInterface.TabPages["RecipeTab"].Text = @"Recetas*";
        }

        private void ChangeRecipeStatusToOk()
        {
            if (MainInterface.TabPages["RecipeTab"].Text[MainInterface.TabPages["RecipeTab"].Text.Length - 1] != '*')
                return;
            MainInterface.TabPages["RecipeTab"].Text = @"Recetas";
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainInterface.TabPages["RecipeTab"].Text[MainInterface.TabPages["RecipeTab"].Text.Length - 1] != '*')
                return;

            MainInterface.SelectedTab = MainInterface.TabPages["RecipeTab"];
            var selection = MessageBox.Show(@"¿Desea guardar cambios en la receta?", @"Receta sin guardar",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (selection == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            if (selection == DialogResult.Yes)
            {
                e.Cancel = true;
                CheckAndSaveRecipe();
            }
        }

        private void CheckAndSaveRecipe()
        {
            if (string.IsNullOrWhiteSpace(RecipeNameBox.Text))
            {
                MessageBox.Show(@"Ingrese un nombre para la receta");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show(@"Falta escribir un procedimiento");
                return;
            }

            if (dataGridView3.Rows.Count < 1)
            {
                MessageBox.Show(@"Falta agregar ingredientes");
                return;
            }
            saveRecipeFile.FileName = RecipeNameBox.Text;
            saveRecipeFile.ShowDialog();
        }

        private enum PictureImageBox
        {
            Add,
            Delete
        }
    }
}