namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class yeghishe4 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button btn1;
        internal Button btn2;
        internal Button btn3;
        internal Button btn4;
        internal Button Button7;
        internal Grid LayoutRoot;
        internal yeghishe4 Window;

        public yeghishe4()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            new yeghishe5().Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            new yeghishe6().Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            new yeghishe8().Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            new yeghishe7().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/yeghishe4.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (yeghishe4) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.Button7 = (Button) target;
                    break;

                case 4:
                    this.btn1 = (Button) target;
                    this.btn1.Click += new RoutedEventHandler(this.btn1_Click);
                    break;

                case 5:
                    this.btn2 = (Button) target;
                    this.btn2.Click += new RoutedEventHandler(this.btn2_Click);
                    break;

                case 6:
                    this.btn3 = (Button) target;
                    this.btn3.Click += new RoutedEventHandler(this.btn3_Click);
                    break;

                case 7:
                    this.btn4 = (Button) target;
                    this.btn4.Click += new RoutedEventHandler(this.btn4_Click);
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

