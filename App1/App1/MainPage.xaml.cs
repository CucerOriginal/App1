using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Acr.UserDialogs;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (label2.IsVisible == false) label2.IsVisible = true;
            else label2.IsVisible = false;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (label1.TextColor == Color.Red) label1.TextColor = Color.Blue;
            else label1.TextColor = Color.Red;
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.Toast("Приветики я снизу");
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.Confirm(new ConfirmConfig
            {
                Message = "Вы Светлана",
                OkText = "Конечно",
                CancelText = "Нет",
                Title = "Внимание?",
                OnAction = (confirmed) => { if (confirmed) UserDialogs.Instance.Alert("Прекрасный атвет"); else { Environment.Exit(0); }  }
                
            });
            
        }

        private async void button5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
