//using System;
//using System.Diagnostics.CodeAnalysis;
//using System.Net.Http.Headers;

//public class Exercise
//{
//    public static int array_adjacent_elements_product(int[] input_array)
//    {
//        int array_index = 0;
//        int product = input_array[array_index] * input_array[array_index + 1]; // 6

//        array_index++; // este ++ pentru ca calculam urmatorul product / adica pe 2 il lasam in spate si mergem la 4.
//        while (array_index + 1 < input_array.Length) // adaugam +1 la array_index sa miste la urmatorul index / dar sa fie mai mic ca lungimea sa nu daie eraora !
//        { // product il lasam sa faca comparatie unu cu altul 
//            product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
//                       (input_array[array_index] * input_array[array_index + 1]) :
//                        product;
//            array_index++;
//        }

//        return product;
//    }                                                           //product  
//    public static void Main()                                    //Length este 6 
//    {
//        Console.WriteLine(array_adjacent_elements_product(new int[] { 9, 4, 2, 6, 9, 3 }));//2 * 4 = 8 
//        Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
//        Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
//        Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 4, 0 }) == 12);
//    }
//}

//using System;
//using System.Diagnostics.CodeAnalysis;
//using System.Net.Http.Headers;
//using System.Text.RegularExpressions;



//using System;
//using System.Text.RegularExpressions;

//namespace exercises
//{
//    class Program23123
//    {
//        static void Main(string[] args)
//        {
//            string text;
//            text = "Python";
//            Console.WriteLine("Orginal string: " + text);
//            Console.WriteLine("After removing all the vowels from the said string: " + test(text));
//            text = "C Sharp";
//            Console.WriteLine("\nOrginal string: " + text);
//            Console.WriteLine("After removing all the vowels from the said string: " + test(text));
//            text = "JavaScript";
//            Console.WriteLine("\nOrginal string: " + text);
//            Console.WriteLine("After removing all the vowels from the said string: " + test(text));
//            Console.WriteLine(text);
//        }

//        public static string test(string text)
//        {

//            //return new Regex(@"[aeiouAEIOU]").Replace(text, "");
//            // return Regex.Replace(text, @"[aeiouAEIOU]", "");
//            return text.Select((x, i) => i).Where(i => char.ToLower(text[i]).ToArray());
//        }
//    }
//}


//Orginal string: Python
//               1 2 3 4 5
//Indices of all lower case letters of the said string:
//                0 1 2 3 4 5 6  7 8 9
//Orginal string: J a v a S c r  i p t

//Indices of all lower case letters of the said string:
//1 2 3 5 6 7 8 9


//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml;

//namespace exercises
//{
//    class Program23123
//    {
//        static void Main(string[] args)
//        {

//            string text = "JavaScript";
//            Console.WriteLine("\nOrginal string: " + text);
//            var result = test(text);
//            Console.WriteLine("\nIndices of all lower case letters of the said string:");
//            foreach (var item in result)
//            {
//                Console.Write(item.ToString() + " ");
//            }
//        }

//        public static char[] test(string str)
//        {
//            //return str.Select((x, i) => i).Where(i => char.IsLower(str[i])).ToArray();
//           // return str.Select((x, i) => (x, i)).Where((x, i) => i % 2 == 0).Select((x, i) => x.x).ToArray();
//           return str.Select((x, i) => (x, i)).Where((x, i) => i % 2 == 0).Select(x => x.x).ToArray();
//            //return str.Where((x, i) => i % 2 == 0).ToArray();


//        }
//    }
//}









//class Program2233
//{
//    static void Main(string[] args)
//    {                                                     //PH // 1 = P  :  2 = H
//        Console.WriteLine(test("Python"));    // P + 2 == PHY
//        Console.WriteLine(test("JavaScript"));//Ja
//        Console.WriteLine(test("HTML"));  //HT
//        Console.ReadLine();
//    }

//    public static string test(string str1)
//    {
//        var result = string.Empty;
//        for (var i = 0; i < str1.Length; i += 4)
//        {
//            var c = i + 2; // 

