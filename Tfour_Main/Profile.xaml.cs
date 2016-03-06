﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tfour_Main
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {

        DatabaseDataContext db = new DatabaseDataContext(Properties.Settings.Default.TfourConnectionString);

        String userID;

        public Profile(String id)
        {
            InitializeComponent();
            userID = id;
            displayPlayerInformation(userID);

        }


        private void displayPlayerInformation(String id)
        {
            var query = from s in db.PlayerInformations
                        where (s.UserID.Equals(id))
                        select s;

            DataGrid_ProfileInformation.ItemsSource = query.ToList();

        }

        private void Button_Profile_Back_Click(object sender, RoutedEventArgs e)
        {
            Login loginForm = new Login(this);
            loginForm.Visibility = System.Windows.Visibility.Visible;
            this.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
