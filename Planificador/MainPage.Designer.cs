
namespace Planificador
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.MainInterface = new System.Windows.Forms.TabControl();
            this.FrontTab = new System.Windows.Forms.TabPage();
            this.ProviderTab = new System.Windows.Forms.TabPage();
            this.ProviderGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesDataSet = new Planificador.ResourcesDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.AddProvider = new System.Windows.Forms.Button();
            this.ProviderQueryByName = new System.Windows.Forms.TextBox();
            this.DeleteProvider = new System.Windows.Forms.Button();
            this.StockTab = new System.Windows.Forms.TabPage();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.idInsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.ItemQueryByProvider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemQueryByGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemQueryByNameBox = new System.Windows.Forms.TextBox();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.RecipeTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ResetForm = new System.Windows.Forms.Button();
            this.RemoveIngredientToRecipe = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.IngridientList = new System.Windows.Forms.ComboBox();
            this.AddIngredientToRecipe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintRecipe = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RecipeNameBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.recipePictureBox = new System.Windows.Forms.PictureBox();
            this.PictureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CostTab = new System.Windows.Forms.TabPage();
            this.NumberOfPersons = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuggestedPriceLabel = new System.Windows.Forms.Label();
            this.RecipeCostLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RecipeNameLabel = new System.Windows.Forms.Label();
            this.CostPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPorcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadRecipeButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveRecipeFile = new System.Windows.Forms.SaveFileDialog();
            this.openRecipeImageFile = new System.Windows.Forms.OpenFileDialog();
            this.openRecipeFile = new System.Windows.Forms.OpenFileDialog();
            this.openRecipeForCostDialog = new System.Windows.Forms.OpenFileDialog();
            this.providerTableAdapter = new Planificador.ResourcesDataSetTableAdapters.ProviderTableAdapter();
            this.itemTableAdapter = new Planificador.ResourcesDataSetTableAdapters.ItemTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.MainInterface.SuspendLayout();
            this.FrontTab.SuspendLayout();
            this.ProviderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.StockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.RecipeTab.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).BeginInit();
            this.PictureMenuStrip.SuspendLayout();
            this.CostTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainInterface
            // 
            this.MainInterface.Controls.Add(this.FrontTab);
            this.MainInterface.Controls.Add(this.ProviderTab);
            this.MainInterface.Controls.Add(this.StockTab);
            this.MainInterface.Controls.Add(this.RecipeTab);
            this.MainInterface.Controls.Add(this.CostTab);
            this.MainInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainInterface.Location = new System.Drawing.Point(0, 0);
            this.MainInterface.Name = "MainInterface";
            this.MainInterface.SelectedIndex = 0;
            this.MainInterface.Size = new System.Drawing.Size(1005, 494);
            this.MainInterface.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainInterface.TabIndex = 0;
            // 
            // FrontTab
            // 
            this.FrontTab.Controls.Add(this.label15);
            this.FrontTab.Location = new System.Drawing.Point(4, 22);
            this.FrontTab.Name = "FrontTab";
            this.FrontTab.Padding = new System.Windows.Forms.Padding(3);
            this.FrontTab.Size = new System.Drawing.Size(997, 468);
            this.FrontTab.TabIndex = 0;
            this.FrontTab.Text = "Portada";
            this.FrontTab.UseVisualStyleBackColor = true;
            // 
            // ProviderTab
            // 
            this.ProviderTab.Controls.Add(this.ProviderGridView);
            this.ProviderTab.Controls.Add(this.panel4);
            this.ProviderTab.Location = new System.Drawing.Point(4, 22);
            this.ProviderTab.Name = "ProviderTab";
            this.ProviderTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProviderTab.Size = new System.Drawing.Size(997, 468);
            this.ProviderTab.TabIndex = 1;
            this.ProviderTab.Text = "Proveedores";
            this.ProviderTab.UseVisualStyleBackColor = true;
            // 
            // ProviderGridView
            // 
            this.ProviderGridView.AllowUserToAddRows = false;
            this.ProviderGridView.AllowUserToDeleteRows = false;
            this.ProviderGridView.AutoGenerateColumns = false;
            this.ProviderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProviderGridView.ColumnHeadersHeight = 25;
            this.ProviderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.ProviderGridView.DataSource = this.providerBindingSource;
            this.ProviderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProviderGridView.Location = new System.Drawing.Point(3, 53);
            this.ProviderGridView.Name = "ProviderGridView";
            this.ProviderGridView.Size = new System.Drawing.Size(991, 412);
            this.ProviderGridView.TabIndex = 2;
            this.ProviderGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdProveedor";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdProveedor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PersonaContacto";
            this.dataGridViewTextBoxColumn9.HeaderText = "Persona de contacto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RFC";
            this.dataGridViewTextBoxColumn10.HeaderText = "RFC";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CP";
            this.dataGridViewTextBoxColumn12.HeaderText = "CP";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.resourcesDataSet;
            // 
            // resourcesDataSet
            // 
            this.resourcesDataSet.DataSetName = "ResourcesDataSet";
            this.resourcesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.AddProvider);
            this.panel4.Controls.Add(this.ProviderQueryByName);
            this.panel4.Controls.Add(this.DeleteProvider);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 50);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre";
            // 
            // AddProvider
            // 
            this.AddProvider.Image = ((System.Drawing.Image)(resources.GetObject("AddProvider.Image")));
            this.AddProvider.Location = new System.Drawing.Point(859, 4);
            this.AddProvider.Name = "AddProvider";
            this.AddProvider.Size = new System.Drawing.Size(38, 38);
            this.AddProvider.TabIndex = 0;
            this.AddProvider.UseVisualStyleBackColor = true;
            this.AddProvider.Click += new System.EventHandler(this.ProviderAdd_Click);
            // 
            // ProviderQueryByName
            // 
            this.ProviderQueryByName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ProviderQueryByName.Location = new System.Drawing.Point(169, 22);
            this.ProviderQueryByName.Name = "ProviderQueryByName";
            this.ProviderQueryByName.Size = new System.Drawing.Size(131, 20);
            this.ProviderQueryByName.TabIndex = 2;
            this.ProviderQueryByName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProviderQueryByName_KeyUp);
            // 
            // DeleteProvider
            // 
            this.DeleteProvider.Image = ((System.Drawing.Image)(resources.GetObject("DeleteProvider.Image")));
            this.DeleteProvider.Location = new System.Drawing.Point(903, 4);
            this.DeleteProvider.Name = "DeleteProvider";
            this.DeleteProvider.Size = new System.Drawing.Size(38, 38);
            this.DeleteProvider.TabIndex = 1;
            this.DeleteProvider.UseVisualStyleBackColor = true;
            this.DeleteProvider.Click += new System.EventHandler(this.ProviderDelete_Click);
            // 
            // StockTab
            // 
            this.StockTab.Controls.Add(this.itemGridView);
            this.StockTab.Controls.Add(this.panel2);
            this.StockTab.Location = new System.Drawing.Point(4, 22);
            this.StockTab.Name = "StockTab";
            this.StockTab.Padding = new System.Windows.Forms.Padding(3);
            this.StockTab.Size = new System.Drawing.Size(997, 468);
            this.StockTab.TabIndex = 2;
            this.StockTab.Text = "Almacen";
            this.StockTab.UseVisualStyleBackColor = true;
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AllowUserToDeleteRows = false;
            this.itemGridView.AutoGenerateColumns = false;
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.ColumnHeadersHeight = 25;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInsumoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.itemGridView.DataSource = this.itemBindingSource;
            this.itemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGridView.Location = new System.Drawing.Point(3, 53);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.Size = new System.Drawing.Size(991, 412);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_CellEndEdit);
            // 
            // idInsumoDataGridViewTextBoxColumn
            // 
            this.idInsumoDataGridViewTextBoxColumn.DataPropertyName = "IdInsumo";
            this.idInsumoDataGridViewTextBoxColumn.HeaderText = "IdInsumo";
            this.idInsumoDataGridViewTextBoxColumn.Name = "idInsumoDataGridViewTextBoxColumn";
            this.idInsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio($)";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.resourcesDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.AddItem);
            this.panel2.Controls.Add(this.ItemQueryByProvider);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ItemQueryByGroup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ItemQueryByNameBox);
            this.panel2.Controls.Add(this.DeleteItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 50);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Proveedor";
            // 
            // AddItem
            // 
            this.AddItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItem.Image")));
            this.AddItem.Location = new System.Drawing.Point(859, 4);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(38, 38);
            this.AddItem.TabIndex = 0;
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // ItemQueryByProvider
            // 
            this.ItemQueryByProvider.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ItemQueryByProvider.Location = new System.Drawing.Point(406, 22);
            this.ItemQueryByProvider.Name = "ItemQueryByProvider";
            this.ItemQueryByProvider.Size = new System.Drawing.Size(175, 20);
            this.ItemQueryByProvider.TabIndex = 6;
            this.ItemQueryByProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemQueryByProvider_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grupo";
            // 
            // ItemQueryByGroup
            // 
            this.ItemQueryByGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ItemQueryByGroup.Location = new System.Drawing.Point(224, 22);
            this.ItemQueryByGroup.Name = "ItemQueryByGroup";
            this.ItemQueryByGroup.Size = new System.Drawing.Size(176, 20);
            this.ItemQueryByGroup.TabIndex = 4;
            this.ItemQueryByGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemQueryByGroup_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // ItemQueryByNameBox
            // 
            this.ItemQueryByNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ItemQueryByNameBox.Location = new System.Drawing.Point(40, 22);
            this.ItemQueryByNameBox.Name = "ItemQueryByNameBox";
            this.ItemQueryByNameBox.Size = new System.Drawing.Size(178, 20);
            this.ItemQueryByNameBox.TabIndex = 2;
            this.ItemQueryByNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemQueryByNameBox_KeyUp);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItem.Image")));
            this.DeleteItem.Location = new System.Drawing.Point(903, 4);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(38, 38);
            this.DeleteItem.TabIndex = 1;
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.ItemDelete_Click);
            // 
            // RecipeTab
            // 
            this.RecipeTab.Controls.Add(this.panel3);
            this.RecipeTab.Controls.Add(this.panel1);
            this.RecipeTab.Controls.Add(this.panel5);
            this.RecipeTab.Location = new System.Drawing.Point(4, 22);
            this.RecipeTab.Name = "RecipeTab";
            this.RecipeTab.Padding = new System.Windows.Forms.Padding(3);
            this.RecipeTab.Size = new System.Drawing.Size(997, 468);
            this.RecipeTab.TabIndex = 3;
            this.RecipeTab.Text = "Recetas";
            this.RecipeTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.ResetForm);
            this.panel3.Controls.Add(this.RemoveIngredientToRecipe);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.QuantityBox);
            this.panel3.Controls.Add(this.IngridientList);
            this.panel3.Controls.Add(this.AddIngredientToRecipe);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 409);
            this.panel3.TabIndex = 8;
            // 
            // ResetForm
            // 
            this.ResetForm.Location = new System.Drawing.Point(365, 38);
            this.ResetForm.Name = "ResetForm";
            this.ResetForm.Size = new System.Drawing.Size(83, 23);
            this.ResetForm.TabIndex = 15;
            this.ResetForm.Text = "Limpiar Todo";
            this.ResetForm.UseVisualStyleBackColor = true;
            this.ResetForm.Click += new System.EventHandler(this.ResetForm_Click);
            // 
            // RemoveIngredientToRecipe
            // 
            this.RemoveIngredientToRecipe.Image = global::Planificador.Properties.Resources.DeleteIcon_mini;
            this.RemoveIngredientToRecipe.Location = new System.Drawing.Point(339, 40);
            this.RemoveIngredientToRecipe.Name = "RemoveIngredientToRecipe";
            this.RemoveIngredientToRecipe.Size = new System.Drawing.Size(20, 20);
            this.RemoveIngredientToRecipe.TabIndex = 14;
            this.RemoveIngredientToRecipe.UseVisualStyleBackColor = true;
            this.RemoveIngredientToRecipe.Click += new System.EventHandler(this.RecipeRemoveIngredient_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingrediente,
            this.Cantidad,
            this.Unidad});
            this.dataGridView3.Location = new System.Drawing.Point(7, 67);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(666, 337);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView3_RowsAdded);
            this.dataGridView3.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView3_RowsRemoved);
            // 
            // Ingrediente
            // 
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.ReadOnly = true;
            this.Ingrediente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ingrediente";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(255, 40);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(52, 20);
            this.QuantityBox.TabIndex = 9;
            this.QuantityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityBox_KeyPress);
            // 
            // IngridientList
            // 
            this.IngridientList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IngridientList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IngridientList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IngridientList.FormattingEnabled = true;
            this.IngridientList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IngridientList.Location = new System.Drawing.Point(44, 39);
            this.IngridientList.Name = "IngridientList";
            this.IngridientList.Size = new System.Drawing.Size(205, 21);
            this.IngridientList.Sorted = true;
            this.IngridientList.TabIndex = 8;
            this.IngridientList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecipeIngridientListComboBox_KeyPress);
            // 
            // AddIngredientToRecipe
            // 
            this.AddIngredientToRecipe.Image = global::Planificador.Properties.Resources.AddIcon_mini;
            this.AddIngredientToRecipe.Location = new System.Drawing.Point(313, 40);
            this.AddIngredientToRecipe.Name = "AddIngredientToRecipe";
            this.AddIngredientToRecipe.Size = new System.Drawing.Size(20, 20);
            this.AddIngredientToRecipe.TabIndex = 7;
            this.AddIngredientToRecipe.UseVisualStyleBackColor = true;
            this.AddIngredientToRecipe.Click += new System.EventHandler(this.RecipeAddIngridient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintRecipe);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.LoadButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RecipeNameBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 53);
            this.panel1.TabIndex = 7;
            // 
            // PrintRecipe
            // 
            this.PrintRecipe.Image = global::Planificador.Properties.Resources.printer;
            this.PrintRecipe.Location = new System.Drawing.Point(631, 7);
            this.PrintRecipe.Name = "PrintRecipe";
            this.PrintRecipe.Size = new System.Drawing.Size(42, 42);
            this.PrintRecipe.TabIndex = 14;
            this.PrintRecipe.UseVisualStyleBackColor = true;
            this.PrintRecipe.Click += new System.EventHandler(this.PrintRecipe_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(565, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.RecipeSaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(499, 15);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(60, 23);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Abrir";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.RecipeLoadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de receta";
            // 
            // RecipeNameBox
            // 
            this.RecipeNameBox.Location = new System.Drawing.Point(147, 15);
            this.RecipeNameBox.Name = "RecipeNameBox";
            this.RecipeNameBox.Size = new System.Drawing.Size(234, 20);
            this.RecipeNameBox.TabIndex = 3;
            this.RecipeNameBox.TextChanged += new System.EventHandler(this.RecipeNameBox_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.recipePictureBox);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(682, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 462);
            this.panel5.TabIndex = 9;
            // 
            // recipePictureBox
            // 
            this.recipePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipePictureBox.ContextMenuStrip = this.PictureMenuStrip;
            this.recipePictureBox.Location = new System.Drawing.Point(11, 30);
            this.recipePictureBox.Name = "recipePictureBox";
            this.recipePictureBox.Size = new System.Drawing.Size(296, 177);
            this.recipePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipePictureBox.TabIndex = 16;
            this.recipePictureBox.TabStop = false;
            this.recipePictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.recipePictureBox_LoadCompleted);
            // 
            // PictureMenuStrip
            // 
            this.PictureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImage,
            this.DeleteImage});
            this.PictureMenuStrip.Name = "PictureMenuStrip";
            this.PictureMenuStrip.Size = new System.Drawing.Size(153, 48);
            this.PictureMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PictureMenuStrip_ItemClicked);
            // 
            // OpenImage
            // 
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(152, 22);
            this.OpenImage.Text = "Cargar imagen";
            // 
            // DeleteImage
            // 
            this.DeleteImage.Name = "DeleteImage";
            this.DeleteImage.Size = new System.Drawing.Size(152, 22);
            this.DeleteImage.Text = "Borrar imagen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Imagen del platillo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Procedimiento";
            // 
            // CostTab
            // 
            this.CostTab.Controls.Add(this.NumberOfPersons);
            this.CostTab.Controls.Add(this.label12);
            this.CostTab.Controls.Add(this.SuggestedPriceLabel);
            this.CostTab.Controls.Add(this.RecipeCostLabel);
            this.CostTab.Controls.Add(this.label14);
            this.CostTab.Controls.Add(this.RecipeNameLabel);
            this.CostTab.Controls.Add(this.CostPictureBox);
            this.CostTab.Controls.Add(this.dataGridView1);
            this.CostTab.Controls.Add(this.LoadRecipeButton);
            this.CostTab.Controls.Add(this.label11);
            this.CostTab.Controls.Add(this.label1);
            this.CostTab.Location = new System.Drawing.Point(4, 22);
            this.CostTab.Name = "CostTab";
            this.CostTab.Padding = new System.Windows.Forms.Padding(3);
            this.CostTab.Size = new System.Drawing.Size(997, 468);
            this.CostTab.TabIndex = 4;
            this.CostTab.Text = "Costos";
            this.CostTab.UseVisualStyleBackColor = true;
            // 
            // NumberOfPersons
            // 
            this.NumberOfPersons.Enabled = false;
            this.NumberOfPersons.Location = new System.Drawing.Point(885, 9);
            this.NumberOfPersons.Name = "NumberOfPersons";
            this.NumberOfPersons.Size = new System.Drawing.Size(106, 20);
            this.NumberOfPersons.TabIndex = 12;
            this.NumberOfPersons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfPersons_KeyPress);
            this.NumberOfPersons.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumberOfPersons_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(722, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Número de personas";
            // 
            // SuggestedPriceLabel
            // 
            this.SuggestedPriceLabel.AutoSize = true;
            this.SuggestedPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestedPriceLabel.Location = new System.Drawing.Point(401, 357);
            this.SuggestedPriceLabel.Name = "SuggestedPriceLabel";
            this.SuggestedPriceLabel.Size = new System.Drawing.Size(0, 37);
            this.SuggestedPriceLabel.TabIndex = 10;
            // 
            // RecipeCostLabel
            // 
            this.RecipeCostLabel.AutoSize = true;
            this.RecipeCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeCostLabel.Location = new System.Drawing.Point(401, 302);
            this.RecipeCostLabel.Name = "RecipeCostLabel";
            this.RecipeCostLabel.Size = new System.Drawing.Size(0, 37);
            this.RecipeCostLabel.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(105, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Nombre";
            // 
            // RecipeNameLabel
            // 
            this.RecipeNameLabel.AutoSize = true;
            this.RecipeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecipeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameLabel.Location = new System.Drawing.Point(176, 6);
            this.RecipeNameLabel.Name = "RecipeNameLabel";
            this.RecipeNameLabel.Size = new System.Drawing.Size(16, 22);
            this.RecipeNameLabel.TabIndex = 7;
            this.RecipeNameLabel.Text = "-";
            // 
            // CostPictureBox
            // 
            this.CostPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostPictureBox.Location = new System.Drawing.Point(726, 35);
            this.CostPictureBox.Name = "CostPictureBox";
            this.CostPictureBox.Size = new System.Drawing.Size(265, 264);
            this.CostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CostPictureBox.TabIndex = 6;
            this.CostPictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Medida,
            this.Porcion,
            this.CostoPorcion,
            this.Proveedor});
            this.dataGridView1.Location = new System.Drawing.Point(24, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 264);
            this.dataGridView1.TabIndex = 5;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Ingrediente";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Unidad";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // Porcion
            // 
            this.Porcion.HeaderText = "Porcion";
            this.Porcion.Name = "Porcion";
            this.Porcion.ReadOnly = true;
            // 
            // CostoPorcion
            // 
            this.CostoPorcion.HeaderText = "Costo por porción";
            this.CostoPorcion.Name = "CostoPorcion";
            this.CostoPorcion.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // LoadRecipeButton
            // 
            this.LoadRecipeButton.Location = new System.Drawing.Point(24, 6);
            this.LoadRecipeButton.Name = "LoadRecipeButton";
            this.LoadRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.LoadRecipeButton.TabIndex = 4;
            this.LoadRecipeButton.Text = "Cargar";
            this.LoadRecipeButton.UseVisualStyleBackColor = true;
            this.LoadRecipeButton.Click += new System.EventHandler(this.LoadRecipeButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(371, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "Precio sugerido de venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo de Producción";
            // 
            // saveRecipeFile
            // 
            this.saveRecipeFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRecipeFile_FileOk);
            // 
            // openRecipeImageFile
            // 
            this.openRecipeImageFile.FileName = "openFileDialog1";
            this.openRecipeImageFile.RestoreDirectory = true;
            this.openRecipeImageFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openRecipeImageFile_FileOk);
            // 
            // openRecipeFile
            // 
            this.openRecipeFile.FileName = "openFileDialog1";
            this.openRecipeFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openRecipeFile_FileOk);
            // 
            // openRecipeForCostDialog
            // 
            this.openRecipeForCostDialog.FileName = "openFileDialog1";
            this.openRecipeForCostDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRecipeForCostDialog_FileOk);
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(892, 441);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Versión 1.0";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 494);
            this.Controls.Add(this.MainInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "Planificador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MainInterface.ResumeLayout(false);
            this.FrontTab.ResumeLayout(false);
            this.FrontTab.PerformLayout();
            this.ProviderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.StockTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.RecipeTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).EndInit();
            this.PictureMenuStrip.ResumeLayout(false);
            this.CostTab.ResumeLayout(false);
            this.CostTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainInterface;
        private System.Windows.Forms.TabPage FrontTab;
        private System.Windows.Forms.TabPage ProviderTab;
        private System.Windows.Forms.TabPage StockTab;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ProviderGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddProvider;
        private System.Windows.Forms.TabPage RecipeTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox RecipeNameBox;
        private System.Windows.Forms.Label label2;
        private ResourcesDataSet resourcesDataSet;
        private ResourcesDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private ResourcesDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button DeleteProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemQueryByNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemQueryByGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItemQueryByProvider;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddIngredientToRecipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.ComboBox IngridientList;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.Button RemoveIngredientToRecipe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ProviderQueryByName;
        private System.Windows.Forms.Button ResetForm;
        private System.Windows.Forms.TabPage CostTab;
        private System.Windows.Forms.Button PrintRecipe;
        private System.Windows.Forms.SaveFileDialog saveRecipeFile;
        private System.Windows.Forms.OpenFileDialog openRecipeImageFile;
        private System.Windows.Forms.PictureBox recipePictureBox;
        private System.Windows.Forms.ContextMenuStrip PictureMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenImage;
        private System.Windows.Forms.ToolStripMenuItem DeleteImage;
        private System.Windows.Forms.OpenFileDialog openRecipeFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox CostPictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadRecipeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label RecipeNameLabel;
        private System.Windows.Forms.Label SuggestedPriceLabel;
        private System.Windows.Forms.Label RecipeCostLabel;
        private System.Windows.Forms.OpenFileDialog openRecipeForCostDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPorcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.TextBox NumberOfPersons;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label15;
    }
}

