namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class silva4 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button btn1;
        internal Button btn3;
        internal Button btn4;
        internal Button Button7_Copy;
        internal Grid LayoutRoot;
        internal silva4 Window;

        public silva4()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            new silva5().Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            new silva7().Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            new silva8().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/silva4.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (silva4) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.btn1 = (Button) target;
                    this.btn1.Click += new RoutedEventHandler(this.btn1_Click);
                    break;

                case 4:
                    this.btn3 = (Button) target;
                    this.btn3.Click += new RoutedEventHandler(this.btn3_Click);
                    break;

                case 5:
                    this.btn4 = (Button) target;
                    this.btn4.Click += new RoutedEventHandler(this.btn4_Click);
                    break;

                case 6:
                    this.Button7_Copy = (Button) target;
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

