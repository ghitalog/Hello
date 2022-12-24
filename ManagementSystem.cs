//Differite metode cum putem sa facem putin altfel !
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
//                     new Person("Aba", 23),
//                      new Person("Gheorghe", 26)
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
//                    check if people in the system
//                    print all
//                    allow selection
//                    validate selection
//                    edit user, print message
//                    reduce back to menu


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

//                    check if people in system; (1111)
//                    get name input(2222)
//                    validate name(333333))))
//                    loop and check for name(44444) pentru a cauta numele care lam pus(search)
//                     output results(555555555)
//                    return back to menu(6666666666)

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

//                    check if people in system;
//                    output list of users
//                     intput selection
//                    validation selection
//                    print message
//                    return menu

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
//                person.setName("gHITA"); THIS USE JUST A TEST ON OUR CODE
//                    person.setAge(26);
//                Console.WriteLine(person.returnDetails());
//                new Manager();

//                Console.WriteLine("Good bye!");
//                Console.ReadLine();


//            }
//        }
//    }
//}



































////management system is fully complit !
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld23123
//{

//    internal class PrograM                                      //almost finished /part2
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
//                        new Person("Aba", 23),
//                        new Person("Gheorghe", 26)
//                    };
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management system!" + Environment.NewLine);
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

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

//                        if (menuOption >= 1 && menuOption <= 5)
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
//                    StartOption("Print all users:");

//                    if (people.Count == 0)

//                        Console.WriteLine("There are no users in the System, use option 1 to create a user ");
//                    PrintAllUsers();


//                    FinishOption();
//                    //int i = 0;
//                    /*
//                    people.ForEach(delegate (Person person)
//                    {
//                        i++;
//                        Console.WriteLine(i + ". " + person.returnDetails());
//                    });*/
//                    // people.ForEach(person =>      //6:39 time
//                    // {
//                    //   i++;
//                    // Console.WriteLine(i + ". " + person.returnDetails());
//                    // });
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


//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("No users to edit. Use the menu to add a user");
//                    }
//                    else
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

//                }
//                public void SearchPerson()
//                {
//                    StartOption("Searching users:");

//                    //check if people in system;(1111)
//                    //get name input          (2222)
//                    //validate name (333333))))
//                    //loop and check for name (44444) pentru a cauta numele care lam pus (search)
//                    // output results (555555555)
//                    //return back to menu(6666666666)

//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("There are no users in the system"); // (1)
//                    }
//                    else
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

//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("There are no users in the system.");
//                    }
//                    else
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
//                    Console.WriteLine(message + "Press <Enter> to try again");
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

//            }

//            static void Main(string[] args) // our meniu and our manager 5:31 time // pentru asta apropo trebuie alt class desigur !
//            {
//                //    Person person = new Person("Abe", 30);

//                //    Console.WriteLine(person.returnDetails());
//                //    person.setName("gHITA");                           THIS USE JUST A TEST ON OUR CODE
//                //    person.setAge(26);
//                //    Console.WriteLine(person.returnDetails());
//                Manager manager = new Manager();

//                Console.WriteLine("Good bye!");
//                Console.ReadLine();


//            }
//        }
//    }
//}











































//                              PART 3 AND A BIT OF 4
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
//                        new Person("Aba", 23),
//                        new Person("Gheorghe", 26)
//                    };
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management system!" + Environment.NewLine);
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

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

//                        printMenu();
//                    }
//                    else
//                    {
//                        OutputMessage("Incorrect menu choice.");

//                        printMenu();
//                    }



//                }
//                public void PrintAll()
//                {
//                    StartOption("Print all users:");

//                   if (people.Count == 0)

//                        Console.WriteLine("There are no users in the System, use option 1 to create a user ");
//                    PrintAllUsers();


//                        FinishOption();
//                    //int i = 0;
//                    /*
//                    people.ForEach(delegate (Person person)
//                    {
//                        i++;
//                        Console.WriteLine(i + ". " + person.returnDetails());
//                    });*/
//                    // people.ForEach(person =>      //6:39 time
//                    // {
//                    //   i++;
//                    // Console.WriteLine(i + ". " + person.returnDetails());
//                    // });
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


