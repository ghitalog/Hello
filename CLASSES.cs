//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(test(new[] { 1, 2, 3, 5, 3, 7 }));
//            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }));
//            Console.WriteLine(test(new[] { 3, 7, 5, 5, 6, 7, 5 }));
//        }
//        static bool test(int[] numbers)
//        {
//            for (int i = 0; i <= numbers.Length - 3; i++) // ii - 3 fiidnca comparam 3 numere adica + 1 si apoi + 2
//            {
//                if (numbers[i] == numbers[i + 1] - 1 // i in WriteLine primul este = cu 1 apoi 1 + 1 - 1 = 1 diferenta ii 1
//                    && numbers[i] == numbers[i + 2] - 2) // el sare 3 si - 2 = 1 diferenta ii 1 inseamnca ca ii correct
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//    }
//}


//using System;

//face
//{
//fill: #FFDCB2;
//}

//hairstyle
//{
//fill: black;
//}

//eyebrows
//{
//fill: brown;
//}
//eyes
//{
//fill: blue
//    }

//facialhair
//{
//fill: yellow;
//}
//torso
//{
//fill: green;
//}
//arms
//{
//fill: brown
//    }
//top
//{
//fill: blue
//    }
//legs
//{
//fill: green;
//}
//bottoms
//{
//fill: green
//    }
//feet
//{
//fill: green;
//}
//shoes
//{
//fill: red;
//}
//# chris {
//fill: green;
//}
//  .skin
//{
//fill: red

//      }
//    .background
//{
//    background - image:
//radial - gradient(closest - side, transparent 0 %, transparent 75 %, #B6CC66 76%, #B6CC66 85%, #EDFFDB 86%, #EDFFDB 94%, #FFFFFF 95%, #FFFFFF 103%, #D9E6A7 104%, #D9E6A7 112%, #798B3C 113%, #798B3C 121%, #FFFFFF 122%, #FFFFFF 130%, #E0EAD7 131%, #E0EAD7 140%),
//radial - gradient(closest - side, transparent 0 %, transparent 75 %, #B6CC66 76%, #B6CC66 85%, #EDFFDB 86%, #EDFFDB 94%, #FFFFFF 95%, #FFFFFF 103%, #D9E6A7 104%, #D9E6A7 112%, #798B3C 113%, #798B3C 121%, #FFFFFF 122%, #FFFFFF 130%, #E0EAD7 131%, #E0EAD7 140%);
//background - size: 110px 110px;
//    background - color: #C8D3A7;
//background - position: 0 0, 55px 55px;
//}


//< character >
//   < face />
//    < face class= "skin" />
//   < hairstyle type = "9" />
//   < eyebrows type = "2" />
//   < eyes  type = "3" />
//   < mouth type = "1" />
//   < facialhair type = "4" />
//   < torso />
//   < arms />
//   < top id = "chris" />
//   < legs />
//   < bottoms />
//   < feet />
//   < shoes />
//</ character >





//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] item = test(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 });
//            Console.Write("New array: ");
//            foreach (var i in item)
//            {
//                Console.Write(i.ToString() + " ");
//            }
//        }
//        static int[] test(int[] numbers)
//        {
//            int pos = 0;
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (numbers[i] == 0)
//                {
//                    numbers[i] = numbers[pos]; // aicea ii face schimbare cu pozitia 
//                    numbers[pos++] = 0;
//                }
//            }
//            return numbers;
//        }
//    }
//}








//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld23123
//{
//    class Program1234321
//    {
//        class Person
//        {
//            public string name { get; protected set; } // proprieties !!
//            public int age { get; protected set; }

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }
//            public string returnDetails()
//            {
//                return $"{name} - {age}";
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
//                    people = new List<Person>();
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management systen!" + Environment.NewLine);
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

//                    Console.WriteLine("Enter your menu option: ");

//                    if (int.TryParse(Console.ReadLine(), out int menuOption))
//                    {

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
//                            SearchPeople();
//                        }
//                        else if (menuOption == 5)
//                        {
//                            RemovePerson();
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Incorrect menu choice.");
//                        Console.WriteLine("Press <Enter> to try again.");
//                        Console.ReadLine();
//                        Console.Clear();
//                        printMenu();
//                    }

