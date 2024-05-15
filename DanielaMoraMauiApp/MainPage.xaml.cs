namespace DanielaMoraMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();// Siempre realiza la inicializacion/ es decir la interpretacion de cs de la pagina
        }

        private void OnCounterClicked(object sender, EventArgs e) //eveut handler que es lo quiero que haga cuando se lanza un evento. 
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