//            var n = 0;
//            n = n + c > str1.Length ? 1 : 2;
//            result = result + str1.Substring(i, n);
//        }
//        return result;
//    }
//}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld
//{
//    internal class @switch
//    {
//        class dog
//        {
//            public static void Main()
//            {
//                Console.WriteLine(CleanString("JavaScript"));
//            }
//            public static string CleanString(string str)
//            {                                                //1 2 3 4 5 6 7 8  9 10   Length
//                                                             // 0 1 2 3 4 5 6  7 8 9    index
//                                                             //  string input = "J a v a S c r  i p t";
//                var result = "";
//                if (str.Length <= 2)
//                {
//                    return str;
//                }
//                for (int i = 0; i < str.Length; i++)     // in al doilea iterare sau al doilea caz for se incepe de la dreapta  insea ca i++
//                {
//                    if (i < str.Length)
//                    {
//                        result += str[i];          // result = result + str[i]
//                    }
//                    if (i + 1 < str.Length)            // inseamna 0 + 1 cand i este 0 
//                    {
//                        result += str[i + 1];               // dex cum aicea daca am pus [i + 1] asta nu inseamna ca i este 1 el tot zero ramane.//  i + 1 insaemna a. 
//                        i += 3;
//                    }
//                }      // i indexul o sa fie defiecare data o sa fie 0  sa se inceapa cu 0 pana la ultimul bloc de la for , el poate sa se inceapa de la 1 numai daca punem i = 1 sus in for.
//                return result;
//            }
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld
//{
//    internal class @switch
//    {
//        class dog
//        {
//            public static void Main()
//            {
//                Console.WriteLine(CleanString("JavaScript"));// 0 1 2 3 4 5 6  7 8 9    index   //Ja sc pt
//            }                                                // J a v a S C r  i P T
//            public static string CleanString(string str)
//            {                                                
//                var result = "";
//                if (str.Length <= 2) return str;
//                for (int i = 0; i < str.Length; i++)
//                {
//                    if (i < str.Length)
//                    {
//                        result = result + str[i];
//                    }
//                    if(i + 1 < str.Length)
//                    {
//                        result += str[i + 1];
//                        i += 3;
//                    }


//                }
//                return result;

//            }
//        }
//    }
//}





//using System;
//using System.Security.Cryptography.X509Certificates;

//public class Example55
//{
//    public static int adjacent_Elements_Product(int[] input_Array)
//    {
//        int index = 0;
//        int max = input_Array[index] * input_Array[index + 1];

//        //index++;
//        for (int i = 1; i <= input_Array.Length - 2; i++)
//        {
//            max = Math.Max(max, input_Array[index] * input_Array[index + 1]);

//            index++;
//        }
//        return max;
//    }
//    public static void Main()
//    {
//        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, -3, 4, -5, 1 })); //-3
//        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 })); //20
//        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 }));//10
//        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 }));//0
//        Console.WriteLine(adjacent_Elements_Product(new int[] { 2, 5, 0, 3, 5 }));//15
//    }


//}



//    return str1.Split(uc, lc).Length - 1;
//            //E este un baton si splitul ce face ?? Tu ai gasit baton cu numele (e) splitul il face in 2 , si apoi din jumatea celalate mai cauta ce o mai ramas
//            // ADICA din LUNGIme scade - 1 fiindca nul e in plus . 

//using System;
//public class Example55
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Original string: PHP");
//        Console.WriteLine("Test for consecutive similar letters! " + test("PHP"));
//        Console.WriteLine("Original string: PHHP");
//        Console.WriteLine("Test for consecutive similar letters! " + test("PHHP"));
//        Console.WriteLine("Original string: PHPP");
//        Console.WriteLine("Test for consecutive similar letters! " + test("PHPP"));
//        Console.WriteLine("Original string: PPHP");                  //      
//        Console.WriteLine("Test for consecutive similar letters! " + test("PPHP"));
//    }
//    public static bool test(string text)
//    {
//       for (int i = 0; i < text.Length -1; i++)
//        {
//            if (text[i] == text[i + 1]) return true;
//        }
//        return false;
//    }

//}



