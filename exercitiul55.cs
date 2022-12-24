//using System;
//using System.Collections.Generic;
//using System.Reflection.Metadata.Ecma335;

//namespace PersonalManager
//{
//    class Program123321
//    {
//        class Person
//        {
//            public string name { get; protected set; } // fiindca public sa luam get si set pentru ca dorim sa ail avem doar din aceasta class
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
//                    people = new List<Person>
//                    {
//                        new Person("Aba", 23),
//                        new Person("Ghita", 26)
//                    };
//                    printMenu();
//                }

//                public void printMenu()
//                {
//                    Console.WriteLine("Welcome to my management system");
//                    Console.WriteLine("1. Print all users");
//                    Console.WriteLine("2. Add user");
//                    Console.WriteLine("3. Edit user");
//                    Console.WriteLine("4. Search user");  // sa scriem if statem pentru  ca sa stim ca o fost chemate corecte !
//                    Console.WriteLine("5. Remove user");
//                    Console.WriteLine("6. Exit");

//                    Console.Write("Enter your menu option: ");

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

//                        OutputMessage("Incorrect menu choice.: ");
//                        printMenu();
//                    }

//                }
//                public void PrintAll()
//                {
//                    StartOption("Printing all users");

//                    if (people.Count == 0)
//                        Console.WriteLine("There are no users in the system, use option 1 to create a user");
//                    else
//                        PrintAllUsers();
//                    FinishOption();
//                }
//                public void AddPerson()
//                {
//                    StartOption("Adding a user:");


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
//                            OutputMessage("Someting has went wrong.");
//                            AddPerson();
//                        }
//                    }
//                    catch (Exception)
//                    {
//                        OutputMessage("Something has went wrong.");
//                        AddPerson();
//                    }
//                }
//                public void EditPerson()
//                {

//                    StartOption("Editing a user:"); // check if people in the system; print all ; allow selection ; validate; selection ; remove user,, print message , return back to menu

//                    if (people.Count == 0)
//                    {
//                        Console.WriteLine("No users to edit. Use the menu to add a user.");
//                    }
//                    else
//                    {
//                        PrintAllUsers();

//                        try
//                        {
//                            Console.WriteLine("Enter an index: ");
//                            int indexxSelection = Convert.ToInt32(Console.ReadLine());
//                            indexxSelection--;

//                            if (indexxSelection >= 0 && indexxSelection <= people.Count - 1)
//                            {
//                                try
//                                {

//                                    Person person = returnPerson();

//                                    if (person != null)
//                                    {
//                                        people[indexxSelection] = person;
//                                        Console.WriteLine("Successfully added a person.");
//                                        FinishOption();
//                                    }
//                                    else
//                                    {
//                                        OutputMessage("Someting has went wrong.");
//                                        EditPerson();
//                                    }
//                                }
//                                catch (Exception)
//                                {
//                                    OutputMessage("Something has went wrong.");
//                                    EditPerson();
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("Enter a valid index range.");
//                                EditPerson();
//                            }
//                        }
//                        catch (Exception)
//                        {

//                            OutputMessage("Something went wrong.");
//                            EditPerson();
//                        }
//                        Console.WriteLine("Enter an index: ");
//                        int indexSelection = Convert.ToInt32(Console.ReadLine());
//                        EditPerson();
//                    }

//                }
//                public void SearchPerson()
//                {
//                    StartOption("Searching users:");

//                    FinishOption();
//                }
//                public void RemovePerson()
//                {
//                    StartOption("Removing a user:");

//                    FinishOption();
//                }
//                public void FinishOption()
//                {
//                    Console.WriteLine(Environment.NewLine + "You have finished this option. Press <Enter> to return to the menu.");
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

//                    Console.WriteLine(message + " Press <Enter> to try again.");
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


//                        Console.WriteLine("Enter a name: ");
//                        string nameInput = Console.ReadLine();

//                        Console.Write("Enter a age: ");
//                        int ageInput = Convert.ToInt32(Console.ReadLine());

//                        if (!string.IsNullOrEmpty(nameInput))
//                        {
//                            if (ageInput >= 0 && ageInput <= 150)
//                            {
//                            return  new Person(nameInput, ageInput);
//                            }
//                            else
//                            {
//                                OutputMessage("Enter a sensible age.");
//                            }
//                        }
//                        else
//                        {
//                            OutputMessage("You didn't enter a name.");
//                        }

//                    return null;
//                }
//            }
//            static void Main(string[] args)
//            {
//                Manager manager = new Manager();
//                Console.ReadLine();
//            }
//        }
//    }
//}