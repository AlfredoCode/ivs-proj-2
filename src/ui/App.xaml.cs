namespace calculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 349;
            const int newHeight = 508;

            window.Width = newWidth;
            window.Height = newHeight;

            window.MinimumHeight = 450;
            window.MaximumHeight = 1080;

            window.MinimumWidth = 300;
            window.MaximumWidth = 1920;

            return window;
        }
    }
}