//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace victor
//{
//    class dog
//    {
//        public static void Main(string[] args)
//        {
//            int[,] arr = { {17, 2, 9, 10 },
//                           { 23, 6, 0, 42 },
//                           { 68, 7, 3, 15 },
//                           { 2, 4, 1, 11 } };
//            for (int i = 0; i < arr.GetLength(0); i++)          // este 17 , 2, 9 , 10
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)        // j este 23
//                {
//                    arr[i, j] = (i == arr.GetLength(0) - 1 - j) ? 1 : 0;
//                    Console.Write($"{arr[i, j]} ");
//                }
//                Console.WriteLine(Environment.NewLine);

//            }

//        }
//    }
//}








//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//namespace victor
//{
//    class dog
//    {
//        public static void Main(string[] args)
//        {
//            int[,] arr = { { 17, 2, 9, 10 },   // i este linia si j este column
//                           { 23, 6, 0, 42 },
//                           { 68, 7, 3, 15 },
//                           { 22, 4, 1, 11 } };
//            int first = GetSumOfDiagonalFromLeftToRight(arr);
//            int second = GetSumOfDiagonalFromRightToLeft(arr);

//            Console.WriteLine(first);
//            Console.WriteLine(second);
//            Console.WriteLine($"{first + second}"); // intelege ca ii integer .
//        }
//        public static int GetSumOfDiagonalFromLeftToRight(int[,] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    if (i == j)
//                    {
//                        sum += arr[i, j];
//                    }
//                }

//            }
//            return sum;
//        }


//        public static int GetSumOfDiagonalFromRightToLeft(int[,] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                sum += arr[i, arr.GetLength(1) - 1 - i];


//            }
//            return sum;
//        }


//        public static int Test(int[,] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.GetLength(0); i++) // ESTE 0 FINDCA SUNT Linii
//            {
//                sum += arr[i, i];
//            }
//            return sum;
//        }

//    }
//}





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

//            for (int i = 0; i < n; i++)      //i sunt linele in jos   j sunt stelutile si locurile libere si liniile 
//            {
//                var line = "";
//                for (int j = 0; j < n * 2; j++)
//                {
//                    if (j < n - i || j > n + i)
//                    {
//                        line += " ";
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
//                        line += " "; // si totodata n = 2 - 1 dex linia 4 * 2 - 1 = 7 steulte sau dex 1 linie 1 * 1 = 2 - 1 este 1.
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
//                        line += " "; // si totodata n = 2 - 1 dex linia 4 * 2 - 1 = 7 steulte sau dex 1 linie 1 * 1 = 2 - 1 este 1.
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
//                        line += " ";
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




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloWorld
//{
//    internal class @switch
//    {
//        class dog
//        {
//            public static void Main()
//            {
//                Console.WriteLine(CleanString("JavaScript"));
//            }
//            public static string CleanString(string str)
//            {                                                //1 2 3 4 5 6 7 8  9 10   Length
//                                                             //0 1 2 3 4 5 6  7 8 9    index
//                                                             //string input =                              "J a v a S c r  i p t";   JaScpt
//                var result = "";                             //Result = JaScpt
//                if (str.Length <= 2)
//                {
//                    return str;
//                }
//                for (int i = 0; i < str.Length; i++)     // in al doilea iterare sau al doilea caz for se incepe de la dreapta  insea ca i++

//                {
//                    if (i < str.Length)
//                    {
//                        result += str[i];          // result = result + str[i]
//                    }
//                    if (i + 1 < str.Length)            // inseamna 0 + 1 cand i este 0    
//                    {
//                        result += str[i + 1];    //result = result + str[i + 1]           // dex cum aicea daca am pus [i + 1] asta nu inseamna ca i este 1 el tot zero ramane.//  i + 1 insaemna a. 
//                        i += 3; // i = i + 3  // primaoara se primeste J a v a si apoi ++ S si a 2 tura se porneste de unde sa oprit  + S c r i ++ 
//                    }
//                }      // i indexul o sa fie defiecare data o sa fie 0  sa se inceapa cu 0 pana la ultimul bloc de la for , el poate sa se inceapa de la 1 numai daca punem i = 1 sus in for.
//                return result;
//            }
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Number_Guessing
//{
//    class Program3123
//    {

//        static void Main(string[] args)
//        {
//            int[] item1 = ConcatTwoArray(new[] { 8, 1, 5, 7 }, new[] { 9, 11, 13 });
//            Console.WriteLine("New array (el trebuie sa fie string mai intai ");

