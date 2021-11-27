using Xamarin.Forms;
using StartappProject.Views;
using StartappProject.Models;

namespace StartappProject
{
    class ChatTemplateSelector : DataTemplateSelector
    {
        DataTemplate incomingDataTemplate;
        DataTemplate outgoingDataTemplate;

        public ChatTemplateSelector()
        {
            incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            outgoingDataTemplate = new DataTemplate(typeof(ViewCell1));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Message;
            if (messageVm == null) { return null; }

            return (messageVm.User == ChatPage.User) ? outgoingDataTemplate : incomingDataTemplate;
        }
    }
}
