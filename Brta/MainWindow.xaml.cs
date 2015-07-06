using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Brta.UserControls;
using BrtaModel;


namespace Brta
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

            App.oAllPartDetailList = new PartsDetail().SelectAll();
            App.oAllRepairsHistory = new RepairsHistory().SelectAll();
            App.oAllUser = new User().SelectAll();
            App.oAllCarModel = new CarModel().SelectAll();
            App.oAllCarList = new Car().SelectAll();
            App.oAllGroupList = new Group().SelectAll();
            App.oAllCategory = new Category().SelectAll();
            App.oAllManufacturer = new Manufacturer().SelectAll();

            App.grdMain = mainGrid;
            App.grdLeft = grdLeftButton;
            App.menus = this.menus;
            App.mainWindow = this;
            ucLogin oucLogin = new ucLogin();
            mainGrid.Children.Clear();
            mainGrid.Children.Add(oucLogin);
    
            ToogleButton(btnTools);

            
        }

        private void ToogleButton(Button oCurrentButton)
        {
            try
            {
                foreach (var oChildren in stpButtonHolder.Children)
                {
                    Button oButton = (Button)oChildren;

                    if (oButton == oCurrentButton)
                    {
                        oButton.IsEnabled = false; ;
                    }

                    else oButton.IsEnabled = true;

                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not toogle Button visibility");
            }

        }

        private void btnTools_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnTools);
                ucToolsPreview oucToolsPreview = new ucToolsPreview();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucToolsPreview);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not load all tools data");
            }
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnHistory);
                ucRepairsHistory oucRepairsHistory = new ucRepairsHistory();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucRepairsHistory);
            }
            catch (Exception)
            {
                MessageBox.Show("Can not load repairs history.");
            }
        }

        private void btnEmergency_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnEmergency);
                ucEmergency oucEmergency = new ucEmergency();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucEmergency);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not load emergency status.");
            }
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnUser);
                ucUsers oucUsers = new ucUsers();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucUsers);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Can not load Users");
            }
        }

        private void btnCarModel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnCarModel);
                ucCarModel oucCarModel= new ucCarModel();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucCarModel);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not load Car models");
            }
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnCars);
                ucCars oucCars = new ucCars();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucCars);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not load Car models");
            }
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnCategory);
                ucCategories oucCategories = new ucCategories();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucCategories);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not load Categories");
            }
        }

        private void btnManufacturer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToogleButton(btnManufacturer);
                ucManufacturer oucManufacturer = new ucManufacturer();
                mainGrid.Children.Clear();
                mainGrid.Children.Add(oucManufacturer);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not load manufacturer");
            }
        }


    }
}
