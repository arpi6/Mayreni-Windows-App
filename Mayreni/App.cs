namespace Mayreni
{
    using System;
    using System.Diagnostics;
    using System.Windows;

    public class App : Application
    {
        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            base.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
        }

        [STAThread, DebuggerNonUserCode]
        public static void Main()
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

