﻿namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class yeghishe6 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal MediaElement media;
        internal TextBlock txt3;
        internal yeghishe6 Window;

        public yeghishe6()
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
                Uri resourceLocator = new Uri("/Mayreni;component/yeghishe6.xaml", UriKind.Relative);
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
                    this.Window = (yeghishe6) target;
                    break;

                case 2:
                    this.txt3 = (TextBlock) target;
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

