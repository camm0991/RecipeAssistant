using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Planificador
{
    public partial class AddItem : Form
    {
        public delegate void ReloadTable(TableNamesEnum.TableName tableName);

        public delegate void UpdateItemList();

        private readonly ReloadTable _reloadTable;
        private readonly UpdateItemList _updateList;

        public AddItem(ReloadTable reloadTable, UpdateItemList updateliList)
        {
            InitializeComponent();
            _reloadTable = reloadTable;
            _updateList = updateliList;
            UnitList.SelectedIndex = 0;
        }

        //Event when the 'Agregar' button is triggered
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameData.Text) || string.IsNullOrWhiteSpace(GroupData.Text) ||
                string.IsNullOrWhiteSpace(PriceData.Text))
            {
                MessageBox.Show(@"Algun campo está vacio");
            }
            else
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
                    const string sql = "INSERT INTO Item (Nombre, Grupo, IdProveedor, Unidad, Precio)" +
                                       " values (@nombre,@grupo,@proveedor,@unidad, @precio)";
                    double price;
                    double.TryParse(PriceData.Text, out price);

                    connection.Open();

                    //Association of the conection string and the SQL query
                    var command = new SqlCommand(sql, connection);
                    //Replacing the variables in the query for the fields in the 'AddItem' form
                    command.Parameters.AddWithValue("@nombre", NameData.Text);
                    command.Parameters.AddWithValue("@grupo", GroupData.Text);
                    command.Parameters.AddWithValue("@proveedor", ProviderList.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@unidad", UnitList.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@precio", string.Format("{0:0.00}", price));

                    //Try to execute the query
                    try
                    {
                        command.ExecuteNonQuery();
                        //If the query was successful the form is restarted
                        NameData.Text = null;
                        GroupData.Text = null;
                        PriceData.Text = null;
                        _reloadTable.Invoke(TableNamesEnum.TableName.Item);
                        _updateList.Invoke();
                        //The user is informed that the query was made correctly
                        MessageBox.Show(@"Insumo agregado correctamente");
                    }
                    catch (SqlException exception)
                    {
                        //The user is informed that there was a problem when executing the query
                        MessageBox.Show(@"Error al añadir Insumo");
                        Console.Error.WriteLine(exception.GetBaseException());
                    }
                }
            }
        }

        //Load the ProviderList in the ProviderComboBox
        private void AddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourcesDataSet.Provider' table. You can move, or remove it, as needed.
            providerTableAdapter.Fill(resourcesDataSet.Provider);
            //Checks if there's at least one provider added
            if (resourcesDataSet.Provider.Rows.Count >= 1) return;
            MessageBox.Show(@"No se tienen proveedores");
            Close();
        }

        private void PriceData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.');
        }
    }
}