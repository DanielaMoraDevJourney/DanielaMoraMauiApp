namespace DanielaMoraMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); //Realiza el proceso de transformacion a C#
            //Normalmente los errores surgen desde este metodo

            MainPage = new AppShell();
        }
    }
}
