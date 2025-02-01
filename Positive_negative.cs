// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[5];

//         Take input for 5 numbers
//         Console.WriteLine("Enter 5 numbers:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = int.Parse(Console.ReadLine());
//         }

//        Loop through the array and check each number
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > 0)
//             {
//                 Check if the number is even or odd
//                 if (numbers[i] % 2 == 0)
//                 {
//                     Console.WriteLine("The number is positive and even.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("The number is positive and odd.");
//                 }
//             }
//             else if (numbers[i] < 0)
//             {
//                 Console.WriteLine("The number is negative.");
//             }
//             else
//             {
//                 Console.WriteLine("The number is zero.");
//             }
//         }

//         Compare the first and last elements of the array
//         if (numbers[0] > numbers[^1]) // ^1 is the last element
//         {
//             Console.WriteLine("The first element is greater than the last element.");
//         }
//         else if (numbers[0] < numbers[^1])
//         {
//             Console.WriteLine("The first element is less than the last element.");
//         }
//         else
//         {
//             Console.WriteLine("The first element is equal to the last element.");
//         }
//     }
// }
