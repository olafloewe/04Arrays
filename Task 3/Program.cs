using System;

namespace Task_3 {
    internal class Program {

        static void Main(string[] args) {
            string[] frequency = new string[5];

            InputArray(frequency);
            PrintArray(frequency);
        }

        // prints the array
        private static void PrintArray(string[] freq) {
            float total = 0.0f;
            Console.Write("The average of numbers ");

            // loop through the array printing every index and adding it to the total
            for (int i = 0; i < freq.Length; i++) {
                total += freq[i];
                Console.Write($"{freq[i]} ");
            }

            Console.WriteLine($"is {total / freq.Length}");
        }

        // asks the user to fill an array with integers
        private static void InputArray(string[] freq) {
            int amt = 0;
            do {
                Console.Write("How many numbers do you want to enter: ");
            } while (!int.TryParse(Console.ReadLine(), out amt));

            for (int i = 0; i < amt; i++) {

                Console.Write($"Please input number {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out int err)) i--;
            }
        }
    }
}