namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class toomanyan7 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal MediaElement media;
        internal TextBlock toomanyan4;
        internal toomanyan7 Window;

        public toomanyan7()
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
                Uri resourceLocator = new Uri("/Mayreni;component/toomanyan7.xaml", UriKind.Relative);
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
                    this.Window = (toomanyan7) target;
                    break;

                case 2:
                    this.toomanyan4 = (TextBlock) target;
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

