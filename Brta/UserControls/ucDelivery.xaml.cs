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
    /// Interaction logic for ucDelivery.xaml
    /// </summary>
    public partial class ucDelivery : UserControl
    {
        PartsDetail oPartsDetail;
        List<Car> oAllCarList;
        List<RepairsHistory> oAllReapirsHistory;

        public ucDelivery(PartsDetail oPartsDetail)
        {
            InitializeComponent();
            this.oPartsDetail = oPartsDetail;
            InitializeWindow();
            oAllCarList = App.oAllCarList;
            this.oAllReapirsHistory = App.oAllRepairsHistory;
            dtgCars.ItemsSource = oAllCarList;
        }

        private void UpdateDataGrid()
        {
            try
            {
                var oCarList = from oCar in oAllCarList
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
                               where oCar.CarModel.Name.Trim().ToLower().Equals(cboModel.SelectedValue.ToString().Trim().ToLower())
                               select oCar;
                }

                if (txtRegNo.Text != null)
                {
                    oCarList = from oCar in oCarList
                               where oCar.RegNo.Trim().ToLower().Contains(txtRegNo.Text.Trim().ToLower())
                               select oCar;
                }

                dtgCars.ItemsSource = oCarList;
                dtgCars.Items.Refresh();

            }
            catch (Exception)
            {

                MessageBox.Show("Can not update datagrid.");
            }
        }

        private void InitializeWindow()
        {
            try
            {
                txtCategory.Text = oPartsDetail.Parts.PartCategory.Name.ToString();
                txtCount.Text = oPartsDetail.Count.ToString();
                txtManufacturer.Text = oPartsDetail.Manufacturer.Name.ToString();
                txtMinimum.Text = oPartsDetail.Minimum.ToString();
                txtPartName.Text = oPartsDetail.Parts.Name.ToString();
                txtPrice.Text = oPartsDetail.Price.ToString();
                cboGroup.ItemsSource = App.oAllGroupList;
            }
            catch (Exception)
            {

                MessageBox.Show("Can not initialize window.");
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
                if (cboGroup.SelectedItem != null)
                {
                    List<CarModel> oCarModelList = App.oAllCarModel;

                    var grpCarModelList = from oCarModel in oCarModelList
                                          where oCarModel.Group.No.ToString() == cboGroup.SelectedValue.ToString()
                                          select oCarModel;

                    oCarModelList = new List<CarModel>(grpCarModelList);


                    cboModel.ItemsSource = oCarModelList;

                    UpdateDataGrid();
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not update combo source");
            }
        }

        private void cboModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void txtRegNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnAddToCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgCars.SelectedItem != null)
                {
                    var result = MessageBox.Show("Do you want to add it", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        RepairsHistory oRepairsHistory = new RepairsHistory();
                        oRepairsHistory.Id = oAllReapirsHistory.Count() + 1;
                        oRepairsHistory.Car = dtgCars.SelectedItem as Car;
                        oRepairsHistory.Comments = txtComment.Text;
                        oRepairsHistory.PartsDetail = oPartsDetail;
                        oPartsDetail.Count -= 1;
                        oRepairsHistory.RepairedBy = App.currentUser;
                        oRepairsHistory.RepairedTime = DateTime.Now;
                        oAllReapirsHistory.Add(oRepairsHistory);
                        Window.GetWindow(this).Close();

                    }

                }

                else
                {
                    MessageBox.Show("Please Select a car form list.");
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not add to car");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cboGroup.SelectedIndex = -1;
            cboModel.SelectedIndex = -1;
            txtRegNo.Text = "";
        }
    }
}
