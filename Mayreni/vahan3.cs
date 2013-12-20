namespace Mayreni
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class vahan3 : System.Windows.Window, IComponentConnector
    {
        private bool _contentLoaded;
        internal Grid LayoutRoot;
        internal vahan3 Window;

        public vahan3()
        {
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this._contentLoaded)
            {
                this._contentLoaded = true;
                Uri resourceLocator = new Uri("/Mayreni;component/vahan3.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Window = (vahan3) target;
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

