using System.ComponentModel;
using System.Security.Cryptography;

namespace TMS_Practic_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //int perv = 1;
            //int vtor = 1;   
            //int sum = 0;

            //while (89 >= sum)
            //{
            //    sum += perv;    
            //    perv = vtor;
            //    vtor = sum;
            //    Console.WriteLine($"The Fibo number: {sum}\n");

            //}
            //Console.WriteLine("___________________________________________");

            // 2

            //Console.Write("Please enter deposit amount: ");
            //decimal deposit = decimal.Parse(Console.ReadLine());
            //Console.Write("Please enter period month: ");
            //int period = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i < period; i++)
            //{
            //    deposit += deposit * 0.07M;

            //}
            //Console.WriteLine($"After {period} month your the deposit amount will be: {deposit}");
            //Console.ReadKey();  

            // 3

            //while (true)
            //{
            //    Console.Clear();
            //    double firstValue, secondValue;
            //    string action;
            //    Console.WriteLine("Enter first number: ");
            //    firstValue = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number: ");
            //    secondValue = double.Parse(Console.ReadLine());
            //    Console.WriteLine(" select the calculator operation: '+' | '-' | '/' | '*'| ^ ");
            //    action = Console.ReadLine();


            //    switch (action)
            //    {
            //        case "+":
            //            Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"{firstValue} - {secondValue} = {firstValue - secondValue}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"{firstValue} * {secondValue} = {firstValue * secondValue}");
            //            break;
            //        case "^":
            //            Console.WriteLine($"{firstValue} ^ {secondValue} = {Math.Pow(firstValue,secondValue)}");
            //            break;  
            //        case "/":
            //            if (secondValue == 0)
            //                Console.WriteLine(0);
            //            else
            //            Console.WriteLine($"{firstValue} / {secondValue} = {firstValue / secondValue}");
            //            break;  
            //            default: Console.WriteLine("Wrong! unknown action");
            //            break;

            //    }
            //    Console.WriteLine("Press any key to continue");
            //    Console.ReadKey();


            //}

            // 4
            //Link1:
            //Console.Write("Enter elements count only 5-10: ");
            //int elementsCount = int.Parse(Console.ReadLine());
            //int[] myArray = new int[elementsCount];
            //Random ran = new Random();


            //if (elementsCount >= 5 && elementsCount <= 10)
            //{


            //}
            //else
            //{
            //    Console.WriteLine(" Wrong number!");
            //    goto Link1;
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = ran.Next();
            //    Console.WriteLine(myArray[i]);

            //}
            //Console.WriteLine("__________");

            //foreach (var item in myArray)
            //{
            //    if (item % 2 == 0)
            //    {
            //       Console.WriteLine(item);  
            //    }
            //    continue;

            //}
            //Console.ReadKey();   

            // 5
            //int[] myArray = { 7, 5, 12, 11, 4, 6, 3, 8, 9, 10, 11, 16, };
            //int[] secondArray = myArray;
            //int oddIndexes = 0;
            //for (int i = 0; i < myArray.Length; i++)
            //{

            //    if (myArray[i] % 2 == 1)
            //    {
            //        oddIndexes = myArray[i];
            //        myArray[i] = 0;
            //        //Console.WriteLine($"{oddIndexes}");
            //    }

            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine($"\n{myArray[i]}\t");
            //}
            //Console.ReadKey();

            // 6 //7     /Array.Sort /Array.Exists /Array.Resize

            //string[] names = { "Dima", "Dina", "Vladik", "Marina", "Albina", "Ira", "Valintina","Gena","Adgar" };
            //Array.Sort(names);

            //for (int i = 0; i < names.Length; i++)
            //{
            //  Console.WriteLine($"{i+1}.)\t {names[i]}");
            //}  

            ////Console.WriteLine("One or more names begin with 'D': {0}",
            ////    Array.Exists(names, element => element.StartsWith("D")));

            ////Console.WriteLine("One or more names begin with 'T': {0}",
            ////    Array.Exists(names, element => element.StartsWith("T")));

            ////Console.WriteLine("Is Alex one of the names? {0}",
            ////    Array.Exists(names, element => element == "Alex"));

            //Array.Resize(ref names, names.Length + 5);
            //Console.WriteLine("After resizing: ");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{i}.) {names[i]}");
            //}

            // 7    я понимаю этот код но сам честно я бы не сделал! буду продолжать изучать этот код.

            static void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }

            
            static int[] BubbleSort(int[] array)
            {
                var len = array.Length;
                for (var i = 1; i < len; i++)
                {
                    for (var j = 0; j < len - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }

                return array;
            }

            
            {
                Console.WriteLine("Bubble Sorting: ");
                Console.Write("Enter the array elements: ");
                var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
                var array = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    array[i] = int.Parse(parts[i]);
                }

                Console.WriteLine("Sorted array: {0}", string.Join(", ", BubbleSort(array)));

                Console.ReadLine();
            }
        }





    }
        
}