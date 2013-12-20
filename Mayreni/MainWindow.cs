namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class MainWindow : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button button;
        internal Button button1;
        internal Button button2;
        internal Button button3;
        internal Grid LayoutRoot;
        internal MediaElement media;
        internal TextBlock textBlock;
        internal TextBlock textBlock1;
        internal TextBlock textBlock2_Copy;
        internal TextBlock textBlock2_Copy1;
        internal TextBlock textBlock2_Copy2;
        internal TextBlock textBlock2_Copy3;
        internal TextBlock textBlock2_Copy5;
        internal TextBlock textBlock2_Copy6;
        internal MainWindow Window;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new writer().Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new writer2().Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            new stonhange().Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            new stonhange2().Show();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/mainwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (MainWindow) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.media = (MediaElement) target;
                    break;

                case 4:
                    this.textBlock = (TextBlock) target;
                    break;

                case 5:
                    this.textBlock1 = (TextBlock) target;
                    break;

                case 6:
                    this.textBlock2_Copy = (TextBlock) target;
                    break;

                case 7:
                    this.textBlock2_Copy1 = (TextBlock) target;
                    break;

                case 8:
                    this.textBlock2_Copy2 = (TextBlock) target;
                    break;

                case 9:
                    this.textBlock2_Copy5 = (TextBlock) target;
                    break;

                case 10:
                    this.textBlock2_Copy6 = (TextBlock) target;
                    break;

                case 11:
                    this.button = (Button) target;
                    this.button.Click += new RoutedEventHandler(this.button_Click);
                    break;

                case 12:
                    this.button1 = (Button) target;
                    this.button1.Click += new RoutedEventHandler(this.button1_Click);
                    break;

                case 13:
                    this.button2 = (Button) target;
                    this.button2.Click += new RoutedEventHandler(this.button2_Click);
                    break;

                case 14:
                    this.button3 = (Button) target;
                    this.button3.Click += new RoutedEventHandler(this.button3_Click);
                    break;

                case 15:
                    this.textBlock2_Copy3 = (TextBlock) target;
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

