namespace Planificador
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.NameData = new System.Windows.Forms.TextBox();
            this.GroupData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProviderList = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesDataSet = new Planificador.ResourcesDataSet();
            this.UnitList = new System.Windows.Forms.ComboBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.providerTableAdapter = new Planificador.ResourcesDataSetTableAdapters.ProviderTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NameData
            // 
            this.NameData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NameData.Location = new System.Drawing.Point(118, 12);
            this.NameData.MaxLength = 50;
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(153, 20);
            this.NameData.TabIndex = 1;
            // 
            // GroupData
            // 
            this.GroupData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GroupData.Location = new System.Drawing.Point(118, 38);
            this.GroupData.MaxLength = 90;
            this.GroupData.Name = "GroupData";
            this.GroupData.Size = new System.Drawing.Size(153, 20);
            this.GroupData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unidad";
            // 
            // ProviderList
            // 
            this.ProviderList.DataSource = this.providerBindingSource;
            this.ProviderList.DisplayMember = "IdProveedor";
            this.ProviderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProviderList.FormattingEnabled = true;
            this.ProviderList.Location = new System.Drawing.Point(118, 69);
            this.ProviderList.Name = "ProviderList";
            this.ProviderList.Size = new System.Drawing.Size(153, 21);
            this.ProviderList.TabIndex = 3;
            this.ProviderList.ValueMember = "IdProveedor";
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
            // UnitList
            // 
            this.UnitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitList.FormattingEnabled = true;
            this.UnitList.Items.AddRange(new object[] {
            "KG",
            "L",
            "PIEZA"});
            this.UnitList.Location = new System.Drawing.Point(118, 96);
            this.UnitList.Name = "UnitList";
            this.UnitList.Size = new System.Drawing.Size(153, 21);
            this.UnitList.Sorted = true;
            this.UnitList.TabIndex = 4;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(196, 149);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Agregar";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            // 
            // PriceData
            // 
            this.PriceData.Location = new System.Drawing.Point(118, 123);
            this.PriceData.MaxLength = 20;
            this.PriceData.Name = "PriceData";
            this.PriceData.Size = new System.Drawing.Size(153, 20);
            this.PriceData.TabIndex = 5;
            this.PriceData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceData_KeyPress);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 186);
            this.Controls.Add(this.PriceData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.UnitList);
            this.Controls.Add(this.ProviderList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupData);
            this.Controls.Add(this.NameData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.Text = "Agregar Insumo";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameData;
        private System.Windows.Forms.TextBox GroupData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProviderList;
        private System.Windows.Forms.ComboBox UnitList;
        private System.Windows.Forms.Button AddItemButton;
        private ResourcesDataSet resourcesDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private ResourcesDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceData;
    }
}