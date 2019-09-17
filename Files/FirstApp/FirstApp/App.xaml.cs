using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FirstApp.Services;
using FirstApp.Views;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace FirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override async void OnStart()
        {
            AppCenter.Start("ios=a2a1f432-3b12-412c-bbc7-6dc83b1dfc85;android=5f720092-a3ea-45c3-a45c-4d89c9355bd6", typeof(Analytics), typeof(Crashes));
            try
            {
                Crashes.GenerateTestCrash();
            }
            catch (Exception exception)
            {
                bool result = await MainPage.DisplayAlert("ОШИБКА", "Приносим свои извинения. Хотите ли вы отправить статистику для улучшения приложения?", "YES", "NO");
                if (result) {
                    Crashes.TrackError(exception);
                    await MainPage.DisplayAlert("Отправка", "Ошибка была отправлена", "OK");
                }
            }

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