//            foreach (int i in item1)
//            {
//                Console.Write(i.ToString() + " ");
//            }
//        }
//        public static int[] ConcatTwoArray(int[] x, int[] y)
//        {
//            {
//                int[] combined = new int[x.Length + y.Length];
//                Array.Copy(x, combined, x.Length); // de unde , unde , si cate elemente sa copie 
//                Array.Copy(y, 0, combined, x.Length, y.Length);  // 0 incepe de la care index si de unde adica y , apoi unde in combine , apoi de la care index din combine sa inceapa // cate din y sa copie in combine. 
//                return combined;
//            }
//        }
//    }
//}






//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Number_Guessing
//{
//    class Program3123
//    {

//        static void Main(string[] args)
//        {
//            int[] item1 = takingTheMiddleTwoNumbersOFLengtEven(new[] { 1, 5, 7, 2, 3, 6 });
//            Console.WriteLine("New array (el trebuie sa fie string mai intai ");

//            foreach (int i in item1)
//            {
//                Console.Write(i.ToString() + " ");
//            }
//        }
//        public static int[] takingTheMiddleTwoNumbersOFLengtEven(int[] arr)
//        {
//            {
//                int midpointIndex1 = arr.Length / 2 - 1;
//                int midpointIndex2 = arr.Length / 2;
//                //return new int[] { midpointIndex1, midpointIndex2};
//                int midelement1 = arr[midpointIndex1];
//                int midelement2 = arr[midpointIndex2];

//                int[] newArr = new int[2];// adica lungimea maximam este 2 , el aloca memoria pentru 2 elemente !

//                newArr[0] = midelement1;
//                newArr[1] = midelement2;

//                return newArr;

//            }
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calc
//{
//    internal class Calculator132
//    {
//        class Calc
//        {
//            static void Main(string[] args)
//            {
//                int[] item = ReplaceMax(new[] { 10, 20, 30, 40, 50, 60, 70 });
//                Console.Write("new array from biggestNumbe: ");

//                foreach (int i in item)
//                {
//                    Console.Write(i.ToString() + " ");
//                }
//                //Array.Reverse(item);
//                //Console.Write(String.Join(',', item));
//            }
//            public static int[] ReplaceMax(int[] arr)
//            {
//                int max = arr.Max();
//                int length = arr.Length;
//                int i = 0;

//                while (length > 0)
//                {
//                    arr[i] = max;
//                    i++;
//                    length--;
//                }
//                return arr;
//            }


//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calc
//{
//    internal class Calculator132
//    {
//        class Calc
//        {
//            static void Main(string[] args)
//            {
//                int[] item = containingTheMiddleEelements(new[] { 10, 20, 30, 40, 50 }, new[] { 10, -220, -30, 40, 30 });
//                //int[] item2 = containingTheMiddleEelements(new[] { 10, 20, 30, 40, 50});
//                Console.Write("new array from biggestNumbe: ");

//                foreach (int i in item)
//                {
//                    Console.Write(i.ToString() + " ");
//                }
//                //Array.Reverse(item);
//                //Console.Write(String.Join(',', item));
//            }
//            static public int[] containingTheMiddleEelements(int[] arr1, int[] arr2)
//            {
//                int[] newArr = { 1, 2 };
//                int middleIndexofarr1 = (arr1.Length - 1) / 2; // fa mai intaii matimatica calcul . 5 - 1 = 4 / 2 = 2 adica este lungimea 2 dar indexum 3 si este equal cu 30 indexul.  .
//                int middleElementofarr1 = arr1[middleIndexofarr1]; // 30

//                int middleIndexofarr2 = (arr2.Length - 1) / 2; // la fel lungimea ii 5  - 1 % 2 = 2 indexul o sa fie - 30.
//                int middleElementofarr2 = arr1[middleIndexofarr2]; //- 30

//                newArr[0] = arr1[middleIndexofarr1];
//                newArr[1] = arr2[middleIndexofarr2];

//                return newArr;
//            }


//        }
//    }
//}



