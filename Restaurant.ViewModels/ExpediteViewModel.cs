using RestaurantManager.Models;
using System.Collections.Generic;

namespace RestaurantManager.ViewModels
{
    public class ExpediteViewModel : ViewModel
    {
        protected override void OnDataLoaded()
        {
            NotifyPropertyChanged("OrderItems");
        }

        public List<Order> OrderItems
        {
            get
            {
                if (Repository != null)
                {
                    return Repository.Orders;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
