using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.XForms.TabView;
using TabViewSample;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class SfTabViewBehavior : Behavior<SfTabView>
    {
        protected override void OnAttachedTo(SfTabView bindable)
        {
            BookPage bookPage = new BookPage();
            InboxPage inboxPage = new InboxPage();
            ContactPage contactPage = new ContactPage();
            bindable.Items.Add(new SfTabItem { Content = bookPage.Content, Title = "Books" });
            bindable.Items.Add(new SfTabItem { Content = inboxPage.Content, Title = "Inbox" });
            bindable.Items.Add(new SfTabItem { Content = contactPage.Content, Title = "Contacts" });

            base.OnAttachedTo(bindable);
        }
    }
}