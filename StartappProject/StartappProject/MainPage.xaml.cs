using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StartappProject
{
    public partial class MainPage : ContentPage
    {
        bool isGettingLocation;
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            isGettingLocation = true;

            while (isGettingLocation)
            {
                Location result = await Geolocation.GetLocationAsync(new
                GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromSeconds(60)));

                resultLocation.Text += $"Широта: {result.Latitude}, Долгота: {result.Longitude}, " +
                    $"Время получения:{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} {Environment.NewLine}";
            }

        }

        public void Button1_Clicked(object sender, EventArgs e)
        {
            isGettingLocation = false;
        }
    }
    //    {
    //        if (button1.Text == "Pressed!!!")
    //        {
    //            button1.Text = "Default";
    //            button1.BackgroundColor = Color.Green;
    //        }
    //        else 
    //        { 
    //            button1.Text = "Pressed!!!";
    //            button1.BackgroundColor = Color.Red;
    //        }
    //    }
    //}
    //public partial class ARGBColor : IMarkupExtension
    //{
    //    public int Alpha { get; set; }
    //    public int Red { get; set; }
    //    public int Green { get; set; }
    //    public int Blue { get; set; }

    //    public object ProvideValue(IServiceProvider serviceProvider)
    //    {
    //        return Color.FromRgba(Red, Green, Blue, Alpha);
    //    }
    //}
}
