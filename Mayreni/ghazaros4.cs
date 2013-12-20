namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class ghazaros4 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button btn2;
        internal Button btn3;
        internal Button Button7;
        internal Grid LayoutRoot;
        internal ghazaros4 Window;

        public ghazaros4()
        {
            this.InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            new ghazaros6().Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            new ghazaros7().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/ghazaros4.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (ghazaros4) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.Button7 = (Button) target;
                    break;

                case 4:
                    this.btn2 = (Button) target;
                    this.btn2.Click += new RoutedEventHandler(this.btn2_Click);
                    break;

                case 5:
                    this.btn3 = (Button) target;
                    this.btn3.Click += new RoutedEventHandler(this.btn3_Click);
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

