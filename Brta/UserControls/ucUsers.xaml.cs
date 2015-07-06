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
    /// Interaction logic for ucUsers.xaml
    /// </summary>
    public partial class ucUsers : UserControl
    {
        public ucUsers()
        {
            InitializeComponent();
            dtgUsers.ItemsSource = App.oAllUser;
            cboType.ItemsSource = new List<string>() { "Administrator","User"};
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            try
            {
                var oUserList = from oUser in App.oAllUser
                                select oUser;
                if (cboType.SelectedItem != null)
                {
                   
                    oUserList = from oUser in oUserList
                                where oUser.Type.ToString().Trim().ToLower().Equals(cboType.SelectedValue.ToString().Trim().ToLower())
                                select oUser;
                }

                if (txtName.Text.Length != 0)
                {
                    oUserList = from oUser in oUserList
                                where oUser.Name.Trim().ToLower().Contains(txtName.Text.ToString().Trim().ToLower())
                                select oUser;
                }

                if (txtUserID.Text.Length != 0)
                {
                    oUserList = from oUser in oUserList
                                where oUser.UserId.Trim().ToLower().StartsWith(txtUserID.Text.ToString().Trim().ToLower())
                                select oUser;
 
                }


                dtgUsers.ItemsSource = oUserList;
                dtgUsers.Items.Refresh();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not update datagrid");
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void txtUserID_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDataGrid();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cboType.SelectedIndex = -1;
                txtUserID.Text = "";
                txtName.Text = "";
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not clear filters");
            }
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User oUser= new User();

                ucAddEditUser oucAddEditUser = new ucAddEditUser(oUser, false);

                winDialog oDialog = new winDialog(oucAddEditUser)
                {
                    ShowInTaskbar = true,
                    WindowTitle = "Add a new User",
                    Height = 300,
                    Width = 390
                };
                oDialog.ShowDialog();

                dtgUsers.Items.Refresh();
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not add user now");
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtgUsers.SelectedItem != null)
                {
                    User oUser = (User)dtgUsers.SelectedItem;

                    ucAddEditUser oucAddEditUser = new ucAddEditUser(oUser, true);

                    winDialog oDialog = new winDialog(oucAddEditUser)
                    {
                        ShowInTaskbar = true,
                        WindowTitle = "Edit User",
                        Height = 300,
                        Width = 390
                    };
                    oDialog.ShowDialog();

                    dtgUsers.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a user from list");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Can not edit user now");
            }
        }
    }
}
