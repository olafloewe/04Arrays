using System;

namespace Task_5 {
    internal class Program {

        static void Main(string[] args) {
            int length = 0;
            do {
                Console.Write("Until which number should the prime numbers be calculated?");
            } while (!int.TryParse(Console.ReadLine(), out length));
            int[] numbers = new int[length+1];

            // computing
            GenerateArray(numbers);
            SieveOfEra(numbers);
            PrintArray(numbers);
        }

        // fills the array with values corresponding to their index
        private static void GenerateArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++) { 
                nums[i] = i;
            }
        }

        // prints the passed array if value not = -1 
        private static void PrintArray(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != -1) Console.Write($"{nums[i]} ");
            }
        }

        // marks non prime numbers with -1
        private static void SieveOfEra(int[] nums) {
            for (int p = 2; p < nums.Length; p = NextP(nums, p)) {
                if(p == -1) continue;
                for (int i = 1; (i * p) < nums.Length; i++) {
                    if(i * p < nums.Length) nums[i * p] = -1;
                }
            }
        }

        //finds next P
        private static int NextP(int[] nums, int p) {
            for (int i = p; i < nums.Length; i++) {
                if (nums[i] > nums[p])return nums[i]; // err
            }
            return -1;
        }
    }
}