namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class toomanyan2 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Grid LayoutRoot;
        internal toomanyan2 Window;

        public toomanyan2()
        {
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/toomanyan2.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (toomanyan2) target;
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