//using System;
//namespace exercises
//{
//    class Program
//    {
//        //Exercise-122 with Solution
//        static void Main(string[] args)
//        {
//            Console.WriteLine(test(new[] { 3, 5, 1, 3, 7 }));
//            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
//            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
//            Console.WriteLine(test(new[] { 2, 4, 5, 6 }));
//        }
//        static bool test(int[] numbers)
//        {
//            int tot_odd = 0, tot_even = 0;

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (tot_odd < 2 && tot_even < 2) // el a pus 2 aicea special ca cand ajunge la 2 nu are sens sa caluceze mai deeparte pentru conditia a fost satisfacuta.
//                {
//                    if (numbers[i] % 2 == 0)
//                    {
//                        tot_even++;//EL CALUCEAZA cate la rand sunt daca sunt 2 la rand inseamna ca nu mai face if si il pune pe true;
//                        tot_odd = 0;
//                    }
//                    else
//                    {
//                        tot_odd++; // la fel calculeaza cate odd sunt si daca sunt 2 .
//                        tot_even = 0;
//                    }
//                }
//            }
//            return tot_odd == 2 || tot_even == 2; // si se compara cu 2.

//        }
//    }
//}



//using System;
//namespace exercises
//{
//    class Program         ////////////////// 124 
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(test(new[] { 3, 5, 5, 3, 7 }));
//            Console.WriteLine(test(new[] { 3, 5, 5, 4, 1, 5, 7 }));
//            Console.WriteLine(test(new[] { 3, 5, 5, 5, 5, 5 }));
//            Console.WriteLine(test(new[] { 2, 4, 5, 5, 6, 7, 5 }));
//        }
//        static bool test(int[] numbers)
//        {
//            int arr_len = numbers.Length;
//            bool flag = true;

//            for (int i = 0; i < arr_len; i++)
//            {
//                if (numbers[i] == 5)
//                {                          // aicea ce face el doar verifica daca este 5 si urmatorul tot e 5 si atat nu verifica alte numere
//                    if ((i > 0 && numbers[i - 1] == 5) || (i < arr_len - 1 && numbers[i + 1] == 5)) flag = true; // i > 0 si i - 1 este 5 sau invers ii true daca nu ii false
//                    else if (i == arr_len - 1) flag = false; // daca i ajunge pana la indexum  - 1 inseamna ca ii false el nu a gasit nimic !
//                    else return false;
//                }
//            }
//            return flag;
//        }
//    }
//}


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


/////////////////////////////////////    125 Execritiul 
//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 2));
//            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 3));
//            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));

//        }

//        static bool test(int[] numbers, int len)
//        {
//            int arra_size = numbers.Length;

//            for (int i = 0; i < len; i++)
//            {                                  ////  Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));
//                if (numbers[i] != numbers[arra_size - len + i])    /// primul index este 3 si apoi array_size - len este 7 - 3 = 4 apoi indexul 0 care este 3 + 4 pasi ajunge la celalat 3..  
//                {          // si arra_size - len + i  = + i este pentru ca cand 3 trece la 7 partacea lalta tot sa treaca cu o pozitie 3 la 7 si asa ele se compara unu pe alta.
//                    return false;
//                }
//            }

//            return true;
//        }
//    }
//}

//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] item = test(new[] { 10, 20, -30, -40, 50 });
//            Console.Write("New array: ");
//            foreach (var i in item)
//            {
//                Console.Write(i.ToString() + " ");
//            }
//        }
//        static int[] test(int[] numbers)
//        {
//            int size = numbers.Length;
//            int[] shiftNums = new int[size];
//
//            for (int i = 0; i < size; i++)
//            {
//                shiftNums[i] = numbers[(i + 1) % size];  /// numbers[(i + 1) % size] cea inseamna ?? mai intaii uite din puncte de vedere a matimaticii nu a indexului !!! Uite in jos apoi
//            }                              //apoi i + 1 adica 2 % 5  este 2 il adaugam in shiftNums[i] and so on .. 2(-30) + 1 % 5  slab il pune in shiftn apo
//                                    ////apoi 3 + 1 % 5  este 4 adica nui bun si il pune in shiftNums[i] 4 + 1 putem pune findca avem in listalungimea 5 ! Nu ai nevoie sa te uiti la index !!
//            return shiftNums;
//        }
//    }
//}




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