//                }
//                public void PrintAll()
//                {
//                    Console.WriteLine("PrintAll");
//                }
//                public void AddPerson()
//                {
//                    Console.WriteLine("AddPerson");
//                }
//                public void EditPerson()
//                {
//                    Console.WriteLine("EditPerson");
//                }
//                public void SearchPeople()
//                {
//                    Console.WriteLine("SearchPerson");
//                }
//                public void RemovePerson()
//                {
//                    Console.WriteLine("RemovePerson");
//                }
//            }
//            static void Main(string[] args)
//            {
//                Manager manager = new Manager();
//                //Person person = new Person("Aba", 23);
//                //Console.WriteLine(person.returnDetails());
//                //person.setName("Ghita");
//                //person.setAge(23);
//                //Console.WriteLine(person.returnDetails());
//                Console.ReadLine();
//            }
//        }
//    }
//}






//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld23123
//{
//    class Program1234321
//    {
//        class Person
//        {
//            public string name { get; protected set; } // proprieties !!
//            public int age { get; protected set; }

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }
//            public string returnDetails()
//            {
//                return $"{name} - {age}";
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
//                        new Person("aba", 23),
//                        new Person("Test", 33)
//                    };
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management systen!" + Environment.NewLine);
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

//                    Console.WriteLine("Enter your menu option: ");
//                    if (int.TryParse(Console.ReadLine(), out int menuOption))
//                    {
//                        if (menuOption > 6)
//                        {
//                            Console.WriteLine("YOU choose to high number!");
//                        }

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
//                            SearchPeople();
//                        }
//                        else if (menuOption == 5)
//                        {
//                            RemovePerson();
//                        }

//                    }
//                    else
//                    {
//                        Console.WriteLine("Incorrect menu choice.");
//                        Console.WriteLine("Press <Enter> to try again.");
//                        Console.ReadLine();
//                        Console.Clear();
//                        printMenu();
//                    }

//                }
//                public void PrintAll()//  to print inside of people care sunt o lista de persoane 
//                {
//                    Console.Clear();
//                    int i = 0;
//                    people.ForEach(person =>
//                    {
//                        i++;
//                        Console.WriteLine(i + ". " + person.returnDetails());
//                    });

//                    Console.WriteLine("You have finished this option. Press <Enter> to return to the menu.");
//                    Console.ReadLine();
//                    Console.Clear();
//                    printMenu();


//                }
//                public void AddPerson()
//                {
//                    Console.WriteLine("AddPerson");
//                }
//                public void EditPerson()
//                {
//                    Console.WriteLine("EditPerson");
//                }
//                public void SearchPeople()
//                {
//                    Console.WriteLine("SearchPerson");
//                }
//                public void RemovePerson()
//                {
//                    Console.WriteLine("RemovePerson");
//                }
//            }
//            static void Main(string[] args)
//            {
//                Manager manager = new Manager();
//                //Person person = new Person("Aba", 23);
//                //Console.WriteLine(person.returnDetails());
//                //person.setName("Ghita");
//                //person.setAge(23);
//                //Console.WriteLine(person.returnDetails());
//                Console.ReadLine();
//            }
//        }
//    }
//}


//namespace HelloWorld23123
//{
//    class Program1234321
//    {
//        class Person
//        {
//            public string name { get; private set; }
//            public int age { get; private set; }

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }

//            public string returnDetails()
//            {
//                return $"{name} - {age}";
//            }

//        }
//        class Manager
//        {
//            List<Person> people;

//            public Manager()
//            {
//                people = new List<Person>();
//                PrintMenu();
//            }

//            public void PrintMenu()
//            {
//                string[] menuOptions = new string[]
//                {
//                    "Print all users",
//                    "Add user",
//                    "Edit user",
//                    "Search user",
//                    "Remove user",
//                    "Exit"
//                };
//                Console.WriteLine("Welcome to my management system!" + Environment.NewLine);

