using MyKanban.Models;

namespace MyKanban
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntNameAccount.Text) ||
                string.IsNullOrEmpty(EntPasswordAccount.Text))
            {
                await DisplayAlert("Errore", "Nome account o Password non inserito", "Ok");
            }

            try
            { 
                Account account = new Account
                {
                    Username = EntNameAccount.Text,
                    Password = EntPasswordAccount.Text,
                };

                string filePath = $"{Path.Combine(FileSystem.AppDataDirectory, EntNameAccount.Text)}.txt";
                File.AppendAllText(filePath, $"{account.ToRiga()}{Environment.NewLine}");
            }
            catch (Exception)
            {
                await DisplayAlert("Errore", "Compilari i campi con i valori corretti", "Ok");
            }
        }
    }

}
