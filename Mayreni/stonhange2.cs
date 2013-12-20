namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class stonhange2 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button button;
        internal Button button1;
        internal Grid LayoutRoot;
        internal TextBlock textBlock;
        internal stonhange2 Window;

        public stonhange2()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new stonhange4().Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new stonhange5().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/stonhange2.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (stonhange2) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.textBlock = (TextBlock) target;
                    break;

                case 4:
                    this.button1 = (Button) target;
                    this.button1.Click += new RoutedEventHandler(this.button1_Click);
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

