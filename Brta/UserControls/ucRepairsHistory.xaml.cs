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
    /// Interaction logic for ucRepairsHistory.xaml
    /// </summary>
    public partial class ucRepairsHistory : UserControl
    {
        public ucRepairsHistory()
        {
            InitializeComponent();
            try
            {
                dtgHistory.ItemsSource = App.oAllRepairsHistory;
                cboGroup.ItemsSource = App.oAllGroupList;
                cboRepairedBy.ItemsSource = App.oAllUser;
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize Repairs History");
            }
        }

        private void cboGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                UpdateDataGrid();

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

        private void UpdateDataGrid()
        {
            try
            {
                var oFilteredRepairHistory = from oRepairsHistory in App.oAllRepairsHistory
                                       select oRepairsHistory;

                if (cboGroup.SelectedItem != null)
                {
                    oFilteredRepairHistory = from oRepairsHistory in oFilteredRepairHistory
                                       where oRepairsHistory.Car.CarModel.Group.No.ToString() == cboGroup.SelectedValue.ToString()
                                       select oRepairsHistory;
                    dtgHistory.ItemsSource = oFilteredRepairHistory;
                }

                if (cboModel.SelectedItem != null)
                {
                    oFilteredRepairHistory = from oRepairsHistory in oFilteredRepairHistory
                                             where oRepairsHistory.Car.CarModel.Name.ToString().Trim().ToLower().Equals(cboModel.SelectedValue.ToString().Trim().ToLower())
                                             select oRepairsHistory;
                    dtgHistory.ItemsSource = oFilteredRepairHistory;
                }

                if (txtRegNo.Text != null)
                {
                    oFilteredRepairHistory = from oRepairsHistory in oFilteredRepairHistory
                                             where oRepairsHistory.Car.RegNo.ToString().Trim().ToLower().Contains(txtRegNo.Text.ToString().Trim().ToLower())
                                             select oRepairsHistory;
                    dtgHistory.ItemsSource = oFilteredRepairHistory;
                }

                if (cboRepairedBy.SelectedItem != null)
                {
                    oFilteredRepairHistory = from oRepairsHistory in oFilteredRepairHistory
                                             where oRepairsHistory.RepairedBy.UserId == cboRepairedBy.SelectedValue.ToString()
                                             select oRepairsHistory;
                    dtgHistory.ItemsSource = oFilteredRepairHistory;
                }
                dtgHistory.Items.Refresh();

                if (dtpFromDate.SelectedDate != null)
                {
                    oFilteredRepairHistory = from oRepairsHistory in oFilteredRepairHistory
                                             where oRepairsHistory.RepairedTime.Date >= dtpFromDate.SelectedDate.Value.Date
                                             select oRepairsHistory;
                    dtgHistory.ItemsSource = oFilteredRepairHistory;
                }

                if (dtpToDate.SelectedDate != null)
                {
                    oFilteredRepairHistory = from oRepairsHistory in oFilteredRepairHistory
                                             where oRepairsHistory.RepairedTime.Date <= dtpToDate.SelectedDate.Value.Date
                                             select oRepairsHistory;
                    dtgHistory.ItemsSource = oFilteredRepairHistory;
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Can not update result.");
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void cboRepairedBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void dtpFromDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void dtpToDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cboGroup.SelectedIndex = -1;
                cboModel.SelectedIndex = -1;
                cboRepairedBy.SelectedIndex = -1;
                txtRegNo.Text = "";
                dtpFromDate.SelectedDate = DateTime.MinValue;
                dtpToDate.SelectedDate = DateTime.MaxValue;
            }
            catch (Exception)
            {

                MessageBox.Show("Can not clear filters");
            }
        }
    }
}
