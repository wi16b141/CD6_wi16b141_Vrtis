using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System.Threading;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace CD6_wi16b141_Vrtis.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;
        private Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();
        DispatcherTimer timer = new DispatcherTimer();
        private string notification = "";
        private BitmapImage notificationImage;

        public BitmapImage NotificationImage
        {
            get { return notificationImage; }
            set { notificationImage = value; RaisePropertyChanged(); }
        }
        public string Notification
        {
            get { return notification; }
            set { notification = value; RaisePropertyChanged(); }
        }


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

            messenger.Register<NotificationMessage<ItemVm>>(this, updateGui);
        }

        private void updateGui(NotificationMessage<ItemVm> obj)
        {            
            Notification = "New Entry Added";
            NotificationImage = new BitmapImage(new Uri("../Images/State_Info.png", UriKind.Relative));
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += Hide;
            timer.Start();
        }
        private void Hide(object sender, EventArgs e)
        {
            Notification = "";
            NotificationImage = null;            
        }
    }
}