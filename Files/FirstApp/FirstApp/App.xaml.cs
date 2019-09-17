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
            AppCenter.Start("ios=2a79b618-b530-41cf-85ba-36039ca9f7fa;android=eb6d0243-961a-4b21-9354-3b0f98d5642e", typeof(Analytics), typeof(Crashes));
            try {
                Crashes.GenerateTestCrash();
            }
            catch (Exception exception) {
                bool result = await MainPage.DisplayAlert("ОШИБКА", "Приносим свои извинения. " +
                    "Хотите ли вы отправить статистику для улучшения приложения?", "YES", "NO");
                if (result)
                {
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
