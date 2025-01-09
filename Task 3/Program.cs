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
            for (int i = 0; i < freq.Length; i++) {
                Console.WriteLine($"{i+1}: {freq[i]}");
            }
        }

        // asks the user to input integers between 1 and 5
        private static void InputArray(string[] freq) {
            int amt = 0;
            do {
                Console.Write("How many numbers do you want to enter: ");
            } while (!int.TryParse(Console.ReadLine(), out amt));

            int input;
            for (int i = 0; i < amt; i++) {

                // input wrong type
                do{
                    Console.Write($"Please input number {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out input));

                // input out of range
                if (input > 5 || input < 1) {
                    i--;
                    continue;
                }

                freq[input - 1] = $"{freq[input - 1]}*"; 
            }
        }
    }
}