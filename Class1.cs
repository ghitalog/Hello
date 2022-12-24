//using System;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;

//namespace exercises
//{
//    class Programadsa
//    {
//        static void Main(string[] args)
//        {
//            string text = "AAAbfed231.91.4";
//            Console.WriteLine("Original string: " + text);
//            Console.WriteLine("Sorted string: " + test(text));
//            text = " ";
//            Console.WriteLine("Original string: " + text);
//            Console.WriteLine("Sorted string: " + test(text));
//            text = "Python";
//            Console.WriteLine("Original string: " + text);
//            Console.WriteLine("Sorted string: " + test(text));
//            text = "W3resource";
//            Console.WriteLine("Original string: " + text);
//            Console.WriteLine("Sorted string: " + test(text));
//        }

//        public static string test(string text)
//        {
//            bool flag = string.IsNullOrWhiteSpace(text);
//            if (flag)
//            {
//                return "Blank string!";
//            }
//            var text_nums = text.Where(char.IsDigit).OrderBy(el => el).ToList();
//            var text_chars = text.Where(char.IsLetter)
//                .Select(el => new { l_char = char.ToLower(el), _char = el })
//                .OrderBy(el => el.l_char)
//                .ThenByDescending(el => el._char)
//                .ToList();

//            return new string(text_chars.Select(el => el._char).Concat(text_nums).ToArray());
//        }
//    }
//}






//using System;
//using System.Collections.Generic;

//namespace PersonalManager
//{
//    class Program1233211
//    {

//        class Person
//        {
//            public string name { get; protected set; }
//            public int age { get; protected set ; }

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }   

//            public string returnDetails()
//            {
//                return name + " - " + age;
//            }
//            public void setName(string name)
//            {
//                this.name = name;
//            }
//            public void  setAge (int age)
//            {
//                this.age = age;
//            }

//            static void Main(string[] args)
//            {
//                Person person = new Person("aba", 23);

//                Console.WriteLine(person.returnDetails());
//            }
//        }
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography;

//namespace PersonalManager

//{
//    class program123
//    {
//        class Person
//        {
//            public string name { get; protected set; }
//            public int age { get; protected set; }

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }
//            public string returnDetails()
//            {
//                return name + " - " + age;
//            }
//            public void setName(string name)
//            {
//                this.name = name;
//            }
//            public void setAge(int age)
//            {
//                this.age = age;
//            }
//            class Manager
//            {
//                public List<Person> people;

//                public Manager()
//                {
//                    people = new List<Person>()
//                    {
//                        new Person("Aba", 25),
//                        new Person("test", 001)
//                    };
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management System" + Environment.NewLine);
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

//                    Console.WriteLine("Enter your menu option: ");

//                    bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

//                    if (tryParse)
//                    {
//                        //Console.WriteLine(menuOption);

//                        if (menuOption == 1)
//                        {
//                            PrintAll();
//                        }
//                        else if (menuOption == 2)
//                        {
//                            AddPerson();
//                        }
//                        else if (menuOption == 3)
//                        {
//                            EditPerson();
//                        }
//                        else if (menuOption == 4)
//                        {
//                            SearchPerson();
//                        }
//                        else if (menuOption == 5)
//                        {
//                            RemovePerson();
//                        }
//                    }
//                    else
//                    {
//                        OutputMessge("Incorrect menu choice !");
//                        printMenu();

//                    }
//                    }
//                    public void PrintAll()
//                    {
//                    Console.Clear();
//                    StartOption("Print all users!");
//                    int i = 0;
//                        i++;
//                        people.ForEach(person => Console.WriteLine(i + "." + person.returnDetails()));
                    
//                    FinishOption();

//                    printMenu();
//                    }
//                    public void AddPerson()
//                    {
//                    StartOption("Adding a user: ");

//                    try
//                    {
//                        Console.WriteLine("Enter your name");
//                        string nameInput = Console.ReadLine();

//                        Console.WriteLine("Enter your age");
//                        int ageInput = Convert.ToInt32(Console.ReadLine());

//                        if (!string.IsNullOrEmpty(nameInput))
//                        {
//                            if (ageInput >= 0 && ageInput <= 150)
//                            {
//                                Person person = new Person(nameInput, ageInput);

//                                people.Add(person);
                                
//                            }
//                            else
//                            {
//                                OutputMessge("Enter a sensible age");
//                                AddPerson();

//                            }
//                        }
//                        else
//                        {
//                            OutputMessge("You did not enter a number");
//                            AddPerson();
//                        }
                        


//                    }
//                    catch (Exception)
//                    {
//                        OutputMessge("Something has went wrong !");
//                        AddPerson();


//                    }
//                    FinishOption();
//                    printMenu();
//                    }
//                    public void EditPerson()
//                    {
//                    StartOption("Editing a user");
//                        Console.WriteLine("Edit");
//                    }
//                    public void SearchPerson()
//                    {
//                    StartOption("Search a person");
//                        Console.WriteLine("Search");
//                    }
//                    public void RemovePerson()
//                    {
//                    StartOption("Remove a person");
//                        Console.WriteLine("Remove");
//                    }
//                public void FinishOption()
//                {
//                    Console.WriteLine("You have finished this option. Press <Enter> to return to the menu!");
//                    Console.ReadLine();
//                    Console.Clear();
//                }
//                public void StartOption(string message)
//                {
//                   // Console.Clear();
//                    Console.WriteLine(message + Environment.NewLine);
//                }
//                public void OutputMessge(string message)
//                {
//                    Console.WriteLine(message + " Press <Enter> to try again.");
//                    Console.ReadLine();
//                    Console.Clear();
//                }

//                }
//                static void Main(string[] args)
//                {
//                    Manager manager = new Manager();

//                    Console.ReadLine();
//                }
//            }
//        }
//    }

