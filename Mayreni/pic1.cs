﻿namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class pic1 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Grid LayoutRoot;
        internal pic1 Window;

        public pic1()
        {
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/pic1.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (pic1) target;
                    break;

                case 2:
                    this.LayoutRoot = (Grid) target;
                    break;

                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

