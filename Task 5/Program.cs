using System;
using static System.Net.Mime.MediaTypeNames;

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
            PrintArray(numbers);
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
                // if (nums[i] != 0) 
                    Console.Write($"{nums[i]} ");
            }
        }

        // marks non prime numbers with 0
        private static void SieveOfEra(int[] nums) {
            for (int p = 2; (p < nums.Length) && (p != 0); NextP(nums, p)) {
                // purge non primes
                for (int i = 1; (i * p) < nums.Length; i++) {
                    nums[i * p] = 0;
                }
            }
        }
        
        //finds next P
        private static int NextP(int[] nums, int p) {
            int smallest = p;
            for (int i = nums.Length-1; i > p; i--) { 
                if(nums[i] < smallest && nums[i] != 0) smallest = i;
            }
            return smallest;
        }
    }
}