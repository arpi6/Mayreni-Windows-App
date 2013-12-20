namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class silva : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button Button5;
        internal Button Button7;
        internal Image image3_Copy;
        internal Grid LayoutRoot;
        internal TextBlock textBlock;
        internal silva Window;

        public silva()
        {
            this.InitializeComponent();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            new silova3().Show();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            new silva4().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/silva.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (silva) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.textBlock = (TextBlock) target;
                    break;

                case 4:
                    this.image3_Copy = (Image) target;
                    break;

                case 5:
                    this.Button7 = (Button) target;
                    this.Button7.Click += new RoutedEventHandler(this.Button7_Click);
                    break;

                case 6:
                    this.Button5 = (Button) target;
                    this.Button5.Click += new RoutedEventHandler(this.Button5_Click);
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

