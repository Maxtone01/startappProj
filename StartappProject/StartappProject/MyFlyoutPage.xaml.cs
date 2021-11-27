using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StartappProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPage : FlyoutPage
    {
        public MyFlyoutPage()
        {
            InitializeComponent();
            FlyoutPage.listView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MyFlyoutPageFlyoutMenuItem;

            var pageType = Type.GetType($"StartappProject.{item.Title}");
            if (item != null)
            {
                var page = (Page)Activator.CreateInstance(pageType);
                page.Title = item.Title;
                Detail = new NavigationPage(page);
                IsPresented = false;
            }
            //var page = (Page)Activator.CreateInstance(pageType);
            //page.Title = item.Title;
            //Detail = new NavigationPage(page);
            //IsPresented = false;
            //FlyoutPage.listView.SelectedItem = null;
        }
    }
}