using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace CD6_wi16b141_Vrtis.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;

        public RelayCommand BtnOverviewClicked { get; set; }
        public RelayCommand BtnMyToysClicked { get; set; }
        public ViewModelBase CurrentVm
        {
            get { return currentVm; }
            set { currentVm = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            CurrentVm = SimpleIoc.Default.GetInstance<OverviewVm>();
            BtnOverviewClicked = new RelayCommand(() =>
            {
                CurrentVm = SimpleIoc.Default.GetInstance<OverviewVm>();
            });
            BtnMyToysClicked = new RelayCommand(() =>
            {
                CurrentVm = SimpleIoc.Default.GetInstance<MyToyVm>();
            });
        }
    }
}