using System;
using Xamarin.Forms;

namespace MyApp
{
    public partial class DropdownPage : ContentPage
    {
        public DropdownPage()
        {
            InitializeComponent();
            ValueSlider.ValueChanged += OnSliderValueChanged;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueLabel.Text = $"Значение: {e.NewValue:F0}";
        }

        void OnShowValueClicked(object sender, EventArgs e)
        {
            string selectedOption = OptionPicker.SelectedItem?.ToString() ?? "Ничего не выбрано";
            double sliderValue = ValueSlider.Value;

            string info = $"Выбрано: {selectedOption}\n" +
                         $"Значение слайдера: {sliderValue:F0}\n" +
                         $"Максимальное значение: {ValueSlider.Maximum}";

            InfoLabel.Text = info;
        }

        async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
