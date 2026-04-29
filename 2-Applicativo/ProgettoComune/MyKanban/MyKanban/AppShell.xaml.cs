namespace MyKanban;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    // Chiamato quando si clicca il bottone ☰
    // Apre il pannello laterale (Flyout) se configurato,
    // oppure puoi navigare verso un'altra pagina
    private void OnMenuClicked(object sender, EventArgs e)
    {
        // Opzione 1: apri il Flyout laterale
        Shell.Current.FlyoutIsPresented = true;

        // Opzione 2: naviga a una pagina menu (decommentare se preferisci)
        // await Shell.Current.GoToAsync("//MenuPage");
    }
}