using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {
        private ObservableCollection<ChatMessage> _Chats;

        public VisualChallengePage()
        {
            InitializeComponent();

            _Chats = new ObservableCollection<ChatMessage>();
            _Chats.Add(new ChatMessage { ProfileIcon = "pippo", ProfileName = "Pippo", Date = "2:04 PM", Message = "Hi dude!", Tag = "# culture" });
            _Chats.Add(new ChatMessage { ProfileIcon = "pippa", ProfileName = "Pippa", Date = "2:06 PM", Message = "Hello to you", Tag = "# culture", Attachment = _Chats[0] });

            lstChat.ItemsSource = _Chats;
            pick.ItemsSource = _Chats;
            pick.SelectedIndex = 0;
        }

        
    }
}