using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SqliteExp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lstPeople.ItemsSource = await App.Database.GetPeopleAsync();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(edtName.Text))
            {
                await App.Database.SavePersonAsync(new Person { Name = edtName.Text, Subscribe = chbSubscribe.IsChecked });
                edtName.Text = String.Empty; chbSubscribe.IsChecked = false;
                lstPeople.ItemsSource = await App.Database.GetPeopleAsync();
            }

        }
    }
}