/////////////////////////130
//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] item = test(new[] {8, 1, 2, 0, 3, 5, 7, 0, 9, 11, 0, 0});
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
//                var s = pos;
//                if (numbers[i] == 0)
//                {
//                    numbers[i] = numbers[pos];
//                    numbers[pos++] = 0;
//                }
//            }
//            return numbers;
//        }
//    }
//}


// 131 
//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] item = test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 }); // 9
//            Console.Write("New array: ");
//            foreach (var i in item)
//            {
//                Console.Write(i.ToString() + " ");
//            }
//        }
//        static int[] test(int[] numbers)
//        {                    
//            //int size = numbers.Length, index = 0;
//            //int[] arra1 = new int[size];
//            // este la fel
//            int size = numbers.Length;
//            int index = 0;
//            int[] arra1 = new int[size]; // 10

//            for (int i = 0; i < size; i++)
//            {       //el a creat un nou arai . ! 
//                if (numbers[i] != 5)
//                {// daca if nu este egal inseana ca mai jos se initializaza
//                    arra1[index++] = numbers[i];
//                    //  arra1[i++] nu merge ca il punem numbers[i] sa fie egal cu el .
//                    //  arra1[index++] ii asa dar nui  arra1[i++] fiindca indexul lui este diferit . el doreste sa fie 0 la urma.
//                    ////  if (numbers[i] != 5) nu este adevarat inseamna ca numbers[i] se adauga la arra1[index++] care este un nou array si o sa fie 1 , apoi iar verifica
//                    //si este 2 apoi ajunge la 5 sii ii da pace , si asa pana la urma , in total 6 numbere avem in arra1[index++] si 5 , 5, 5 lipsesc dar daca ei nu au fost create ca variabele
//                    //dar in  new int[size]; avem size 9 inseamna ca ultemele automat se pun ca 0 fiindca cum am zis mai sus ele nu au fost create ca variabele dar [size] cere sa fie 9 inseamnca cum am zis a pus + 0 0 0 ca sa fie 9 in total/

//                }
//            }

//            return arra1;
//        }
//    }
//}


/////                    Exercise-132 with Solution
//using System;
//namespace exercises
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] item = test(new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 });
//            Console.Write("New array: ");
//            foreach (var i in item)
//            {
//                Console.Write(i.ToString() + " ");
//            }
//        }
//        static int[] test(int[] numbers)  //[0] = 2
//        {
//            int index = 0;
//            for (int i = 0; i < numbers.Length; i++)  // 2
//            {
//                if (numbers[i] % 2 == 0)
//                {
//                    int temp = numbers[index]; // temp acum este 1 fiindca indexul ii 0 ; ; ca ii primul elemeent din lista (temp este 1)
//                    numbers[index] = numbers[i];  //numbers[index] = numbers[i] dar numbers[i] este egal cu 2 fiindca avem  if (numbers[i] % 2 == 0) numbers[index] cu pozitia 0 o sa il aiba pe 2
//                    numbers[i] = temp; // apoi numbers[i] care este 2 este temp  si ele se chimba cu locul

//                    index++; //atuncea cand ii adevarat ! il adauga unul adica urmatorul elementt osa fie pozita 1 deja . si urmatorul o sa fie 2.
//                }
//            }
//            return numbers;
//        }
//    }
//}




//using System.Data.SqlClient;
/////
///// Cand Ai partte matimaticei - + / * calucleaza mai intii matimatica lasa indexul la sfirsit ! 127 Exercitiul !
///// apoi 4 + 1 este 5 % 5 este = 0 si la sfirsit il pune pe [0]  care este  20 -30 -40 -50 10
//namespace exercises233
//{
//    public class FirestClass
//    {
//        private static SqlConnection connect;

//        public static void Main()
//        {
//            ConnectToDatabase();
//        }
//        public static void ConnectToDatabase()
//        {
//            connect = new(@"Server=DESKTOP-LURF93L\SQLEXPRESS;Database=TutorialDB;Trusted_Connection=true"); //trebuie de creat o conectiune la server cazul dat ii local
//            connect.Open();
//            Console.WriteLine("Successfully connected to TutorialDB.");

