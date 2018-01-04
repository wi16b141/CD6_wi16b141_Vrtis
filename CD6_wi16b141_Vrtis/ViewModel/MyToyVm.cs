using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD6_wi16b141_Vrtis.ViewModel
{
    public class MyToyVm : ViewModelBase
    {
        public ObservableCollection<ItemVm> ShoppingCart { get; set; }
        private Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();


        public MyToyVm()
        {
            ShoppingCart = new ObservableCollection<ItemVm>();
            messenger.Register<NotificationMessage<ItemVm>>(this, update);
        }

        private void update(NotificationMessage<ItemVm> obj)
        {
            ShoppingCart.Add(obj.Content);
        }
    }
}
