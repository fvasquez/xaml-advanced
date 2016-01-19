using RestaurantManager.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RestaurantManager.ViewModels
{
    public class OrderViewModel : ViewModel
    {
        private List<MenuItem> _menuItems;
        private ObservableCollection<MenuItem> _selectedMenuItems;

        public OrderViewModel()
        {
            AddMenuItemCommand = new DelegateCommand(AddMenuItem);
            SubmitOrderCommand = new DelegateCommand(SubmitOrder);
            this.CurrentlySelectedMenuItems = new ObservableCollection<MenuItem>();
        }

        protected override void OnDataLoaded()
        {
            this.MenuItems = Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new ObservableCollection<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        public DelegateCommand AddMenuItemCommand { get; private set; }
        public DelegateCommand SubmitOrderCommand { get; private set; }

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;
                NotifyPropertyChanged("MenuItems");
            }
        }

        public ObservableCollection<MenuItem> CurrentlySelectedMenuItems
        {
            get { return _selectedMenuItems; }
            set
            {
                _selectedMenuItems = value;
                NotifyPropertyChanged("CurrentlySelectedMenuItems");
            }
        }

        private void AddMenuItem(MenuItem item)
        {
            CurrentlySelectedMenuItems.Add(item);
        }

        private void SubmitOrder(MenuItem ignore)
        {
            var order = new Order();
            var items = new List<MenuItem>();

            foreach (var item in CurrentlySelectedMenuItems) { items.Add(item); };

            order.Items = items;
            Repository.Orders.Add(order);
            CurrentlySelectedMenuItems.Clear();
        }
    }
}
