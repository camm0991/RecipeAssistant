using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Planificador
{
    public partial class AddProvider : Form
    {
        public delegate void ReloadTable(TableNamesEnum.TableName tableName);

        private readonly ReloadTable _reloadTable;

        public AddProvider(ReloadTable reloadTable)
        {
            InitializeComponent();
            _reloadTable = reloadTable;
        }

        //Event when the 'Agregar' button is triggered
        private void AddProviderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProviderIdBox.Text) || string.IsNullOrWhiteSpace(NameBox.Text)
                || string.IsNullOrWhiteSpace(TelephoneBox.Text) || string.IsNullOrWhiteSpace(ContactBox.Text)
                || string.IsNullOrWhiteSpace(RFCBox.Text) || string.IsNullOrWhiteSpace(AdressBox.Text) ||
                string.IsNullOrWhiteSpace(ZIPCodeBox.Text))
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
                    const string sql =
                        "INSERT INTO Provider (IdProveedor, Nombre, Telefono, PersonaContacto, RFC, Direccion, CP)" +
                        " values (@id,@nombre,@telefono,@persona,@rfc,@direccion,@cp)";

                    connection.Open();

                    //Association of the conection string and the SQL query
                    var command = new SqlCommand(sql, connection);
                    //Replacing the variables in the query for the fields in the 'AddProvider' form
                    command.Parameters.AddWithValue("@id", ProviderIdBox.Text);
                    command.Parameters.AddWithValue("@nombre", NameBox.Text);
                    command.Parameters.AddWithValue("@telefono", TelephoneBox.Text);
                    command.Parameters.AddWithValue("@persona", ContactBox.Text);
                    command.Parameters.AddWithValue("@rfc", RFCBox.Text);
                    command.Parameters.AddWithValue("@direccion", AdressBox.Text);
                    command.Parameters.AddWithValue("@cp", ZIPCodeBox.Text);

                    //Try to execute the query
                    try
                    {
                        command.ExecuteNonQuery();
                        //If the query was successful the form is restarted
                        ProviderIdBox.Text = null;
                        NameBox.Text = null;
                        TelephoneBox.Text = null;
                        ContactBox.Text = null;
                        RFCBox.Text = null;
                        AdressBox.Text = null;
                        ZIPCodeBox.Text = null;
                        _reloadTable.Invoke(TableNamesEnum.TableName.Provider);
                        //The user is informed that the query was made correctly
                        MessageBox.Show(@"Proveedor agregado correctamente");
                    }
                    catch (SqlException exception)
                    {
                        //The user is informed that there was a problem when executing the query
                        MessageBox.Show(@"Error al añadir proveedor");
                        Console.Write(exception.GetBaseException());
                    }
                }
            }
        }

        private void TelephoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('-');
        }

        private void ZIPCodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}