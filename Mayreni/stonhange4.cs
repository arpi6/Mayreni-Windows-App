namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class stonhange4 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Grid LayoutRoot;
        internal Button pic1;
        internal Button pic2;
        internal Button pic3;
        internal Button pic4;
        internal Button pic5;
        internal Button pic6;
        internal stonhange4 Window;

        public stonhange4()
        {
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/stonhange4.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void pic1_Click(object sender, RoutedEventArgs e)
        {
            new Mayreni.pic1().Show();
        }

        private void pic2_Click(object sender, RoutedEventArgs e)
        {
            new Mayreni.pic2().Show();
        }

        private void pic3_Click(object sender, RoutedEventArgs e)
        {
            new Mayreni.pic3().Show();
        }

        private void pic4_Click(object sender, RoutedEventArgs e)
        {
            new Mayreni.pic4().Show();
        }

        private void pic5_Click(object sender, RoutedEventArgs e)
        {
            new Mayreni.pic5().Show();
        }

        private void pic6_Click(object sender, RoutedEventArgs e)
        {
            new Mayreni.pic6().Show();
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (stonhange4) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.pic1 = (Button) target;
                    this.pic1.Click += new RoutedEventHandler(this.pic1_Click);
                    break;

                case 4:
                    this.pic2 = (Button) target;
                    this.pic2.Click += new RoutedEventHandler(this.pic2_Click);
                    break;

                case 5:
                    this.pic3 = (Button) target;
                    this.pic3.Click += new RoutedEventHandler(this.pic3_Click);
                    break;

                case 6:
                    this.pic4 = (Button) target;
                    this.pic4.Click += new RoutedEventHandler(this.pic4_Click);
                    break;

                case 7:
                    this.pic5 = (Button) target;
                    this.pic5.Click += new RoutedEventHandler(this.pic5_Click);
                    break;

                case 8:
                    this.pic6 = (Button) target;
                    this.pic6.Click += new RoutedEventHandler(this.pic6_Click);
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

