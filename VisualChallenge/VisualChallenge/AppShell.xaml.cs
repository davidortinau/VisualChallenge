using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);

            // Cancel all navigation for demo purposes
            if (CurrentItem != null)
                args.Cancel();
        }
    }
}