//                for (int i = 0; i < menuOptions.Length; i++)
//                {
//                    Console.WriteLine(i + 1 + ". " + menuOptions[i]);
//                }



//                Console.Write("Enter your option: ");

//                bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);


//                if (tryParse)
//                {
//                    if (menuOption > menuOptions.Length)
//                    {
//                        Console.WriteLine("You entered too high number");
//                        Console.ReadLine();
//                        Console.Clear();
//                        PrintMenu();
//                    }
//                    if (menuOption == 1)
//                    {
//                        PrintAll();
//                    }
//                    else if (menuOption == 2)
//                    {
//                        AddPerson();
//                    }
//                    else if (menuOption == 3)
//                    {
//                        EditPerson();
//                    }
//                    else if (menuOption == 4)
//                    {
//                        SearchPeople();
//                    }
//                    else if (menuOption == 5)
//                    {
//                        RemovePerson();
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Incorrect menu choice.Press <Enter > to try again");
//                    Console.ReadLine();
//                    Console.Clear();
//                    PrintMenu();
//                }


//            }

//            public void PrintAll()
//            {
//                Console.Clear();
//                if (people.Count == 0)
//                {
//                    Console.WriteLine("There are no users in the system !" + Environment.NewLine);
//                    FinishOption();
//                }
//                else
//                {
//                    PrintAllUsers();
//                    FinishOption();
//                }
//            }
//            public void AddPerson()
//            {
//                Console.Clear();
//                Console.Write("Enter a name: ");
//                string inputName = Console.ReadLine();
//                if (string.IsNullOrEmpty(inputName))
//                {
//                    Console.WriteLine("Enter a sensbile Name.Press <Enter>");
//                    Console.ReadLine();
//                    Console.Clear();
//                    AddPerson();
//                }
//                if (inputName == "Exit")
//                {
//                    Console.Clear();
//                    PrintMenu();
//                }

//                Console.Write("Enter age: ");
//                bool tryParse = int.TryParse(Console.ReadLine(), out int inputAge);


//                if (tryParse)
//                {

//                    if (inputAge >= 0 && inputAge <= 150)
//                    {
//                        people.Add(new Person(inputName, inputAge));
//                        Console.WriteLine("Successfully added a person." + Environment.NewLine);
//                        FinishOption();
//                    }
//                    else
//                    {
//                        Console.WriteLine("Enter a sensbile age.Press <Enter>");
//                        Console.ReadLine();
//                        Console.Clear();
//                        AddPerson();

//                    }

//                }
//                else
//                {
//                    retryOption();
//                    AddPerson();
//                }




//            }
//            public void EditPerson()
//            {

//                Console.Clear();
//                PrintAllUsers();
//                Console.WriteLine();
//                Console.Write("Enter an index: ");
//                bool tryParse = int.TryParse(Console.ReadLine(), out int inputIndex);

//                if (tryParse)
//                {

//                    if (inputIndex >= 1 && inputIndex <= people.Count)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Adding a users:" + Environment.NewLine);
//                        Console.Write("Enter a name:" + Environment.NewLine);
//                        string enterName = Console.ReadLine();
//                        if (string.IsNullOrEmpty(enterName))
//                        {
//                            Console.WriteLine("Use a name please !");
//                            Console.ReadLine();
//                            Console.Clear();
//                            EditPerson();
//                        }
//                        Console.Write("Enter a age: ");
//                        int ageIndex = Convert.ToInt32(Console.ReadLine());
//                        people[inputIndex - 1] = new Person(enterName, ageIndex);


//                        Console.WriteLine("Succesfully edit a person" + Environment.NewLine);

//                        FinishOption();

//                    }
//                    else
//                    {
//                        retryOption();
//                        Console.Clear();
//                        PrintMenu();
//                    }


//                }
//                else
//                {
//                    retryOption();
//                    Console.Clear();
//                    EditPerson();


//                }

