namespace Array_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of integers and doubles in Object Array.
            object[] obj = { 12, 2.5, 8, 5.5, "monday", "tuesday" };
            int totalOfInt = 0;
            double totalOfDouble = 0.0;

            foreach (object o in obj)
            {
                if (o is int)
                {
                    totalOfInt += (int)o;
                }
                else if (o is double)
                {
                    totalOfDouble += (double)o;
                }
            }
            Console.WriteLine("Sum of ints: " + totalOfInt);
            Console.WriteLine("Sum of doubles: " + totalOfDouble);

            Console.WriteLine("----------------------------");

            // Displays the sum of invidiual values from whole number.
            Console.WriteLine("Display sum of all values from whole number.");
            Console.Write("Enter a long integer number: ");
            string input = Console.ReadLine();

            int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i].ToString());
            }

            int total = 0;

            for (int index = 0; index < nums.Length; index++)
            {
                Console.WriteLine($"Value at index {index}: {nums[index]}");
                total += nums[index];
            }

            Console.WriteLine("\nTotal of individual nums: " + total);

            Console.WriteLine("----------------------------");

            // Checks string for palindrome. Meaning when the string is reversed does it make the same word.
            Console.WriteLine("String check for palindrome.");
            Console.Write("Enter a string to check: ");
            string inputString = Console.ReadLine();

            char[] normal = inputString.ToCharArray();

            char[] reversed = inputString.ToCharArray();

            for (int z = 0; z < normal.Length; z++)
            {
                reversed[z] = normal[normal.Length - z - 1];
            }

            // Check if the string is a palindrome
            bool isPalindrome = true;

            for (int n = 0; n < normal.Length; n++)
            {
                if (reversed[n] != normal[n])
                {
                    isPalindrome = false;
                    break;
                }
            }
            // Display the result
            if (isPalindrome)
            {
                Console.WriteLine("The entered string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The entered string is not a palindrome.");
            }

            Console.WriteLine("----------------------------");

            // Reverse order of all integers.
            Console.WriteLine("Reverse order of Integers");
            Console.Write("Enter a long integer number: ");
            string inputTwo = Console.ReadLine();

            int[] numsTwo = new int[inputTwo.Length];

            // Store input in array by each individual number.
            for (int x = 0; x < inputTwo.Length; x++)
            {
                numsTwo[x] = int.Parse(inputTwo[x].ToString());
            }

            // Reverse each number in the array.
            for (int j = 0; j < numsTwo.Length / 2; j++)
            {
                int temp = numsTwo[j];
                numsTwo[j] = numsTwo[numsTwo.Length - j - 1];
                numsTwo[numsTwo.Length - j - 1] = temp;
            }

            // Print out each now reversed number in the array.
            foreach (int num in numsTwo)
            {
                Console.Write(num + " ");
            }

        }
    }
}
