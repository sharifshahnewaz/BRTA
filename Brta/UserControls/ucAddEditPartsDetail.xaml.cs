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
    /// Interaction logic for ucAddEditPartsDetail.xaml
    /// </summary>
    public partial class ucAddEditPartsDetail : UserControl
    {
        PartsDetail oPartsDetail;
        bool isEdit;
        public ucAddEditPartsDetail(PartsDetail oPartsDetail, bool isEdit)
        {
            InitializeComponent();
            try
            {
                this.oPartsDetail = oPartsDetail;
                this.isEdit = isEdit;
                cboParts.ItemsSource = new Parts().SelectAll();
                cboManufacturer.ItemsSource = new Manufacturer().SelectAll();
                if (isEdit)
                {
                    InitializeWindow();
                }
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize window");
            }
        }

        private void InitializeWindow()
        {
            try
            {
                cboParts.SelectedValue = oPartsDetail.Parts.Name;
                cboManufacturer.SelectedValue = oPartsDetail.Manufacturer.Name;
                txtCount.Text = oPartsDetail.Count.ToString();
                txtPrice.Text = oPartsDetail.Price.ToString();
                txtMinimum.Text = oPartsDetail.Minimum.ToString();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize for edit");
            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((cboParts.SelectedItem != null) &&
                    (cboManufacturer.SelectedItem != null) &&
                    (txtCount.Text.Length != 0) &&
                    (txtPrice.Text.Length != 0) &&
                    (txtMinimum.Text.Length != 0))
                {
                    oPartsDetail.Parts = (Parts) cboParts.SelectedItem;
                    oPartsDetail.Manufacturer = (Manufacturer)cboManufacturer.SelectedItem;
                    oPartsDetail.Count = Convert.ToInt32( txtCount.Text.Trim());
                    oPartsDetail.Price = Convert.ToDouble(txtPrice.Text.Trim());
                    oPartsDetail.Minimum = Convert.ToInt32(txtMinimum.Text.Trim());
                    if (!isEdit)
                    {
                        oPartsDetail.Id = App.oAllPartDetailList.Count + 1;
                        App.oAllPartDetailList.Add(oPartsDetail);
                    }
                    Window.GetWindow(this).Close();
                    if (isEdit)
                    {
                        MessageBox.Show("Successfully edited the part.");
                    }
                    else
                    {
                        MessageBox.Show("Successfully added new part.");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not save now.");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            
            Window.GetWindow(this).Close();
        }
    }
}
