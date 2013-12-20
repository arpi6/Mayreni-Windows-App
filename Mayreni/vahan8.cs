namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class vahan8 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal MediaElement media;
        internal TextBlock txt6;
        internal vahan8 Window;

        public vahan8()
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
                Uri resourceLocator = new Uri("/Mayreni;component/vahan8.xaml", UriKind.Relative);
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

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (vahan8) target;
                    break;

                case 2:
                    this.txt6 = (TextBlock) target;
                    break;

                case 3:
                    ((Button) target).Click += new RoutedEventHandler(this.play);
                    break;

                case 4:
                    ((Button) target).Click += new RoutedEventHandler(this.pause);
                    break;

                case 5:
                    this.media = (MediaElement) target;
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

