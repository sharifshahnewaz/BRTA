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
    /// Interaction logic for ucAddEditCars.xaml
    /// </summary>
    public partial class ucAddEditCars : UserControl
    {
        Car oCar;
        bool isEdit;
        public ucAddEditCars(Car oCar, bool isEdit)
        {
            InitializeComponent();
            try
            {
                this.oCar = oCar;
                this.isEdit = isEdit;
                cboGroup.ItemsSource = App.oAllGroupList;
                if (isEdit)
                {
                    InitializeWindow();
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize add edit car");
            }
        }

        private void InitializeWindow()
        {
            try
            {
                cboGroup.SelectedValue = oCar.CarModel.Group.No;
                cboModel.SelectedValue = oCar.CarModel.Name;
                txtRegNo.Text = oCar.RegNo;
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize Window");
            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((cboModel.SelectedItem != null) &&
                    (txtRegNo.Text.Length != 0))
                {
                    oCar.CarModel = cboModel.SelectedItem as CarModel;
                    oCar.RegNo = txtRegNo.Text.ToString();

                    if (!isEdit)
                    {
                        oCar.Id = App.oAllCarList.Count + 1;
                        App.oAllCarList.Add(oCar);
                    }

                    Window.GetWindow(this).Close();
                    if (isEdit)
                    {
                        MessageBox.Show("Successfully edited the car.");
                    }
                    else
                    {
                        MessageBox.Show("Successfully added new car.");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not save details.");
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
                    Group oSelectedGroup = cboGroup.SelectedItem as Group;

                    var grpCarModelList = from oCarModel in App.oAllCarModel
                                          where oCarModel.Group.No.ToString().Trim().Equals(oSelectedGroup.No.ToString().Trim())
                                          select oCarModel;
                    cboModel.ItemsSource = grpCarModelList;

                    
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not update model combo source");
            }
        }

        
    }

    
}
