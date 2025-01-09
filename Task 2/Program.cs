using System;

namespace Task_2 {
    internal class Program {

        static void Main(string[] args) {
            int length = 0;
            do {
                Console.Write("How many numbers do you want to enter?");
            }while(!int.TryParse(Console.ReadLine(), out length));
            int[] numbers = new int[length];
            InputArray(numbers);
            ReversePrintArray(numbers);
        }

        // prints the array and the average its numbers
        private static void ReversePrintArray(int[] nums) {
            float total = 0.0f;
            Console.Write("The average of numbers ");
            
            // loop through the array printing every index and adding it to the total
            for (int i = 0; i < nums.Length; i++) {
                total += nums[i];
                Console.Write($"{nums[i]} ");
            }

            Console.WriteLine($"is {total / nums.Length}");
        }

        // asks the user to fill an array with integers
        private static int[] InputArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.Write($"Please input number {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out nums[i])) i--;
            }
            return nums;
        }
    }
}