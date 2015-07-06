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
    /// Interaction logic for ucManufacturer.xaml
    /// </summary>
    public partial class ucManufacturer : UserControl
    {
        public ucManufacturer()
        {
            InitializeComponent();
            try
            {
                UpdateDataGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("Can not initialize manufacturer");
            }
        }

        private void UpdateDataGrid()
        {
            try
            {
                var oManufacturerList = from oManufacturer in App.oAllManufacturer
                                        select oManufacturer;

                if (txtManufacturer.Text.Length != 0)
                {
                    oManufacturerList = from oManufacturer in oManufacturerList
                                        where oManufacturer.Name.Trim().ToLower().Contains(txtManufacturer.Text.Trim().ToLower())
                                        select oManufacturer;

                }

                dtgManufacturer.ItemsSource = oManufacturerList;
                dtgManufacturer.Items.Refresh();

            }
            catch (Exception)
            {

                MessageBox.Show("Can not update manufacturer data grid");
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
                Manufacturer oManufacturer = new Manufacturer();
                ucAddEditManufacturer oucAddEditManufacturer = new ucAddEditManufacturer(oManufacturer, false);
                winDialog oDialog = new winDialog(oucAddEditManufacturer)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Add a new Manufacturer",
                    Height = 170,
                    Width = 500
                };
                oDialog.ShowDialog();

                UpdateDataGrid();


            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to add manufacturer");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtManufacturer.Text = "";
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgManufacturer.SelectedItem != null)
                {
                    Manufacturer oManufacturer = dtgManufacturer.SelectedItem as Manufacturer;
                    ucAddEditManufacturer oucAddEditManufacturer = new ucAddEditManufacturer(oManufacturer, true);
                    winDialog oDialog = new winDialog(oucAddEditManufacturer)
                    {
                        ShowInTaskbar = true,
                        WindowTitle = "Edit Manufacturer",
                        Height = 170,
                        Width = 500
                    };
                    oDialog.ShowDialog();

                    UpdateDataGrid();
                }
                else
                    MessageBox.Show("Please select a manufacturer from grid");

            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to edit manufacturer");
            }
        }

        private void txtManufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDataGrid();
        }
    }
}

