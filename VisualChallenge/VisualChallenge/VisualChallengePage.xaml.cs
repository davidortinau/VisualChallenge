using System;
using VisualChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        public VisualChallengePage()
        {
            InitializeComponent();
            this.BindingContext = new VisualChallengePageViewModel();
        }
    }
}