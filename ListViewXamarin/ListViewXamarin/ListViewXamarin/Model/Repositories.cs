using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    #region BookInfoRepository
    public class BookInfoRepository
    {
        #region Properties

        public ObservableCollection<BooksModel> BookInfo { get; set; }

        #endregion

        #region Constructor

        public BookInfoRepository()
        {
            GenerateBookInfo();
        }

        #endregion

        #region Methods

        internal void GenerateBookInfo()
        {
            BookInfo = new ObservableCollection<BooksModel>();
            BookInfo.Add(new BooksModel() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm" });
            BookInfo.Add(new BooksModel() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions" });
            BookInfo.Add(new BooksModel() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning" });
            BookInfo.Add(new BooksModel() { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development" });
            BookInfo.Add(new BooksModel() { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" });
            BookInfo.Add(new BooksModel() { BookName = "Android Programming", BookDescription = "It is provides a useful overview of the Android application lifecycle" });
            BookInfo.Add(new BooksModel() { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" });
            BookInfo.Add(new BooksModel() { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment" });
            BookInfo.Add(new BooksModel() { BookName = "Xamarin.Forms", BookDescription = "Its creates mappings from its C# classes and controls directly" });
            BookInfo.Add(new BooksModel() { BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development" });
            BookInfo.Add(new BooksModel() { BookName = "Agile Software Development", BookDescription = "Learning new development processes can be difficult" });
            BookInfo.Add(new BooksModel() { BookName = "Assembly Language", BookDescription = "Assembly language is as close to writing machine code" });
            BookInfo.Add(new BooksModel() { BookName = "Cryptography in .NET", BookDescription = "Cryptography is used throughout software to protect all kinds of information" });
            BookInfo.Add(new BooksModel() { BookName = "Entity Framework Code First", BookDescription = "Follow author Ricardo Peres as he introduces the newest development mode" });
            BookInfo.Add(new BooksModel() { BookName = "Localization for .NET", BookDescription = "Learn to write applications that support different languages and cultures" });
        }

        #endregion
    }
    #endregion

    #region ContactsRepository
    public class ContactsRepository
    {
        #region Properties

        public ObservableCollection<Contacts> ContactsInfo { get; set; }
        #endregion

        #region Constructor

        public ContactsRepository()
        {
            GenerateInfo();
        }
        #endregion

        #region GenerateInfo
        public void GenerateInfo()
        {
            Random r = new Random();
            ContactsInfo = new ObservableCollection<Contacts>();
            for (int i = 0; i < CustomerNames.Count(); i++)
            {
                var contact = new Contacts(CustomerNames[i], r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
                contact.ContactImage = ImageSource.FromResource("ListViewXamarin.Images.Image" + r.Next(0, 28) + ".png", typeof(MainPage));
                ContactsInfo.Add(contact);
            }
        }

        #endregion

        #region Fields

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson"    ,
            "Mason  "    ,
            "Liam   "    ,
            "Jacob  "    ,
            "Jayden "    ,
            "Ethan  "    ,
            "Noah   "    ,
            "Lucas  "    ,
            "Logan  "    ,
            "Caleb  "    ,
            "Caden  "    ,
            "Jack   "    ,
            "Ryan   "    ,
            "Connor "    ,
            "Michael"    ,
            "Elijah "    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"    ,
            "James  "    ,
            "Landon "    ,
            "Nathan "    ,
            "Dylan  "    ,
            "Evan   "    ,
            "Luke   "    ,
            "Andrew "    ,
            "Gabriel"    ,
            "Gavin  "    ,
            "Joshua "    ,
            "Owen   "    ,
            "Daniel "    ,
            "Carter "    ,
            "Tyler  "    ,
            "Cameron"    ,
            "Christian"  ,
            "Wyatt  "    ,
            "Henry  "    ,
            "Eli    "    ,
            "Joseph "    ,
            "Max    "    ,
            "Isaac  "    ,
            "Samuel "    ,
            "Anthony"    ,
            "Grayson"    ,
            "Zachary"    ,
            "David  "    ,
            "Christopher",
            "John   "    ,
            "Isaiah "    ,
            "Levi   "    ,
            "Jonathan"   ,
            "Oliver "    ,
            "Chase  "    ,
            "Cooper "    ,
            "Tristan"    ,
            "Colton "    ,
            "Austin "    ,
            "Colin  "    ,
            "Charlie"    ,
            "Dominic"    ,
            "Parker "    ,
            "Hunter "    ,
            "Thomas "    ,
            "Alex   "    ,
            "Ian    "    ,
            "Jordan "    ,
            "Cole   "    ,
            "Julian "    ,
            "Aaron  "    ,
            "Carson "    ,
            "Miles  "    ,
            "Blake  "    ,
            "Brody  "    ,
            "Adam   "    ,
            "Sebastian"  ,
            "Adrian "    ,
            "Nolan  "    ,
            "Sean   "    ,
            "Riley  "    ,
            "Bentley"    ,
            "Xavier "    ,
            "Hayden "    ,
            "Jeremiah"   ,
            "Jason  "    ,
            "Jake   "    ,
            "Asher  "    ,
            "Micah  "    ,
            "Jace   "    ,
            "Brandon"    ,
            "Josiah "    ,
            "Hudson "    ,
            "Nathaniel"  ,
            "Bryson "    ,
            "Ryder  "    ,
            "Justin "    ,
            "Bryce  "    ,
        };

        #endregion
    }
    #endregion

    #region ListViewInboxInfoRepository
    public class ListViewInboxInfoRepository
    {
        #region Properties
        public ObservableCollection<ListViewInboxInfo> InboxInfo { get; set; }
        #endregion

        #region Constructor

        public ListViewInboxInfoRepository()
        {
            GetInboxInfo();
        }

        #endregion

        #region GetInboxInfo

        internal void GetInboxInfo()
        {
            InboxInfo = new ObservableCollection<ListViewInboxInfo>();
            for (int i = 0; i < Subject.Count(); i++)
            {
                var record = new ListViewInboxInfo()
                {
                    Title = Title[i],
                    Subject = Subject[i],
                    Description = Descriptions[i],
                    Date = Month[i] + " " + (i + 8).ToString(),
                };
                InboxInfo.Add(record);
            }
        }

        #endregion

        #region Inbox Info

        string[] Title = new string[]
        {
            "James Landon",
            "Daniel Caden",
            "Holly Steve",
            "Jacob Oscar",
            "Fiona Michael",
            "Ralph Jennifer",
            "Nicholas Ryan",
            "Liam Connor",
            "Benjamin Alexander",
            "Brenda Kyle",
            "Liz Torrey",
            "Nathan Taylor",
            "Dominic Thomas",
            "Riley Sean",
            "Xavier Bryce"

        };

        string[] Month = new string[]
        {
            "Jan",
            "Jan",
            "Feb",
            "Mar",
            "Mar",
            "Apr",
            "May",
            "May",
            "May",
            "June",
            "July",
            "Aug",
            "Aug",
            "Sep",
            "Sep"
        };

        string[] Subject = new string[] {
            "Happy birthday to an amazing employee!",
            "Like a vintage auto, your value increases...",
            "Happy Anniversary! Happy Anniversary!",
            "We wish you an amazing year with accomplishment...",
            "No one could do a better job than...",
            "GET WELL SOON!!",
            "A cheery Christmas hold lots of happiness for you!",
            "BOO!!! Happy Halloween! Happy Halloween!",
            "Happy Turkey Day!!",
            "Wishing you Happy St Pat's Day!",
            "Congratulations on the move!",
            "Enjoy the new greener pastures!",
            "Happy Thanksgiving Day!",
            "Never doubt yourself. You’re always...",
            "The warmest wishes to a great member of our team...",
        };

        string[] Descriptions = new string[] {
            "Wishing you great achievements in this career, And I hope that you have a great day today!",
            "Happy birthday to one of the best and most loyal employees ever!",
            "Congrats! May your life continue to be filled with love, laughter and happiness.",
            "We wish you an amazing year with accomplishment of the great goals that you have set!",
            "No one could do a better job than the job you do. We thank you for sticking with us!",
            "Card messages aren't my thing. Get well soon!",
            "Wishing you a happy Christmas. May it be all that you hope it will be! All the best",
            "Wishing you a killer Halloween, Don't forget to give us treat or else..",
            "Happy Turkey Day!. Don't forget to give thanks for being so blessed.",
            "It's all green which means its all good! HAPPY ST PAT'S",
            "Congratulations! May you find great happiness at your new address.",
            "Good luck with the new job and your career aspirations. All the best",
            "May you enjoy this special day. Happy Thanksgiving to you and your whole family!",
            "Never doubt yourself. You’re always the best! Just continue to be like that!",
            "Warmest wishes! May your special day be full of good emotions, fun and cheer!"
        };

        #endregion
    }
    #endregion
}
