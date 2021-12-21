using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("10 numbers");

            //Random random = new Random();
            ////random.Next(1,10);
            //int[] tenRandomNum = new int[10];
            //for (int i = 0; i < tenRandomNum.Length; i++)
            //{
            //    tenRandomNum[i] = random.Next(10);
            //    Console.WriteLine(tenRandomNum[i]);
            //}
            //Console.WriteLine("double numbers");
            //List<int> list = tenRandomNum.Where(item => item % 2 == 0).ToList();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.WriteLine("up 4");

            //List<int> listUpFour = tenRandomNum.Where(item => item > 4).OrderBy(item => item).ToList();
            //for (int i = 0; i < listUpFour.Count; i++)
            //{
            //    Console.WriteLine(listUpFour[i]);
            //}
            //Console.WriteLine("names up 3 length");
            ////מיון בסדר הפוך descending
            //string[] names = new string[] { "keren", "tikva", "eden", "yafit", "dan" };
            //List<string> listNames = names.Where(item => item.Length > 3).OrderByDescending(item => item).ToList();
            //for (var i = 0; i < listNames.Count; i++)
            //{
            //    Console.WriteLine(listNames[i]);
            //}
            //string myName = listNames.Find(item => item == "keren");
            //Console.WriteLine($"myName is : {myName}");

            //Person[] people = new Person[]
            //{
            //    new Person("keren","hailu",1998),
            //    new Person("tikva","yosef",1996),
            //    new Person("eden","genet",1996),
            //    new Person("yaf","smuel",1997)
            //};
            //Console.WriteLine("people :");

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.name} {person.lname} {person.year}");
            //}
            //List<Person> listPeopleOver3 = people.Where(item => item.name.Length > 3).OrderBy(item => item.year).ToList();
            //Console.WriteLine();
            //Console.WriteLine("people over 3:");
            //foreach (var person in listPeopleOver3)
            //{
            //    Console.WriteLine($"{person.name} {person.lname} {person.year}");
            //}
            //Person person1 = listPeopleOver3.Find(item => item.year == 1996);
            //Console.WriteLine("person1 :");
            //Console.WriteLine($"{person1.name} {person1.lname} {person1.year}");
            //---------------------------------------------------------------
            //    //שאלה 1
            //    Console.WriteLine("ask 1");
            //    Console.WriteLine("name start with a");

            //    string[] Fivenames = new string[] { "keren", "tikva", "eden", "yafit", "aan" };
            //    List<string> nameStartWithA = Fivenames.Where(item => item[0] == 'a').ToList();
            //    for (int i = 0; i < nameStartWithA.Count; i++)
            //    {
            //        Console.WriteLine(nameStartWithA[i]);
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 1
            //    Console.WriteLine("ask 1");
            //    var namess = from name in Fivenames
            //                 where name[0] == 'a'
            //                 select name;
            //    foreach (var name in namess)
            //    {
            //        Console.WriteLine(name);
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 2
            //    Console.WriteLine("ask 2");
            //    int[] TenAge = new int[] { 10, 20, 30, 50, 40, 55, 44, 12, 32, 16 };
            //    Console.WriteLine("age up 18");
            //    List<int> AgeUp18 = TenAge.Where(item => item > 18).ToList();
            //    for (int i = 0; i < AgeUp18.Count; i++)
            //    {
            //        Console.WriteLine(AgeUp18[i]);
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 2
            //    Console.WriteLine("ask 2");
            //    var agesUp18 = from age in TenAge
            //                   where age > 18
            //                   select age;
            //    foreach (var age in agesUp18)
            //    {
            //        Console.WriteLine(age);
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 3
            //    Console.WriteLine("ask 3");
            //    List<Person> Users = new List<Person> { };
            //    Person user1 = new Person("keren", "hailu", 1998, "telAviv");
            //    Person user2 = new Person("tikva", "yosef", 1996, "telAviv");
            //    Person user3 = new Person("eden", "genet", 1990, "telAviv");
            //    Person user4 = new Person("yaf", "smuel", 2000, "telAviv");
            //    Person user5 = new Person("eden", "genet", 2002, "telAviv");
            //    Person user6 = new Person("yaf", "smueln", 1990, "telAviv");
            //    Users.Add(user1);
            //    Users.Add(user2);
            //    Users.Add(user3);
            //    Users.Add(user4);
            //    Users.Add(user5);
            //    Users.Add(user6);
            //    List<Person> UsersUp21 = Users.Where(item => item.year < 1998).ToList();
            //    Console.WriteLine("users up 21");
            //    for (int i = 0; i < UsersUp21.Count; i++)
            //    {
            //        Console.WriteLine($"{UsersUp21[i].name} {UsersUp21[i].lname} {UsersUp21[i].year}");
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //אובייקטים של קבוצות
            //    var groupusers = (from item in Users
            //                      group item by item.year);
            //    foreach (var group in groupusers)
            //    {
            //        Console.WriteLine($"group : {group.Key}");
            //        foreach (var user in group)
            //        {
            //            Console.WriteLine(user.name);
            //        }
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 3
            //    Console.WriteLine("ask 3");
            //    var UsersOver21 = from user in Users
            //                      where user.year < 1998
            //                      select user;
            //    foreach (Person user in UsersOver21)
            //    {
            //        Console.WriteLine(user.name);
            //    }
            //    Console.WriteLine("--------------------------------");

            //    //---------------------------------------------------------------
            //    //שאלה4 
            //    Console.WriteLine("ask 4");
            //    List<Person> UsersLnameUp3 = Users.Where(item => item.lname.Length > 4).ToList();
            //    Console.WriteLine("users lname up 4 length");
            //    for (int i = 0; i < UsersUp21.Count; i++)
            //    {
            //        Console.WriteLine($"{UsersLnameUp3[i].name} {UsersLnameUp3[i].lname} {UsersLnameUp3[i].year}");
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה4
            //    Console.WriteLine("ask 4");
            //    var userOver4Lenght = from user in Users
            //                          where user.lname.Length > 4
            //                          select user;
            //    foreach (Person user in userOver4Lenght)
            //    {
            //        Console.WriteLine(user.name);
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 5 

            //    List<Person> UsersOver25 = Users.Where(item => item.year < 1996).ToList();
            //    Console.WriteLine("users up 25");
            //    for (int i = 0; i < UsersOver25.Count; i++)
            //    {
            //        Console.WriteLine($"{UsersOver25[i].name} {UsersOver25[i].lname} {UsersOver25[i].year}");
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //שאלה 5 
            //    var usersAgeUp25 = from user in Users
            //                       where user.year < 1996
            //                       select user;
            //    foreach (Person user in usersAgeUp25)
            //    {
            //        Console.WriteLine(user.name);
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //6 שאלה
            //    Console.WriteLine();
            //    List<Person> UsersEndWithN = Users.Where(item => item.lname.ToLower()[item.lname.Length - 1] == 'n').ToList();
            //    Console.WriteLine("users end with N");
            //    for (int i = 0; i < UsersEndWithN.Count; i++)
            //    {
            //        Console.WriteLine($"{UsersEndWithN[i].name} {UsersEndWithN[i].lname} {UsersEndWithN[i].year}");
            //    }
            //    Console.WriteLine("--------------------------------");
            //    //---------------------------------------------------------------
            //    //6 שאלה
            //    var UsersNameEndWithN = from user in Users
            //                            where user.lname.ToLower()[user.lname.Length - 1] == 'n'
            //                            select user;
            //    foreach (Person user in UsersNameEndWithN)
            //    {
            //        Console.WriteLine(user.name);
            //    }
            //    //---------------------------------------------------------------
            //    //7+8 שאלה
            //    Console.WriteLine("ask 7");
            //    List<Person> UserList = new List<Person> { };
            //    Person UserList1 = new Person("keren", "hailu", 1990,"yehud");
            //    Person UserList2 = new Person("tikva", "hailu", 1990,"telAviv");
            //    Person UserList3 = new Person("eden", "hailu", 1990, "telAviv");
            //    Person UserList4 = new Person("yaf", "smuel", 2000, "telAviv");
            //    Person UserList5 = new Person("eden", "genet", 2002, "lod");
            //    Person UserList6 = new Person("yaf", "smueln", 1990, "lod");
            //    UserList.Add(UserList1);
            //    UserList.Add(UserList2);
            //    UserList.Add(UserList3);
            //    UserList.Add(UserList4);
            //    UserList.Add(UserList5);
            //    UserList.Add(UserList6);

            //    var userWithSameLname = from User in UserList
            //                            group User by User.lname.ToLower();
            //    foreach (var user in userWithSameLname)
            //    {
            //        Console.WriteLine($"group : {user.Key}");
            //        foreach (var person in user)
            //        {
            //            Console.WriteLine(person.name);
            //        }
            //        Console.WriteLine("--------------------------------");
            //    }
            //    //---------------------------------------------------------------
            //    //9+10+11 שאלה
            //    var groupByCity = from User in UserList
            //                      group User by User.city;
            //    foreach(var group in groupByCity)
            //    {
            //        Console.WriteLine($"group : {group.Key}");
            //        foreach (var person in group)
            //        {
            //            Console.WriteLine($"{ person.name},{person.lname} {person.year} {person.city}");
            //        }
            //    }
            //    Console.WriteLine("--------------------------------");




            //שיעורי ביתתתתתתתתתתתתתתתתתתתתתתתתתתתתתתתתת
            //---------------------------------------------------
            //1.	צרו מערך של 7 שמות מהכיתה וצרו ממנו רשימה של שמות שמתחילות ב E.
            string[] nameOfClass = new string[] { "eden", "avi", "matan", "marcos", "haim", "tikva", "oshri" };
            List<string> nameStartWithE = nameOfClass.Where(item => item[0] == 'e').ToList();
            for (int i = 0; i < nameStartWithE.Count; i++)
            {
                Console.WriteLine(nameStartWithE[i]);
            }
            //---------------------------------------------------
            //2.צרו מערך של 10 גילים רנדומליים וצרו ממנו רשימה של גילים מעל 20.
            Random random = new Random();
            int[] tenRandomNumUp20 = new int[10];
            for (int i = 0; i < tenRandomNumUp20.Length; i++)
            {
                tenRandomNumUp20[i] = random.Next(20);
                Console.WriteLine(tenRandomNumUp20[i]);
            }

            //---------------------------------------------------
            //        3.	צרו מחלקה של ספר, עם שדות של שם, כותב ומספר עמודים.
            //        4.	צרו מערך של 6 ספרים עם מספר עמודים רנדומלי עד 500.
            //        5.	חתכו ממנו רשימה של ספרים עם מספר עמודים מעל 200.
            //6.חתכו מהרשימת ספרים רשימה של ספרים שיש להם 4 אותיות ומעלה בשם הכותב.
            Console.WriteLine("----------------------------");
            Random randomUntil500 = new Random();
            Book[] sixBooks = new Book[]
            {
            new Book("spiderman","shalom",randomUntil500.Next(500)),
            new Book("prince","keren",randomUntil500.Next(500)),
            new Book("yyyyy","keren",randomUntil500.Next(500)),
            new Book("Snow White","slomi",randomUntil500.Next(500)),
            new Book("batman","slomi",randomUntil500.Next(500)),
            new Book("yyyyy","slomi",randomUntil500.Next(500)),
            };
            for (int i = 0; i < sixBooks.Length; i++)
            {
                Console.WriteLine($"{ sixBooks[i].name} { sixBooks[i].writer} { sixBooks[i].numOfPage}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("page over 200 :");
            List<Book> pajeBookUp200 = sixBooks.Where(item => item.numOfPage > 200).Where(item => item.writer.Length > 4).ToList();
            for (int i = 0; i < pajeBookUp200.Count; i++)
            {
                Console.WriteLine($"{ pajeBookUp200[i].name} { pajeBookUp200[i].writer} { pajeBookUp200[i].numOfPage}");
            }
            Console.WriteLine("----------------------------");
            //string myName = listNames.Find(item => item == "keren");

            //לא עובד
            //7.חתכו מהרשימה את הספר הראשון שקצר מ 150 עמודים.
            //List<Book> bookPageShortThen150 = sixBooks.Find(item => item.numOfPage < 150);

            Console.WriteLine("----------------------------");
            //לא עובד
            //8.חתכו מהרשימה רק את אלה שהשם שלהם מסתיים ב Y.
            //List<Book> endWithE = sixBooks.Where(item => item.name[item.name.Length - 1] == 'y');

            //  9.שנו את הרשימה של הספרים כך שיהיו 3 שמות כותבים זהים.
            //10.ארגנו אותם לקבוצות על פי שם הכותב והדפיסו את הפרטים.

            var groupBooks = from book in sixBooks
                             group book by book.writer.ToLower();
            foreach (var book in groupBooks)
            {
                Console.WriteLine(book.Key);
                foreach(Book group in book)
                {
                    Console.WriteLine($"{group.name} {group.writer} {group.numOfPage}");
                }
            }
                Console.WriteLine("----------------------------");
            //11.ארגנו אותם לקבוצות על פי שם הכותב והדפיסו רק את שם הספר.

            foreach (var book in groupBooks)
            {
                Console.WriteLine($"writer : {book.Key}");
                foreach (Book group in book)
                {
                    Console.WriteLine($"name of book : {group.name}");
                }
            }
            Console.WriteLine("----------------------------");

        }
    }
}
