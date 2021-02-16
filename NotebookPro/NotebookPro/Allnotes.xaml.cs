using NotebookPro.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotebookPro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Allnotes : ContentPage
    {
        public Allnotes()
        {
            InitializeComponent();

            List<Person> people = new List<Person>
            {
                new Person("Diana is the Co-Founder of Universe LLC. A company that is bent on delivering Technology to everyone accross the globe", new DateTime(1975, 1, 15), Color.Aqua),
                new Person("Bob", new DateTime(1976, 2, 20), Color.Black),
                new Person("Cathy", new DateTime(1977, 3, 10), Color.Blue),
                new Person("David", new DateTime(1978, 4, 25), Color.Fuchsia),
                new Person("Eugenie", new DateTime(1979, 5, 5), Color.Gray),
                new Person("Freddie", new DateTime(1980, 6, 30), Color.Green),
                new Person("Greta", new DateTime(1981, 7, 15), Color.Lime),
                new Person("Harold", new DateTime(1982, 8, 10), Color.Maroon),
                new Person("Irene", new DateTime(1983, 9, 25), Color.Navy),
                new Person("Jonathan", new DateTime(1984, 10, 10), Color.Olive),
                new Person("Kathy", new DateTime(1985, 11, 20), Color.Purple),
                new Person("Larry", new DateTime(1986, 12, 5), Color.Red),
                new Person("Monica", new DateTime(1975, 1, 5), Color.Silver),
                new Person("Nick", new DateTime(1976, 2, 10), Color.Teal),
                new Person("Olive", new DateTime(1977, 3, 20), Color.White),
                new Person("Pendleton", new DateTime(1978, 4, 10), Color.Yellow),
                new Person("Queenie", new DateTime(1979, 5, 15), Color.Aqua),
                new Person("Rob", new DateTime(1980, 6, 30), Color.Blue),
                new Person("Sally", new DateTime(1981, 7, 5), Color.Fuchsia),
                new Person("Timothy", new DateTime(1982, 8, 30), Color.Green),
                new Person("Uma", new DateTime(1983, 9, 10), Color.Lime),
                new Person("Victor", new DateTime(1984, 10, 20), Color.Maroon),
                new Person("Wendy", new DateTime(1985, 11, 5), Color.Navy),
                new Person("Xavier", new DateTime(1986, 12, 30), Color.Olive),
                new Person("Yvonne", new DateTime(1987, 1, 10), Color.Purple),
                new Person("Zachary", new DateTime(1988, 2, 5), Color.Red)
            };

            NotesList.ItemsSource = people;
        }

        private void btn_create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void search_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new searchPage());
        }

        private void menu_Clicked(object sender, EventArgs e)
        {

        }
    }
}