using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VisualChallenge
{
    public partial class ChatInputBarView : ContentView
    {
        public ChatInputBarView()
        {
            InitializeComponent();
        }

        public void Handle_Tapped(object sender, EventArgs e)
        {
            chatTextInput.Text = string.Empty;
        }
    }
}
