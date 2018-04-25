using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestXFMac
{
    public partial class HelloXamlPage : ContentPage
    {
        void OnSliderChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            valueLabel.Text = e.NewValue.ToString("F3");
        }

        async void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked", "You have clicked " + button.Text, "OK" );
           
        }

        public HelloXamlPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
