using Plugin.Connectivity;
using Xamarin.Forms;

namespace NetStatus
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            if (CrossConnectivity.Current.IsConnected)
                MainPage = new NetStatus.MainPage();
            else
                MainPage = new NetStatus.Page1();
		}

        

		protected override void OnStart ()
		{
            // Handle when your app starts
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
		}

        private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            if (e.IsConnected)
                MainPage = new NetStatus.MainPage();
            else
                MainPage = new NetStatus.Page1();
        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
