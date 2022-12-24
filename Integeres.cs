//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine(test(new[] { 5, 5, 1, 5, 20 })); // false
//            //Console.WriteLine(test(new[] { 5, 5, 1, 5, 5 }));
//            //Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
//            //Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
//            Console.WriteLine(test(new[] {  25 , 7, 10 }));
//        }
//        static bool test(int[] numbers)
//        {
//            for (int i = 0; i < numbers.Length - 1; i++)
//            {
//                if (numbers[i + 1] < numbers[i]) return false;
//            }

//            return true;
//        }

//    }
//}
//using System;
//public class Exercise3
//{
//    public static void Main()
//    {
//        string username, password;
//        int ctr = 0, dd = 0;
//        Console.Write("\n\nCheck username and password :\n");
//        Console.Write("N.B. : Defaule username and password is : username and password\n");
//        Console.Write("---------------------------------\n");
//        do
//        {
//            Console.Write("Input a username: ");
//            username = Console.ReadLine();

//            Console.Write("Input a password: ");
//            password = Console.ReadLine();
//            if (username == "username" && password == "password")
//            {
//                dd = 1;
//                ctr = 3;
//            }

//            else
//            {
//                dd = 0;
//                ctr++;
//            }
//        }
//        while ((username != "username" || password != "password")
//                && (ctr != 3));
//        if (dd == 0)
//        {
//            Console.Write("\nLogin attemp more than three times. Try later!\n\n");
//        }
//        else
//        if (dd == 1)
//        {
//            Console.Write("\nPassword entered successfull!\n\n");
//        }
//    }
//}




//cars[i] = monday[j];  // form mondaypozitionj you will save in cars at position[i]
//cars[i] += monday[j];

//cars[i] = cars[i] + monday[j]  we are taking information to cars[i] add to monday[j] and you store again to cars[i] and  that mean that you will get two if is string you will get two string if is int you can get 10 + 5 = 15;

//Console.WriteLine("Input: ");
//string input = Console.ReadLine();

//Console.WriteLine("Amount: ");
//int amount = int.Parse(Console.ReadLine());//4

//int amountOfLines = amount; // 4
//for (int i = 0; i < amountOfLines; i++)
//{
//    for (int x = amount; x > 0; x--)
//    {
//        Console.Write($"{input} ");
//    }
//    amount--;
//    Console.WriteLine("\n");
//}
//Console.ReadKey();
// i = 5  ; i >=0; i-- 5, 4, 3, 2, 1, ,0
// 

//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Text;
//namespace victor
//{
//    class dog
//    {
//        public static void Main(string[] args)
//        {

//            int n = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < n; i++)// primul forlo lopp i arata liniile cate linii avem 
//            { 
//                var line = "";
//                for (int j = 0; j < n * 2; j++)  // asta este lungimea liniei 
//                {
//                    if (j < n - i || j > n + i) // n este 10 i este indexul nui 0 dar ii diodata 1  tipa 10 - 1 este 9 noi adaugam un loc liber  si la fel facem j < n + 1  j ii mai mare cand ajunge la steluta si merge la dreapta apoi i ii mai mare .
//                                                // j reprezinta lungimea  * este caracte dar j reprezinta lungimea . si lunimgea liniei noi io dam inmultind
//                    {//// si steluta din mijloc trebuie sa fie al 10 element cand numeri din stanga sau din dreapta e asa pentru ca n = 10
//                        line += "+"; // si totodata n = 2 - 1 dex linia 4 * 2 - 1 = 7 steulte sau dex 1 linie 1 * 1 = 2 - 1 este 1.
//                    }
//                    else
//                    {
//                        line += "*";
                       
//                    }
                  
//                }
//                Console.WriteLine(line);
//            }


//            for (int i = n; i >= 0; i--)//ultima i este 10.
//            {
//                var line = "";
//                for (int j = 0; j <= n * 2; j++)
//                {
//                    if (j < n - i || j > n + i)
//                    {
//                        line += "*";
//                    }
//                    else
//                    {
//                        line += "*";
//                    }
//                }
//                Console.WriteLine(line);
//            }



//        }
//    }
//}