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
    /// Interaction logic for ucAddEditCarModel.xaml
    /// </summary>
    public partial class ucAddEditCarModel : UserControl
    {
        CarModel oCarModel;
        bool isEdit;
        public ucAddEditCarModel(CarModel oCarModel, bool isEdit)
        {
            InitializeComponent();
            try
            {
                this.oCarModel = oCarModel;
                this.isEdit = isEdit;
                cboGroup.ItemsSource = App.oAllGroupList;
                if (isEdit)
                {
                    InitializeWindow();
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize add edit car model");
            }
        }

        private void InitializeWindow()
        {
            try
            {
                cboGroup.SelectedValue = oCarModel.Group.No;
                txtName.Text = oCarModel.Name;
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
                if ((cboGroup.SelectedItem != null) &&
                    (txtName.Text.Length != 0))
                {
                    oCarModel.Group = cboGroup.SelectedItem as Group;
                    oCarModel.Name = txtName.Text.ToString();

                    if (!isEdit)
                    {
                        oCarModel.Id = App.oAllCarModel.Count + 1;
                        App.oAllCarModel.Add(oCarModel);
                    }

                    Window.GetWindow(this).Close();
                    if (isEdit)
                    {
                        MessageBox.Show("Successfully edited the car model.");
                    }
                    else
                    {
                        MessageBox.Show("Successfully added new car model.");
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
    }
}
