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
    /// Interaction logic for ucAddEditCategory.xaml
    /// </summary>
    public partial class ucAddEditCategory : UserControl
    {
        Category oCategory;
        bool isEdit;
        public ucAddEditCategory(Category oCategory, bool isEdit)
        {
            InitializeComponent();
            try
            {
                this.oCategory = oCategory;
                this.isEdit = isEdit;                
                if (isEdit)
                {
                    InitializeWindow();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not initialize add edit Category");
            }
        }

        private void InitializeWindow()
        {
            try
            {
                txtName.Text = oCategory.Name;
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

                    oCategory.Name = txtName.Text.ToString();

                    if (!isEdit)
                    {
                        oCategory.Id = App.oAllCategory.Count + 1;
                        App.oAllCategory.Add(oCategory);
                    }

                    Window.GetWindow(this).Close();
                    if (isEdit)
                    {
                        MessageBox.Show("Successfully edited the Category.");
                    }
                    else
                    {
                        MessageBox.Show("Successfully added new Category.");
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
