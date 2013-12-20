namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class vahan2 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Button btn1_Copy;
        internal Button btn2_Copy;
        internal Button btns;
        internal Grid LayoutRoot;
        internal MediaElement media;
        internal vahan2 Window;

        public vahan2()
        {
            this.InitializeComponent();
            this.media.LoadedBehavior = MediaState.Manual;
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/vahan2.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void pause(object sender, RoutedEventArgs e)
        {
            this.media.Pause();
        }

        private void play(object sender, RoutedEventArgs e)
        {
            this.media.Play();
        }

        private void stop(object sender, RoutedEventArgs e)
        {
            this.media.Stop();
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (vahan2) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    this.btn1_Copy = (Button) target;
                    this.btn1_Copy.Click += new RoutedEventHandler(this.play);
                    break;

                case 4:
                    this.btn2_Copy = (Button) target;
                    this.btn2_Copy.Click += new RoutedEventHandler(this.pause);
                    break;

                case 5:
                    this.media = (MediaElement) target;
                    break;

                case 6:
                    this.btns = (Button) target;
                    this.btns.Click += new RoutedEventHandler(this.stop);
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

