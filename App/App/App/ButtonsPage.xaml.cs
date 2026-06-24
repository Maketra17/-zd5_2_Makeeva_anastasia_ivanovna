using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
    public partial class ButtonsPage : ContentPage
    {
        public ButtonsPage(string username, bool remember)
        {
            InitializeComponent();
            WelcomeLabel.Text = $"Привет, {username}!";
            InfoLabel.Text = $"Запомнить: {(remember ? "Да" : "Нет")}";
        }

        async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnNextClicked(object sender, EventArgs e)
        {
            var dropdownPage = new DropdownPage();
            await Navigation.PushAsync(dropdownPage);
        }
    }
}