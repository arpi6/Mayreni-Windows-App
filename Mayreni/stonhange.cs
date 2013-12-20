namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class stonhange : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button btn1;
        internal Button button;
        internal Grid LayoutRoot;
        internal TextBlock textBlock;
        internal stonhange Window;

        public stonhange()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            new stonhange3().Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new stonhange4().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/stonhange.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (stonhange) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.textBlock = (TextBlock) target;
                    break;

                case 4:
                    this.btn1 = (Button) target;
                    this.btn1.Click += new RoutedEventHandler(this.btn1_Click);
                    break;

                case 5:
                    this.button = (Button) target;
                    this.button.Click += new RoutedEventHandler(this.button_Click);
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

