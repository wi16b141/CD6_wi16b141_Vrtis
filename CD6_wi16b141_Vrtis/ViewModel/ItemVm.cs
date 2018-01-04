using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CD6_wi16b141_Vrtis.ViewModel
{
    public class ItemVm : ViewModelBase
    {
        public string Description { get; set; }
        public BitmapImage Image { get; set; }
        public string AgeRecom { get; set; }

        public ItemVm() { }
        public ItemVm(string description, BitmapImage image, string ageRecom)
        {
            Description = description;
            Image = image;
            AgeRecom = ageRecom;
        }
    }
}