//            }
//            public void SearchPeople()
//            {
//                Console.Clear();
//                Console.Write("Enter a name: ");
//                string readstring = Console.ReadLine();
//                if (string.IsNullOrEmpty(readstring))
//                {
//                    Console.WriteLine("Please Enter a name.Press<Enter> to try again!");
//                    Console.ReadLine();
//                    Console.Clear();
//                    SearchPeople();
//                }
//                else
//                {
//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("There si no users");
//                        Console.ReadLine();
//                        Console.Clear();
//                        PrintMenu();
//                    }
//                    else
//                    {
//                        for (int i = 0; i < people.Count; i++)
//                        {
//                            if (people[i].name.Contains(readstring))
//                            {
//                                Console.WriteLine(i + 1 + ". " + people[i].returnDetails());
//                            }
//                        }
//                        FinishOption();

//                    }
//                }


//            }
//            public void RemovePerson()
//            {
//                Console.WriteLine("Remove");
//            }
//            public void retryOption()
//            {
//                Console.WriteLine("Something has went wrong.Press <Enter> to retry");
//                Console.ReadLine();
//            }

//            public void FinishOption()
//            {
//                Console.WriteLine("You have finished this Option.Press <Enter> to return to the menu");
//                Console.ReadLine();
//                Console.Clear();
//                PrintMenu();
//            }
//            public void PrintAllUsers()
//            {
//                for (int i = 0; i < people.Count; i++)
//                {
//                    Console.WriteLine(i + 1 + ". " + people[i].returnDetails());

//                }
//            }
//        }

//        public static void Main(string[] args)
//        {
//            new Manager();
//        }
//    }
//}








////Differite metode cum putem sa facem putin altfel !
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld23123
//{

//    internal class PrograM
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
//                return $"{name} - {age}";
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
//                    // new Person("Aba", 23),
//                      //new Person("Gheorghe", 26)
//                    };
//                    ;
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    string[] menuOptions = new string[]
//                    {
//                        "Print all users",
//                        "Add user",
//                        "Edit user",
//                        "Search user",
//                        "Remove user",
//                        "Exit",
//                    };

//                    Console.WriteLine("Welcome to my management system!" + Environment.NewLine);

//                    for (int i = 0; i < menuOptions.Length; i++)
//                    {
//                        Console.WriteLine(i + 1 + ". " + menuOptions[i]);
//                    }

//                    Console.Write("Enter your menu option: ");
//                    bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

//                    if (tryParse)
//                    {

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

//                        if (menuOption >= 1 && menuOption <= menuOptions.Length - 1)
//                        {
//                            printMenu();

//                        }
//                    }
//                    else
//                    {
//                        OutputMessage("Incorrect menu choice.");

//                        printMenu();
//                    }



//                }
//                public void PrintAll()
//                {
//                    StartOption("Printing all users");

//                    if (!isSystemEmpty())
//                    {
//                        PrintAllUsers();
//                    }
//                    FinishOption();

//                    int i = 0;
//                    /*
//                    people.ForEach(delegate (Person person)
//                    {
//                        i++;
//                        Console.WriteLine(i + ". " + person.returnDetails());
//                    });*/
//                    people.ForEach(person =>      //6:39 time
//                    {
//                        i++;
//                        Console.WriteLine(i + ". " + person.returnDetails());
//                    });
//                    /*foreach(Person person in people)
//                     {
//                         i++;
//                         Console.WriteLine(i + ". " + person.returnDetails());
//                     }*/
//                }

//                public void AddPerson()
//                {

//                    StartOption("Adding a  users:"); // What you need ! Enter a name , age, create a person class , add to the list and return to the menu


//                    try
//                    {
//                        Person person = returnPerson();

//                        if (person != null)
//                        {
//                            people.Add(person);
//                            Console.WriteLine("Successfully added a person.");

//                            FinishOption();
//                        }
//                        else
//                        {
//                            OutputMessage("Something has went wrong.");
//                            AddPerson();
//                        }
//                    }
//                    catch (Exception)
//                    {
//                        OutputMessage("Something has went wrong. ");

//                        AddPerson();
//                    }

//                }

//                public void EditPerson()
//                {
//                    StartOption("Editing a user: ");
//                    //check if people in the system
//                    //print all
//                    //allow selection
//                    //validate selection
//                    //edit user, print message
//                    //reduce back to menu


