using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BrtaModel;

namespace Brta.UserControls
{
    /// <summary>
    /// Interaction logic for ucCategories.xaml
    /// </summary>
    public partial class ucCategories : UserControl
    {
        public ucCategories()
        {
            InitializeComponent();
            try
            {
                UpdateDataGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("Can not initialize category");
            }
        }

        private void UpdateDataGrid()
        {
            try
            {
                var oCategoryList = from oCategory in App.oAllCategory
                                    select oCategory;

                if (txtCategory.Text.Length!=0)
                {
                    oCategoryList = from oCategory in oCategoryList
                                    where oCategory.Name.Trim().ToLower().Contains(txtCategory.Text.Trim().ToLower())
                                    select oCategory;

                }

                dtgCategories.ItemsSource = oCategoryList;
                dtgCategories.Items.Refresh();

            }
            catch (Exception)
            {

                MessageBox.Show("Can not update category data grid");
            }
        }

        private void cboGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Category oCategory= new Category();
                ucAddEditCategory oucAddEditCategory = new ucAddEditCategory(oCategory, false);
                winDialog oDialog = new winDialog(oucAddEditCategory)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Add a new Category",
                    Height = 170,
                    Width = 500
                };
                oDialog.ShowDialog();

                UpdateDataGrid();


            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to add category");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtCategory.Text = "";
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgCategories.SelectedItem != null)
                {
                    Category oCategory = dtgCategories.SelectedItem as Category;
                    ucAddEditCategory oucAddEditCategory = new ucAddEditCategory(oCategory, true);
                    winDialog oDialog = new winDialog(oucAddEditCategory)
                    {
                        ShowInTaskbar = true,
                        WindowTitle = "Edit Category",
                        Height = 170,
                        Width = 500
                    };
                    oDialog.ShowDialog();

                    UpdateDataGrid();
                }
                else
                    MessageBox.Show("Please select a category from grid");

            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to edit category");
            }
        }

        private void txtCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
