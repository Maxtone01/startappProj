using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StartappProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageDetail : ContentPage
    {
        //bool isGettingLocation;
        public MyFlyoutPageDetail()
        {
            InitializeComponent();
        }
        //async void Button_Clicked(object sender, EventArgs e)
        //{
        //    isGettingLocation = true;

        //    while (isGettingLocation)
        //    {
        //        Location result = await Geolocation.GetLocationAsync(new
        //        GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromSeconds(60)));

        //        resultLocation.Text += $"Широта: {result.Latitude}, Долгота: {result.Longitude}, " +
        //            $"Время получения:{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} {Environment.NewLine}";
        //    }

        //}

        //public void Button1_Clicked(object sender, EventArgs e)
        //{
        //    isGettingLocation = false;
        //}
    }

}