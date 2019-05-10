using FitnessTrackerApp.Database;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessTrackerApp
{
    public partial class App : Application
    {
        private static LiftDatabase liftDatabase;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static LiftDatabase LiftDatabase
        {
            get
            {
                if (liftDatabase == null)
                {
                    liftDatabase = new LiftDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LiftDatabase.db3"));
                }

                return liftDatabase;
            }
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