//                    if (!isSystemEmpty())
//                    {
//                        PrintAllUsers();

//                        try
//                        {
//                            Console.WriteLine("Enter an index");
//                            int indexSelection = Convert.ToInt32(Console.ReadLine());
//                            indexSelection--;

//                            if (indexSelection >= 0 && indexSelection <= people.Count - 1)
//                            {

//                                try
//                                {
//                                    Person person = returnPerson();

//                                    if (person != null)
//                                    {
//                                        people[indexSelection] = person;
//                                        Console.WriteLine("Successfully edited a person.");

//                                        FinishOption();
//                                    }
//                                    else
//                                    {
//                                        OutputMessage("Something has went wrong.");
//                                        EditPerson();
//                                    }
//                                }
//                                catch (Exception)
//                                {
//                                    OutputMessage("Something has went wrong. ");

//                                    EditPerson();
//                                }
//                            }
//                            else
//                            {
//                                OutputMessage("Enter a valid index range. ");
//                                EditPerson();
//                            }
//                        }
//                        catch (Exception)
//                        {
//                            OutputMessage("Something went wrong. ");
//                            EditPerson();

//                        }
//                    }
//                    else
//                    {
//                        OutputMessage("");
//                    }

//                }
//                public void SearchPerson()
//                {
//                    StartOption("Searching users:");

//                    //check if people in system; (1111)
//                    //get name input(2222)
//                    //validate name(333333))))
//                    //loop and check for name(44444) pentru a cauta numele care lam pus(search)
//                    // output results(555555555)
//                    //return back to menu(6666666666)

//                    if (!isSystemEmpty())
//                    {
//                        Console.WriteLine("Enter a name: "); // (2)
//                        string nameInput = Console.ReadLine();

//                        bool bFound = false;

//                        if (!string.IsNullOrEmpty(nameInput))  // (3)
//                        {
//                            for (int i = 0; i < people.Count; i++)
//                            {
//                                if (people[i].name.ToLower().Contains(nameInput))
//                                {
//                                    Console.WriteLine(people[i].returnDetails());
//                                }
//                            }

//                            if (!bFound)
//                            {
//                                Console.WriteLine("No users found with that name.");
//                            }

//                            FinishOption();
//                        }
//                        else
//                        {
//                            OutputMessage("Please enter a name.");
//                            SearchPerson(); // o sa itereze din nou .
//                        }
//                    }
//                    else
//                    {
//                        OutputMessage("");
//                    }
//                }

//                public void RemovePerson()
//                {
//                    StartOption("Removing a user:");

//                    //check if people in system;
//                    //output list of users
//                    // intput selection
//                    //validation selection
//                    //print message
//                    //return menu

//                    if (!isSystemEmpty())
//                    {
//                        PrintAllUsers(); //2

//                        Console.WriteLine("Enter an index: ");
//                        int index = Convert.ToInt32(Console.ReadLine()); //3
//                        index--;
//                        if (index >= 0 && index <= people.Count - 1) // validation selection
//                        {
//                            people.RemoveAt(index);
//                            Console.WriteLine("Succesfully removed a person.");

//                            FinishOption();
//                        }
//                        else
//                        {
//                            OutputMessage("Enter a valid index inside the range");
//                            RemovePerson(); // pentru a chema din nou .
//                        }
//                    }
//                    else
//                    {
//                        OutputMessage("");
//                    }

//                }
//                public void FinishOption()
//                {
//                    Console.WriteLine(Environment.NewLine + "You have finished this option.Press <Enter> to return to the menu");
//                    Console.ReadLine();
//                    Console.Clear();
//                }

