namespace Planificador
{
    partial class AddProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProvider));
            this.ProviderIdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.TelephoneBox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.RFCBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.ZIPCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddProviderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProviderIdBox
            // 
            this.ProviderIdBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ProviderIdBox.Location = new System.Drawing.Point(128, 13);
            this.ProviderIdBox.MaxLength = 20;
            this.ProviderIdBox.Name = "ProviderIdBox";
            this.ProviderIdBox.Size = new System.Drawing.Size(290, 20);
            this.ProviderIdBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NameBox.Location = new System.Drawing.Point(128, 39);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(290, 20);
            this.NameBox.TabIndex = 1;
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.Location = new System.Drawing.Point(128, 67);
            this.TelephoneBox.MaxLength = 25;
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Size = new System.Drawing.Size(290, 20);
            this.TelephoneBox.TabIndex = 2;
            this.TelephoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneBox_KeyPress);
            // 
            // ContactBox
            // 
            this.ContactBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ContactBox.Location = new System.Drawing.Point(128, 94);
            this.ContactBox.MaxLength = 90;
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(290, 20);
            this.ContactBox.TabIndex = 3;
            // 
            // RFCBox
            // 
            this.RFCBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RFCBox.Location = new System.Drawing.Point(128, 121);
            this.RFCBox.MaxLength = 30;
            this.RFCBox.Name = "RFCBox";
            this.RFCBox.Size = new System.Drawing.Size(290, 20);
            this.RFCBox.TabIndex = 4;
            // 
            // AdressBox
            // 
            this.AdressBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AdressBox.Location = new System.Drawing.Point(128, 149);
            this.AdressBox.MaxLength = 90;
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(290, 20);
            this.AdressBox.TabIndex = 5;
            // 
            // ZIPCodeBox
            // 
            this.ZIPCodeBox.Location = new System.Drawing.Point(128, 175);
            this.ZIPCodeBox.MaxLength = 15;
            this.ZIPCodeBox.Name = "ZIPCodeBox";
            this.ZIPCodeBox.Size = new System.Drawing.Size(290, 20);
            this.ZIPCodeBox.TabIndex = 6;
            this.ZIPCodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZIPCodeBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "IdProveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "P. Contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "RFC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "C. P.";
            // 
            // AddProviderButton
            // 
            this.AddProviderButton.Location = new System.Drawing.Point(343, 212);
            this.AddProviderButton.Name = "AddProviderButton";
            this.AddProviderButton.Size = new System.Drawing.Size(75, 23);
            this.AddProviderButton.TabIndex = 14;
            this.AddProviderButton.Text = "Agregar";
            this.AddProviderButton.UseVisualStyleBackColor = true;
            this.AddProviderButton.Click += new System.EventHandler(this.AddProviderButton_Click);
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.AddProviderButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZIPCodeBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.RFCBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ProviderIdBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProvider";
            this.Text = "Agregar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProviderIdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox TelephoneBox;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.TextBox RFCBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox ZIPCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddProviderButton;
    }
}