﻿namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class silova3 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Grid LayoutRoot;
        internal MediaElement media;
        internal silova3 Window;

        public silova3()
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
                Uri resourceLocator = new Uri("/Mayreni;component/silova3.xaml", UriKind.Relative);
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

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (silova3) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                case 3:
                    ((Button) target).Click += new RoutedEventHandler(this.stop);
                    break;

                case 4:
                    ((Button) target).Click += new RoutedEventHandler(this.play);
                    break;

                case 5:
                    ((Button) target).Click += new RoutedEventHandler(this.pause);
                    break;

                case 6:
                    this.media = (MediaElement) target;
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

