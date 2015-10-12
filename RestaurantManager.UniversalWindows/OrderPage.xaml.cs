﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RestaurantManager.Models;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var menuItems = MenuItemsListView.SelectedItems;
            var selectedMenuItems = ((DataManager)OrderGrid.DataContext).CurrentlySelectedMenuItems;

            foreach (string item in menuItems) { selectedMenuItems.Add(item); };
        }

        private void SubmitOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var dataManager = (DataManager)OrderGrid.DataContext;
            var selectedMenuItems = dataManager.CurrentlySelectedMenuItems;
            var orderItems = dataManager.OrderItems;
            
            orderItems.Add(string.Join(", ", selectedMenuItems));
            selectedMenuItems.Clear();
        }
    }
}