namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class shiraz8 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal MediaElement media;
        internal TextBlock shiraz4;
        internal shiraz8 Window;

        public shiraz8()
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
                Uri resourceLocator = new Uri("/Mayreni;component/shiraz8.xaml", UriKind.Relative);
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

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (shiraz8) target;
                    break;

                case 2:
                    this.shiraz4 = (TextBlock) target;
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