//                public void StartOption(string message)
//                {
//                    Console.Clear();
//                    Console.WriteLine(message + Environment.NewLine);
//                }
//                public void OutputMessage(string message)
//                {
//                    if (message.Equals(""))
//                    {
//                        Console.Write("Press <Enter> to return to the menu.");
//                    }
//                    else
//                    {
//                        Console.WriteLine(message + " Press <Enter> to try again");
//                    }
//                    Console.ReadLine();
//                    Console.Clear();
//                }
//                public void PrintAllUsers()
//                {
//                    for (int i = 0; i < people.Count; i++)
//                    {
//                        Console.WriteLine(i + 1 + ". " + people[i].returnDetails());
//                    }
//                }
//                public Person returnPerson()
//                {


//                    Console.WriteLine("Enter a name: ");
//                    string nameinput = Console.ReadLine();

//                    Console.WriteLine("Enter a age");

//                    int ageInput = Convert.ToInt32(Console.ReadLine());

//                    if (!string.IsNullOrEmpty(nameinput)) // daca nu este null sau empty
//                    {
//                        if (ageInput >= 0 && ageInput <= 150)
//                        {

//                            return new Person(nameinput, ageInput);

//                        }
//                        else
//                        {
//                            OutputMessage("Enter a sensible age.");

//                        }
//                    }
//                    else
//                    {
//                        OutputMessage("you didn't enter a name. ");

//                    }
//                    return null;
//                }
//                public bool isSystemEmpty()
//                {
//                    Console.Clear();
//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("There are no users in the system");
//                        return true; //pentru ca intradevar sistema este goala !
//                    }
//                    else
//                    {
//                        return false;
//                    }
//                }

//            }

//            static void Main(string[] args) // our meniu and our manager 5:31 time // pentru asta apropo trebuie alt class desigur !
//            {
//                Person person = new Person("Abe", 30);

//                Console.WriteLine(person.returnDetails());
//                person.setName("gHITA");// THIS USE JUST A TEST ON OUR CODE
//                    person.setAge(26);
//                Console.WriteLine(person.returnDetails());
//                new Manager();

//                Console.WriteLine("Good bye!");
//                Console.ReadLine();


//            }
//        }
//    }
//}

//namespace HelloWorld23123
//{
//    class Program1234321
//    {
//        class Person
//        {
//            public string name { get; private set; }
//            public int age { get; private set; }

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }

//            public string returnDetails()
//            {
//                return $"{name} - {age}";
//            }

//        }
//        class Manager
//        {
//            List<Person> people;

//            public Manager()
//            {
//                people = new List<Person>();
//                PrintMenu();
//            }

//            public void PrintMenu()
//            {
//                string[] menuOptions = new string[]
//                {
//                    "Print all users",
//                    "Add user",
//                    "Edit user",
//                    "Search user",
//                    "Remove user",
//                    "Exit"
//                };
//                Console.WriteLine("Welcome to my management system!" + Environment.NewLine);

//                for (int i = 0; i < menuOptions.Length; i++)
//                {
//                    Console.WriteLine(i + 1 + ". " + menuOptions[i]);
//                }



//                Console.Write("Enter your option: ");

//                bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);


//                if (tryParse)
//                {
//                    if (menuOption > menuOptions.Length)
//                    {
//                        Console.WriteLine("You entered too high number");
//                        Console.ReadLine();
//                        Console.Clear();
//                        PrintMenu();
//                    }
//                    if (menuOption == 1)
//                    {
//                        PrintAll();
//                    }
//                    else if (menuOption == 2)
//                    {
//                        AddPerson();
//                    }
//                    else if (menuOption == 3)
//                    {
//                        EditPerson();
//                    }
//                    else if (menuOption == 4)
//                    {
//                        SearchPeople();
//                    }
//                    else if (menuOption == 5)
//                    {
//                        RemovePerson();
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Incorrect menu choice.Press <Enter > to try again");
//                    Console.ReadLine();
//                    Console.Clear();
//                    PrintMenu();
//                }


//            }

//            public void PrintAll()
//            {
//                Console.Clear();
//                if (people.Count == 0)
//                {
//                    Console.WriteLine("There are no users in the system !" + Environment.NewLine);
//                    FinishOption();
//                }
//                else
//                {
//                    PrintAllUsers();
//                    FinishOption();
//                }
//            }
//            public void AddPerson()
//            {
//                Console.Clear();
//                Console.Write("Enter a name: ");
//                string inputName = Console.ReadLine();
//                if (string.IsNullOrEmpty(inputName))
//                {
//                    Console.WriteLine("Enter a sensbile Name.Press <Enter>");
//                    Console.ReadLine();
//                    Console.Clear();
//                    AddPerson();
//                }
//                if (inputName == "Exit")
//                {
//                    Console.Clear();
//                    PrintMenu();
//                }

