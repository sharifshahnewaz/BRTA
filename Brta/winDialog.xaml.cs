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
using System.Windows.Shapes;

namespace Brta
{
    /// <summary>
    /// Interaction logic for winDialog.xaml
    /// </summary>
   
        public partial class winDialog : Window
        {
            public string WindowTitle
            {
                get { return this.Title; }
                set
                {
                    this.Title = value;
                    tbxTitle.Text = value;
                }
            }

            public winDialog(FrameworkElement containerObject)
            {
                InitializeComponent();
                this.container.Children.Clear();
                this.container.Children.Add(containerObject);
            }

            private void btnOk_Click(object sender, RoutedEventArgs e)
            {
                this.DialogResult = true;

                CloseDialogBox();
            }

            private void btnCancel_Click(object sender, RoutedEventArgs e)
            {
                this.DialogResult = false;

                CloseDialogBox();
            }

            private void CloseDialogBox()
            {
                this.Close();
            }

            private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            {
                try
                {
                    this.DragMove();
                }
                catch (Exception)
                {
                }

            }

            private void btnClose_Click(object sender, RoutedEventArgs e)
            {
                //try
                //{
                try
                {
                    this.DialogResult = false;
                }
                catch (Exception)
                {
                }

                CloseDialogBox();
                //}
                //catch (Exception)
                //{
                //}            
            }


        }

    }

