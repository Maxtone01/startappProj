using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StartappProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private string myStringProperty;
        private int rate;
        public string MyStringProperty
        {
            get => myStringProperty;
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty));
            }
        }

        public int Rate
        {
            get => rate;
            set
            {
                rate = value;
                OnPropertyChanged(nameof(Rate));
            }
        }
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = this;
            MyStringProperty = "Меня зовут Кира Йошикаге. Мне 33 года. Мой дом находится в северо-восточной части Морио, где расположены все виллы";
            Rate = 1488;
        }

        public void EditorTextChanged(object sender, TextChangedEventArgs e)
        {
            _ = e.OldTextValue;
            string newText = e.NewTextValue;
            Console.WriteLine(newText);
        }
    }
}