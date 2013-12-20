namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class writer2 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button Button1;
        internal Button Button10;
        internal Button Button2;
        internal Button Button3;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
        internal Button Button8;
        internal Image image;
        internal Image image1;
        internal Image image2;
        internal Image image3;
        internal Image image4;
        internal Image image5;
        internal Grid LayoutRoot;
        internal TextBlock textBlock;
        internal writer2 Window;

        public writer2()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            new alexander4().Show();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            new zoryan2().Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            new kaputikyan2().Show();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            new ghazaros2().Show();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            new shiraz2().Show();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            new toomanyan2().Show();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            new yeghishe2().Show();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            new vahan3().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/writer2.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (writer2) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.textBlock = (TextBlock) target;
                    break;

                case 4:
                    this.Button2 = (Button) target;
                    this.Button2.Click += new RoutedEventHandler(this.Button2_Click);
                    break;

                case 5:
                    this.Button1 = (Button) target;
                    this.Button1.Click += new RoutedEventHandler(this.Button1_Click);
                    break;

                case 6:
                    this.Button3 = (Button) target;
                    this.Button3.Click += new RoutedEventHandler(this.Button3_Click);
                    break;

                case 7:
                    this.Button5 = (Button) target;
                    this.Button5.Click += new RoutedEventHandler(this.Button5_Click);
                    break;

                case 8:
                    this.Button6 = (Button) target;
                    this.Button6.Click += new RoutedEventHandler(this.Button6_Click);
                    break;

                case 9:
                    this.Button7 = (Button) target;
                    this.Button7.Click += new RoutedEventHandler(this.Button7_Click);
                    break;

                case 10:
                    this.Button8 = (Button) target;
                    this.Button8.Click += new RoutedEventHandler(this.Button8_Click);
                    break;

                case 11:
                    this.Button10 = (Button) target;
                    this.Button10.Click += new RoutedEventHandler(this.Button10_Click);
                    break;

                case 12:
                    this.image3 = (Image) target;
                    break;

                case 13:
                    this.image4 = (Image) target;
                    break;

                case 14:
                    this.image1 = (Image) target;
                    break;

                case 15:
                    this.image2 = (Image) target;
                    break;

                case 0x10:
                    this.image5 = (Image) target;
                    break;

                case 0x11:
                    this.image = (Image) target;
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

