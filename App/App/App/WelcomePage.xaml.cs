using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async void OnSignInClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameEntry.Text))
            {
                ErrorLabel.Text = "Введите имя пользователя!";
                ErrorLabel.IsVisible = true;
                return;
            }

            if (string.IsNullOrEmpty(PasswordEntry.Text))
            {
                ErrorLabel.Text = "Введите пароль!";
                ErrorLabel.IsVisible = true;
                return;
            }

            ErrorLabel.IsVisible = false;
            string username = UsernameEntry.Text;
            bool isRemembered = RememberCheck.IsChecked;

            var buttonsPage = new ButtonsPage(username, isRemembered);
            await Navigation.PushAsync(buttonsPage);
        }

        async void OnForgotTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Напоминание", "Пожалуйста, свяжитесь с администратором для восстановления пароля.", "OK");
        }
    }
}