using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Forms;

namespace FitnessTrackerApp
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private readonly string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(this.fileName))
            {
                editor.Text = File.ReadAllText(this.fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(this.fileName, editor.Text);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(this.fileName))
            {
                File.Delete(this.fileName);
            }

            editor.Text = string.Empty;
        }
    }
}