//                Console.Write("Enter age: ");
//                bool tryParse = int.TryParse(Console.ReadLine(), out int inputAge);


//                if (tryParse)
//                {

//                    if (inputAge >= 0 && inputAge <= 150)
//                    {
//                        people.Add(new Person(inputName, inputAge));
//                        Console.WriteLine("Successfully added a person." + Environment.NewLine);
//                        FinishOption();
//                    }
//                    else
//                    {
//                        Console.WriteLine("Enter a sensbile age.Press <Enter>");
//                        Console.ReadLine();
//                        Console.Clear();
//                        AddPerson();

//                    }

//                }
//                else
//                {
//                    retryOption();
//                    AddPerson();
//                }

                


//            }
//            public void EditPerson()
//            {

//                Console.Clear();
//                PrintAllUsers();
//                Console.WriteLine();
//                Console.Write("Enter an index: ");
//                bool tryParse = int.TryParse(Console.ReadLine(), out int inputIndex);

//                if (tryParse)
//                {

//                    if (inputIndex >= 1 && inputIndex <= people.Count)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Adding a users:" + Environment.NewLine);
//                        Console.Write("Enter a name:" + Environment.NewLine);
//                        string enterName = Console.ReadLine();
//                        if (string.IsNullOrEmpty(enterName))
//                        {
//                            Console.WriteLine("Use a name please !");
//                            Console.ReadLine();
//                            Console.Clear();
//                            EditPerson();
//                        }
//                        Console.Write("Enter a age: ");
//                        int ageIndex = Convert.ToInt32(Console.ReadLine());
//                        people[inputIndex - 1] = new Person(enterName, ageIndex);
                        

//                        Console.WriteLine("Succesfully edit a person" + Environment.NewLine);

//                        FinishOption();

//                    }
//                    else
//                    {
//                        retryOption();
//                        Console.Clear();
//                        PrintMenu();
//                    }


//                }
//                else
//                {
//                    retryOption();
//                    Console.Clear();
//                    EditPerson();


//                }

//            }
//            public void SearchPeople()
//            {
//                Console.Clear();
//                Console.Write("Enter a name: ");
//                string readstring = Console.ReadLine();
//                if (string.IsNullOrEmpty(readstring))
//                {
//                    Console.WriteLine("Please Enter a name.Press<Enter> to try again!");
//                    Console.ReadLine();
//                    Console.Clear();
//                    SearchPeople();
//                }
//                else
//                {
//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("There si no users");
//                        Console.ReadLine();
//                        Console.Clear();
//                        PrintMenu();
//                    }
//                    else
//                    { 
//                        for (int i = 0; i < people.Count; i++)
//                        {
//                            if (people[i].name.Contains(readstring))
//                            {
//                                Console.WriteLine(i + 1 + ". " + people[i].returnDetails());
//                            }
//                        }
//                        FinishOption();

//                    }
//                }


//            }
//            public void RemovePerson()
//            {
//                Console.WriteLine("Remove");
//            }
//            public void retryOption()
//            {
//                Console.WriteLine("Something has went wrong.Press <Enter> to retry");
//                Console.ReadLine();
//            }

//            public void FinishOption()
//            {
//                Console.WriteLine("You have finished this Option.Press <Enter> to return to the menu");
//                Console.ReadLine();
//                Console.Clear();
//                PrintMenu();
//            }
//            public void PrintAllUsers()
//            {
//                for (int i = 0; i < people.Count; i++)
//                {
//                    Console.WriteLine(i + 1 + ". " + people[i].returnDetails());

//                }
//            }
//        }

//        public static void Main(string[] args)
//        {
//            new Manager();
//        }
//    }
//}







































