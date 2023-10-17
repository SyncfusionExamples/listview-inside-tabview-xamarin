
# Load the Listview within Tabview in Xamarin.Forms (SfListView)
This section explains how to load the Listview within Tabview in Xamarin.Forms (SfListView).

## Define the SfListView in a separate XAML.

**[XAML]**
```
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:local="clr-namespace:ListViewXamarin" 
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sync="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
             x:Class="TabViewSample.BookPage">
 
    <ContentPage.BindingContext>
        <local:BookInfoRepository />
    </ContentPage.BindingContext>
 
    <sync:SfListView x:Name="listView" ItemsSource="{Binding BookInfo}" ItemSize="100">
        <sync:SfListView.ItemTemplate>
            <DataTemplate>
                <Grid Padding="10">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="0.4*" />
                        <RowDefinition Height="0.6*" />
                    </Grid.RowDefinitions>
                    <Label x:Name="label" Text="{Binding BookName}" FontSize="21" FontAttributes="Bold" />
                    <Label Grid.Row="1" Text="{Binding BookDescription}" FontSize="15" />
                </Grid>
            </DataTemplate>
        </sync:SfListView.ItemTemplate>
    </sync:SfListView>
</ContentPage>
```

## Load the SfTabView in the MainPage.xaml.

**[XAML]**
```
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ListViewXamarin"
             xmlns:tabView="clr-namespace:Syncfusion.XForms.TabView;assembly=Syncfusion.SfTabView.XForms"
             x:Class="ListViewXamarin.MainPage">
 
    <ContentPage.Content>
        <tabView:SfTabView VisibleHeaderCount="3" TabHeaderBackgroundColor="#dddddd">
            <tabView:SfTabView.Behaviors>
                <local:SfTabViewBehavior/>
            </tabView:SfTabView.Behaviors>
        </tabView:SfTabView>
    </ContentPage.Content>
</ContentPage>
```

## Create ListView page instance and add it to the SfTabView.Items collection.

**[C#]**
```
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
```
## How to run this application?

To run this application, you need to first clone the listview-inside-tabview-xamarin repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.