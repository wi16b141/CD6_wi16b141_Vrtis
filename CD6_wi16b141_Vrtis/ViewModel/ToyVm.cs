using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CD6_wi16b141_Vrtis.ViewModel
{
    public class ToyVm : ViewModelBase
    {
        public string Description { get; set; }
        public BitmapImage Image { get; set; }

        private ObservableCollection<ItemVm> items = new ObservableCollection<ItemVm>();

        public ObservableCollection<ItemVm> Items
        {
            get { return items; }
            set { items = value; }
        }

        public ToyVm() { }
        public ToyVm(string description, BitmapImage image, ObservableCollection<ItemVm> items)
        {
            Description = description;
            Image = image;
            Items = items;
        }
    }
}