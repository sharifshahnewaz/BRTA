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
  
    public partial class ucToolsPreview : UserControl
    {

        public List<PartsDetail> oAllPartsDetailList;


        public ucToolsPreview()
        {
            InitializeComponent();
            InitializeCombobox();
            oAllPartsDetailList = App.oAllPartDetailList;
            dtgItems.ItemsSource = oAllPartsDetailList;
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

                if (cboGroup.SelectedItem != null)
                {
                    cboCategory.ItemsSource = new Category().SelectAll();

                    cboManufacturer.ItemsSource = App.oAllManufacturer;

                    UpdateDataGrid();
                }



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
                var oPartsDetailList = from oPartsDetail in App.oAllPartDetailList
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
            OpenUsePartWindow();
        }

        private void OpenUsePartWindow()
        {
            try
            {
                if (dtgItems.SelectedItem != null)
                {
                    PartsDetail oPartsDetail = (PartsDetail)dtgItems.SelectedItem;
                    winDialog oDialog = new winDialog(new ucDelivery(oPartsDetail))
                    {
                        ShowInTaskbar = true,
                        WindowTitle = "Use tool in car",
                        Height = 530,
                        Width = 600
                    };
                    oDialog.ShowDialog();

                    dtgItems.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a part");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not use part");
            }
        }

        private void btnUseTool_Click(object sender, RoutedEventArgs e)
        {
            OpenUsePartWindow();
        }

        private void btnAddPartsDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PartsDetail oPartsDetail = new PartsDetail();

                ucAddEditPartsDetail oucAddEditPartsDetail = new ucAddEditPartsDetail(oPartsDetail,false);

                winDialog oDialog = new winDialog(oucAddEditPartsDetail)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Add a new Parts",
                    Height = 240,
                    Width = 560
                };
                oDialog.ShowDialog();

                dtgItems.Items.Refresh();

            }
            catch (Exception)
            {

                MessageBox.Show("Can not add parts");
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgItems.SelectedItem != null)
                {
                    PartsDetail oPartsDetail = (PartsDetail)dtgItems.SelectedItem;

                    ucAddEditPartsDetail oucAddEditPartsDetail = new ucAddEditPartsDetail(oPartsDetail, true);

                    winDialog oDialog = new winDialog(oucAddEditPartsDetail)
                    {
                        ShowInTaskbar = true,
                        WindowTitle = "Edit Parts",
                        Height = 240,
                        Width = 560
                    };
                    oDialog.ShowDialog();

                    dtgItems.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a parts");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not add parts");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cboGroup.SelectedIndex = -1;
                cboManufacturer.SelectedIndex = -1;
                cboCategory.SelectedIndex = -1;
                UpdateDataGrid();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not clear filters");
            }
        }
    }
}
