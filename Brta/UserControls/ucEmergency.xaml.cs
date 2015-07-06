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
using Microsoft.Windows.Controls;

namespace Brta.UserControls
{
    /// <summary>
    /// Interaction logic for ucToolsPreview.xaml
    /// </summary>
    /// 

    public partial class ucEmergency : UserControl
    {

        public List<PartsDetail> oAllPartsDetailList;


        public ucEmergency()
        {
            InitializeComponent();
            InitializeCombobox();
            oAllPartsDetailList = App.oAllPartDetailList;
            UpdateDataGrid();
        }

        private void InitializeCombobox()
        {
            try
            {

                try
                {
                    cboGroup.ItemsSource = App.oAllGroupList;
                }
                catch (Exception)
                {

                    MessageBox.Show("Can not select all group.");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not initialize combo box.");
            }
        }

        private void cboGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {


                cboCategory.ItemsSource = new Category().SelectAll();

                cboManufacturer.ItemsSource =App.oAllManufacturer;

                UpdateDataGrid();



            }
            catch (Exception)
            {

                MessageBox.Show("Can not populate combobox based on group");
            }
        }

        private void UpdateDataGrid()
        {
            try
            {
                var oPartsDetailList = from oPartsDetail in oAllPartsDetailList
                                       where oPartsDetail.Count<=oPartsDetail.Minimum
                                       select oPartsDetail;

                if (cboGroup.SelectedItem != null)
                {
                    oPartsDetailList = from oPartsDetail in oPartsDetailList
                                       where oPartsDetail.Parts.Group.No.ToString() == cboGroup.SelectedValue.ToString()
                                       select oPartsDetail;
                    
                }

                if (cboCategory.SelectedItem != null)
                {

                    oPartsDetailList = from oPartsDetail in oPartsDetailList
                                       where oPartsDetail.Parts.PartCategory.Name.Trim().ToLower().Equals(cboCategory.SelectedValue.ToString().Trim().ToLower())
                                       select oPartsDetail;
                    
                }

                if (cboManufacturer.SelectedItem != null)
                {
                    oPartsDetailList = from oPartsDetail in oPartsDetailList
                                       where oPartsDetail.Manufacturer.Name.Trim().ToLower().Equals(cboManufacturer.SelectedValue.ToString().Trim().ToLower())
                                       select oPartsDetail;
                    
                }
                dtgItems.ItemsSource = oPartsDetailList;
                dtgItems.Items.Refresh();



            }
            catch (Exception)
            {

                MessageBox.Show("Can not update result.");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void cboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void cboManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void dtgItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (dtgItems.SelectedItem != null)
                {
                    PartsDetail oPartsDetail = (PartsDetail)dtgItems.SelectedItem;
                    winDialog oDialog = new winDialog(new ucDelivery(oPartsDetail))
                    {
                        ShowInTaskbar = false,
                        Height = 530,
                        Width = 600
                    };
                    oDialog.ShowDialog();

                    dtgItems.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a tool");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not use part");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cboGroup.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            cboManufacturer.SelectedIndex = -1;
        }
    }
}
