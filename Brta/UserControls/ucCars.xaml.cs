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
    /// Interaction logic for ucCars.xaml
    /// </summary>
    public partial class ucCars : UserControl
    {
        public ucCars()
        {
            InitializeComponent();
            try
            {
                cboGroup.ItemsSource = App.oAllGroupList;
                UpdateGrid();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize cars");
            }
        }

        private void UpdateGrid()
        {
            try
            {
                var oCarList = from oCar in App.oAllCarList
                               select oCar;

                if (cboGroup.SelectedItem != null)
                {
                    oCarList = from oCar in oCarList
                               where oCar.CarModel.Group.No.ToString() == cboGroup.SelectedValue.ToString()
                               select oCar;                   
                }

                if (cboModel.SelectedItem != null)
                {
                    oCarList = from oCar in oCarList
                               where oCar.CarModel.Name.Trim().ToLower() == cboModel.SelectedValue.ToString().Trim().ToLower()
                               select oCar;
                }

                if (txtRegNo.Text.ToString().Length != 0)
                {
                    oCarList = from oCar in oCarList
                               where oCar.RegNo.ToString().Trim().ToLower().Contains(txtRegNo.Text.ToString().Trim().ToLower())
                               select oCar;
                }

                dtgCars.ItemsSource = oCarList;
                dtgCars.Items.Refresh();
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not update data grid");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cboGroup.SelectedIndex = -1;
                cboModel.SelectedIndex = -1;
                txtRegNo.Text = "";
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not clear filters.");
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car oCar = dtgCars.SelectedItem as Car;
                ucAddEditCars oucAddEditCars = new ucAddEditCars(oCar, true);
                winDialog oDialog = new winDialog(oucAddEditCars)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Edit a Car",
                    Height = 235,
                    Width = 510
                };
                oDialog.ShowDialog();

                UpdateGrid();


            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to edit car.");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void cboGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                UpdateGrid();

                if (cboGroup.SelectedItem != null)
                {

                    List<CarModel> oCarModelList = App.oAllCarModel;

                    var oGroupCarModel = from oCarModel in oCarModelList
                                         where oCarModel.Group.No.ToString() == cboGroup.SelectedValue.ToString()
                                         select oCarModel;

                    oCarModelList = new List<CarModel>(oGroupCarModel);
                    cboModel.ItemsSource = oCarModelList;
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Can not populate car models");
            }
        }

        private void cboModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateGrid();
        }

        private void txtRegNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateGrid();
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car oCar = new Car();
                ucAddEditCars oucAddEditCars = new ucAddEditCars(oCar, false);
                winDialog oDialog = new winDialog(oucAddEditCars)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Add a new Car",
                    Height = 235,
                    Width = 510
                };
                oDialog.ShowDialog();

                UpdateGrid();


            }
            catch (Exception)
            {

                MessageBox.Show("Can not open window to add car.");
            }
        }       
    }
}