//            SqlCommand command = new("select * from Customers", connect); // "select * from Customers" numele la tabel . connection pentru baza de date.  connection ii variable 
//            using (SqlDataReader reader = command.ExecuteReader())
//            {
//                while (reader.Read())     // t e forma de tabel
//                {
//                    Console.WriteLine(String.Format("{0} \t\t | {1} \t\t | {2} \t\t | {3} \t\t |",
//                        reader[0], reader[1], reader[2], reader[3]));
//                }
//            }

//            SqlCommand update = new("update Tutori");
//            Console.WriteLine("Close connection...");
//            connect.Close();
//            Console.WriteLine("Connection closed.");

//            Console.ReadKey();
//        }        

//    }
//}


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
//                        line += " "; // si totodata n = 2 - 1 dex linia 4 * 2 - 1 = 7 steulte sau dex 1 linie 1 * 1 = 2 - 1 este 1.
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
//                        line += " ";
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


//cars[i] = monday[j];  // form mondaypozitionj you will save in cars at position[i]
//cars[i] += monday[j];

//cars[i] = cars[i] + monday[j]  we are taking information to cars[i] add to monday[j] and you store again to cars[i] and  that mean that you will get two if is string you will get two string if is int you can get 10 + 5 = 15;

//using System;







//namespace stopHam
//{
//    class Program123
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(ToBeZInside("mazzarate"));
//            Console.WriteLine(ToBeZInside("zarina"));
//            Console.WriteLine(ToBeZInside("zzaia"));
//            Console.WriteLine(ToBeZInside("zoiaz"));
//            Console.ReadLine();

//        }
//        public static bool ToBeZInside(string input)
//        {
//            int i = 0;
//            char[] myLetters = input.ToCharArray();
//            foreach (char item in myLetters)
//            {
//                if (Char.ToUpper(item) == 'Z')
//                {
//                    i++;
//                }
//            }
//            if (i >= 2 && i <= 4)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}




//namespace stopHam
//{
//    class Program123
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(IfIsMoreThenDoubleZ("mazzarate"));
//            Console.WriteLine(IfIsMoreThenDoubleZ("zarina"));
//            Console.WriteLine(IfIsMoreThenDoubleZ("zzaia"));
//            Console.WriteLine(IfIsMoreThenDoubleZ("zoiaz"));
//            Console.ReadLine();

//        }
//        public static bool IfIsMoreThenDoubleZ(string input)
//        {
//            int i = 0;
//            char[] letter = input.ToCharArray();
//            foreach (char item in letter)
//            {
//                if (Char.ToUpper(item) == 'Z')
//                {
//                    i++;
//                }
//            }
//            if (i >= 2 && i <= 4)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}




//using System;
//namespace exercise
//{
//    class Program12333
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine(EndsWithOn("Python"));
//            Console.WriteLine(EndsWithOn("Hello"));
//        }
//        static string EndsWithOn(string str)
//        {
//            int middle = (0 + str.Length - 1) / 2;
//            return (str[middle - 1].ToString()) + (str[middle].ToString()) + (str[middle + 1].ToString());

//        }
//    }
//}


//using System; //77C
//namespace project23
//{
//    class Programing
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(TakesLast("Hello", "Hi"));
//            Console.WriteLine(TakesLast("Csharp", ""));
//        }
//        static string TakesLast(string x, string y)
//        {
//            return (x.Length > 0 ? x.Substring(0, 1) : "#") + (y.Length > 0 ? y.Substring(y.Length - 1) : "#");
//        }
//    }
//}




//namespace exercises //105C
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 12, 14, 3, 7, 4, 6, 77 };
//            Console.WriteLine(test(arr));
//            foreach (int i in arr)
//            {
//                Console.Write(i.ToString() + " ");
//            }

//        }
//        public static int[] test(int[] arr)
//        {
//            int temp = arr[0]; // temp 1
//            arr[0] = arr[arr.Length - 1];// arr[0] = 77
//             arr[arr.Length - 1] = temp; //77

//            return arr;
//        }
//    }
//}

using System;
namespace exercises
{
    class programing23
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second: ");
            int secondInput = Convert.ToInt32(Console.ReadLine());
            if (firstInput < 100 && secondInput > 200)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
       
    }
}
