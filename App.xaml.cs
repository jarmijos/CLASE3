using Microsoft.Extensions.DependencyInjection;

namespace CLASE3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());
            return new Views.Login();
        }
    }
}