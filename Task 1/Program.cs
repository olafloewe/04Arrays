using System;

namespace Task_1 {
    internal class Program {

        static void Main(string[] args) {
            int[] numbers = new int[20];
            InputArray(numbers);
            ReversePrintArray(numbers);
        }

        // prints the array in reverse
        private static void ReversePrintArray(int[] nums) {
            for (int i = nums.Length-1; i >= 0; i--) {
                Console.WriteLine(nums[i]);
            }
        }

        // asks the user to fill an array of fixed length with integers
        private static void InputArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine($"Please input number {i+1}:");
                if(!int.TryParse(Console.ReadLine(), out nums[i])) i--;
            }
        }
    }
} 