using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BrtaModel;

namespace Brta
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Grid grdMain ;
        
        public static Menu menus;
        public static Grid grdLeft;
        public static Window mainWindow;

        /////////for demo only remove after database is done//////////////

        public static List<PartsDetail> oAllPartDetailList;
        public static List<RepairsHistory> oAllRepairsHistory;
        public static List<User> oAllUser;
        public static List<CarModel> oAllCarModel;
        public static List<Car> oAllCarList;
        public static List<Group> oAllGroupList;
        public static List<Category> oAllCategory;
        public static List<Manufacturer> oAllManufacturer;
        public static User currentUser;
        
       
    }
}
