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
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
            try
            {
                App.menus.Visibility = Visibility.Collapsed;
                App.grdLeft.Visibility = Visibility.Collapsed;
                

            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize login");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Window winLogin = Window.GetWindow(this);
                winLogin.Close();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Can not close window this time");
            }
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //txtUserName.Text = "Admin";
                //pwbPassword.Password = "Admin";

                List<User> oUserList = App.oAllUser;

                var currentUser = from oUser in oUserList
                                  where oUser.UserId == txtUserName.Text
                                  select oUser;
                if (currentUser.Count<User>() == 0)
                {
                    txtErrorMsg.Text = "Invalid UserID or password";
                }
                else
                {
                    

                    User oUser = (User)currentUser.First<User>();

                    if (oUser.Password == pwbPassword.Password)
                    {

                        App.currentUser = oUser;

                        /// login verify logic goes here
                        /// 
                        App.grdMain.Children.Clear();
                        App.menus.Visibility = Visibility.Visible;
                        App.grdLeft.Visibility = Visibility.Visible;
                        App.mainWindow.SizeToContent = SizeToContent.Manual;
                        App.mainWindow.WindowStyle = WindowStyle.ThreeDBorderWindow;
                        App.mainWindow.WindowState = WindowState.Maximized;
                        ucToolsPreview oucToolsPreview = new ucToolsPreview();

                        App.grdMain.Children.Add(oucToolsPreview);
                    }

                    else
                    {
                        txtErrorMsg.Text = "Invalid UserID or password";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not Login now.");
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