//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("No users to edit. Use the menu to add a user");
//                    }
//                    else
//                    {
//                        PrintAllUsers();

//                        try
//                        {
//                            Console.WriteLine("Enter an index");
//                            int indexSelection = Convert.ToInt32(Console.ReadLine());
//                            indexSelection--;

//                            if (indexSelection >= 0 && indexSelection <= people.Count -1)
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

//                }
//                public void SearchPerson()
//                {
//                    StartOption("Searching users:");

//                    //check if people in system;(1111)
//                    //get name input          (2222)
//                    //validate name (333333))))
//                    //loop and check for name (44444) pentru a cauta numele care lam pus (search)
//                    // output results (555555555)
//                    //return back to menu(6666666666)

//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("There are no users in the system"); // (1)
//                    }
//                    else
//                    {
//                        Console.WriteLine("Enter a name: "); // (2)
//                        string nameInput = Console.ReadLine();

//                       bool bFound = false;

//                        if (!string.IsNullOrEmpty(nameInput))  // (3)
//                        {
//                            for (int i = 0; i < people.Count; i++)
//                            {
//                                if (people[i].name.ToLower().Contains(nameInput))
//                                {
//                                    Console.WriteLine(people[i].returnDetails());
//                                }
//                            }

//                           if (!bFound)
//                           {
//                                Console.WriteLine("No user found with that name.");
//                           }

//                            FinishOption();
//                        }
//                        else
//                        {
//                            OutputMessage("Please enter a name.");
//                            SearchPerson(); // o sa itereze din nou .
//                        }
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

//                    FinishOption();
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
//                    Console.WriteLine(message + "Press <Enter> to try again");
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
//                    }

//            }

//            static void Main(string[] args) // our meniu and our manager 5:31 time // pentru asta apropo trebuie alt class desigur !
//            {
//                //    Person person = new Person("Abe", 30);

//                //    Console.WriteLine(person.returnDetails());
//                //    person.setName("gHITA");                           THIS USE JUST A TEST ON OUR CODE
//                //    person.setAge(26);
//                //    Console.WriteLine(person.returnDetails());
//                Manager manager = new Manager();

//                Console.ReadLine();


//            }
//        }
//    }
//}

































































































































































////FirstPartOF HOW TO MAKE A MANAGEMENT SYSTEM IN C# 1/4 ///////////////////////////////////////////////////////////

//using System;
//using System.Collections.Generic;
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
//                    people = new List<Person>();
//                    printMenu();
//                }
//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management system!" + Environment.NewLine);
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

//                    Console.Write("Enter your menu option: ");
//                    bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

//                    if (tryParse)
//                    {
//                        Console.WriteLine(menuOption);

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
//                        Console.WriteLine("Incorrect menu choice.");
//                        Console.WriteLine("Press <Enter> to try again.");
//                        Console.ReadLine();
//                        Console.Clear();
//                        printMenu();
//                    }



//                }
//                public void PrintAll()
//                {
//                    Console.WriteLine("Print");
//                }

//                public void AddPerson()
//                {
//                    Console.WriteLine("Add");
//                }

//                public void EditPerson()
//                {
//                    Console.WriteLine("Edit");
//                }
//                public void SearchPerson()
//                {
//                    Console.WriteLine("Search");
//                }

//                public void RemovePerson()
//                {
//                    Console.WriteLine("Remove");
//                }
//            }

//            static void Main(string[] args) // our meniu and our manager 5:31 time // pentru asta apropo trebuie alt class desigur !
//            {
//                //    Person person = new Person("Abe", 30);

//                //    Console.WriteLine(person.returnDetails());
//                //    person.setName("gHITA");                           THIS USE JUST A TEST ON OUR CODE
//                //    person.setAge(26);
//                //    Console.WriteLine(person.returnDetails());
//                Manager manager = new Manager();

//                Console.ReadLine();


//            }
//        }
//    }
//}
///////////////////////////////
////









