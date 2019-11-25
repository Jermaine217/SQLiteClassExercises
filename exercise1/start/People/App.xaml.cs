using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace People
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("people.db3");

        public static object PersonRepo { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new People.MainPage();
            
        }
        public static PersonRepo()
        {



        }


        protected override void OnStart()
        {
            // Handle when your app starts
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
