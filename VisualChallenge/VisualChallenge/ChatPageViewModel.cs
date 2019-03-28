using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace VisualChallenge
{
    public class ChatPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }

        public ChatPageViewModel()
        {
            Messages.Add(new Message() { Text = "Hi" });
            Messages.Add(new Message() { Text = "How are you?" });

            OnSendCommand = new Command(() =>
            {
                if (!string.IsNullOrEmpty(TextToSend))
                {
                    Messages.Add(new Message() { Text = TextToSend, User = App.User });
                    TextToSend = string.Empty;
                }

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}