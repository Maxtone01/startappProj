using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using StartappProject.Models;
using Xamarin.Forms;

namespace StartappProject.ViewModels
{
    public class ChatPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Message> Messages
        { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }

        public ChatPageViewModel()
        {
            Messages.Add(new Message() { Text = "Hi" });
            Messages.Add(new Message() { Text = "This is a test message" });

            OnSendCommand = new Command(() =>
            {
                if (!string.IsNullOrEmpty(TextToSend))
                {
                    Messages.Add(new Message() { Text = TextToSend, User = ChatPage.User });
                    TextToSend = string.Empty;
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
