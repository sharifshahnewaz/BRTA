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
    /// Interaction logic for ucCarModel.xaml
    /// </summary>
    public partial class ucCarModel : UserControl
    {
        public ucCarModel()
        {
            InitializeComponent();
            try
            {
                cboGroup.ItemsSource = App.oAllGroupList;
                UpdateDataGrid();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize car model");
            }
        }

        private void UpdateDataGrid()
        {
            try
            {
                var oCarModelList = from oCarModel in App.oAllCarModel
                                    select oCarModel;

                if (cboGroup.SelectedItem != null)
                {
                    oCarModelList = from oCarModel in oCarModelList
                                    where oCarModel.Group.No.ToString() == cboGroup.SelectedValue.ToString()
                                    select oCarModel;

                }

                dtgCarModels.ItemsSource = oCarModelList;
                dtgCarModels.Items.Refresh();
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not update car model data grid");
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

        private void btnAddCarModel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CarModel oCarModel = new CarModel();
                ucAddEditCarModel oucAddEditCarModel = new ucAddEditCarModel(oCarModel, false);
                winDialog oDialog = new winDialog(oucAddEditCarModel)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Add a new Car Model",
                    Height = 200,
                    Width = 500
                };
                oDialog.ShowDialog();

                UpdateDataGrid();


            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not open window to add car model");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cboGroup.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgCarModels.SelectedItem != null)
                {
                    CarModel oCarModel = dtgCarModels.SelectedItem as CarModel;
                    ucAddEditCarModel oucAddEditCarModel = new ucAddEditCarModel(oCarModel, true);
                    winDialog oDialog = new winDialog(oucAddEditCarModel)
                    {
                        ShowInTaskbar = true,
                        WindowTitle = "Edit Car Model",
                        Height = 200,
                        Width = 500
                    };
                    oDialog.ShowDialog();

                    UpdateDataGrid();
                }

                else
                {
                    MessageBox.Show("Please select a car model");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to edit car model");
            }
        }
    }
}
