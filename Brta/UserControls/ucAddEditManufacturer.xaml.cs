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
    /// Interaction logic for ucAddEditManufacturer.xaml
    /// </summary>
    public partial class ucAddEditManufacturer : UserControl
    {
        Manufacturer oManufacturer;
        bool isEdit;

        public ucAddEditManufacturer(Manufacturer oManufacturer, bool isEdit)
        {
            InitializeComponent();
            try
            {
                this.oManufacturer = oManufacturer;
                this.isEdit = isEdit;                
                if (isEdit)
                {
                    InitializeWindow();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not initialize add edit Manufacturer");
            }
        }

        private void InitializeWindow()
        {
            try
            {
                txtName.Text = oManufacturer.Name;
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
                if ((txtName.Text.Length != 0))
                {

                    oManufacturer.Name = txtName.Text.ToString();

                    if (!isEdit)
                    {
                        oManufacturer.Id = App.oAllManufacturer.Count + 1;
                        App.oAllManufacturer.Add(oManufacturer);
                    }

                    Window.GetWindow(this).Close();
                    if (isEdit)
                    {
                        MessageBox.Show("Successfully edited the Manufacturer.");
                    }
                    else
                    {
                        MessageBox.Show("Successfully added new Manufacturer.");
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
