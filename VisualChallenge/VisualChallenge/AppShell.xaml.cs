using System;
using System.Collections.Generic;

using Xamarin.Forms;

[assembly: XmlnsDefinition("http://mycompany.com/schemas/controls", "MyCompany.Controls")]
namespace VisualChallenge
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
        }
    }
}
