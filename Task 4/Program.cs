using System;

namespace Task_4 {
    internal class Program {

        static void Main(string[] args) {
            int length = 0;
            do {
                Console.Write("How many numbers do you want to enter?");
            } while (!int.TryParse(Console.ReadLine(), out length));
            int[] numbers = new int[length];
            
            // input
            InputArray(numbers);
            Console.Write("Original Array: ");
            PrintArray(numbers);
            
            // computing
            BubbleSort(numbers);

            // output
            Console.Write("\nSorted Array: ");
            PrintArray(numbers);
        }

        // prints the passed array
        private static void PrintArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.Write($"{nums[i]} ");
            }
        }

        // asks the user to fill an array with integers
        private static void InputArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.Write($"Please input number {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out nums[i])) i--;
            }
        }

        // sorts the passed array 
        private static void BubbleSort(int[] nums) {
            int largest = nums[0];
            int tmp;
            // loop through every number
            for (int i = nums.Length - 1; i > 0; i--) {
                for (int j = 1; j < nums.Length; j++) {
                    if (nums[j] <= nums[j - 1]) Swap(nums, j, j - 1);
                }
            }
        }

        // swaps values of given indexes in an array
        private static void Swap(int[] nums, int first, int second) {
            int tmp = nums[second];
            nums[second] = nums[first];
            nums[first] = tmp;
        }
    }
}