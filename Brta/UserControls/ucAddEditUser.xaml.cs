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
    /// Interaction logic for ucAddUser.xaml
    /// </summary>
    public partial class ucAddEditUser : UserControl
    {
        User oUser = new User();
        public bool isEdit;

        public ucAddEditUser( User oUser, bool isEdit)
        {
            InitializeComponent();
            cboUserType.ItemsSource = new List<string>() { "Administrator", "User" };
            this.oUser = oUser;
            this.isEdit = isEdit;
            if (isEdit)
            {
                InitializeWindow();
            }
        }

        private void InitializeWindow()
        {
            try
            {
                txtUserId.Text = oUser.UserId.ToString();
                txtUserName.Text = oUser.Name.ToString();
                pwbPassword.Password = oUser.Password.ToString();
                pwbRePassword.Password = oUser.Password.ToString();
                cboUserType.SelectedValue = oUser.Type;

            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not initialize window");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();   
        }

        private void CloseWindow()
        {
            try
            {
                Window oParentWindow = Window.GetWindow(this);
                oParentWindow.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Can not close dialog window this time");
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((txtUserId.Text.Length != 0) &&
                        (txtUserName.Text.Length != 0) &&
                        (pwbPassword.Password.Length != 0) &&
                        (pwbRePassword.Password.Length != 0) &&
                        (cboUserType.SelectedItem != null))
                {
                    if (pwbPassword.Password == pwbRePassword.Password)
                    {
                        oUser.UserId = txtUserId.Text.Trim();
                        oUser.Name = txtUserName.Text;
                        oUser.Password = pwbPassword.Password;
                        oUser.Type = cboUserType.SelectedValue.ToString();
                        if (!isEdit)
                        {
                            oUser.Id = App.oAllUser.Count + 1;
                            App.oAllUser.Add(oUser);
                        }
                        CloseWindow();

                        if (isEdit)
                        {
                            MessageBox.Show("Successfully edited.");
                        }

                        else
                        {
                            MessageBox.Show("user successfully added");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password not matched");
                    }
                }
                else
                {
                    MessageBox.Show("Enter value in the fields");
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not save now");
            }
            
            
        }

       

    }
}
