using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Planificador.Properties;

namespace Planificador
{
    public partial class RecipePrinter : Form
    {
        private readonly BindingList<Ingredient> _recipeIngredients;

        public RecipePrinter(DataGridView dataTable, string recipeName, string recipeProcedure, string imageLocation)
        {
            try
            {
                _recipeIngredients = GetTableData(dataTable);

                if (string.IsNullOrEmpty(imageLocation))
                {
                    imageLocation = Directory.GetCurrentDirectory() + @"//NoImage.bmp";
                    Resources.NoImage.Save(imageLocation, ImageFormat.Bmp);
                }


                var parameters = new ReportParameterCollection
                {
                    new ReportParameter("RecipeTitle", recipeName),
                    new ReportParameter("RecipeText", recipeProcedure),
                    new ReportParameter("Path", imageLocation)
                };

                InitializeComponent();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _recipeIngredients));
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
        }

        private void RecipePrinter_Load(object sender, EventArgs e)
        {
            try
            {
                IngredientBindingSource.DataSource = _recipeIngredients;
                reportViewer1.RefreshReport();
            }
            catch (Exception ext)
            {
                Console.Write(ext.GetBaseException());
            }
        }

        private static BindingList<Ingredient> GetTableData(DataGridView dataTable)
        {
            var ingredientList = new BindingList<Ingredient>();
            foreach (DataGridViewRow ingredient in dataTable.Rows)
            {
                var name = ingredient.Cells[0].Value.ToString();
                var value = ingredient.Cells[1].Value.ToString();
                var unit = ingredient.Cells[2].Value.ToString();
                ingredientList.Add(new Ingredient(name, value, unit));
            }
            return ingredientList;
        }
    }
}