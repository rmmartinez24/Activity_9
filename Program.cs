
// by: rodrigo martinez
// CST-150
// C# 

namespace Activity_Nine
{
    public class Methods
    {
        // 1. finds the sum of two integers and displays their sum
        public static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }


        //2. takes five doubles and returns their average
        public static double Average(double a, double b, double c, double d, double e)
        {
            double average = (a + b + c + d + e) / 5;

            return average;
        }


        //3. returns the sum of two random generated integers
        public static int SumOfRandomInts()
        {
            Random random = new Random();
            int a = random.Next(0, 50);
            int b = random.Next(0, 50);
            int sum = a + b;

            return sum;
        }


        //4. takes three integers and return true if sum is divisble by 3, false if otherwise 
        public static bool DivisbleByThree(int a, int b, int c)
        {
            int sum = a + b + c;
            if (sum % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //5. takes two strings and displays string what has fewer characters
        public static string FewerCharacters(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        //6. takes an array of doubles and return the largest value in the array
        public static double LargestValue(double[] a)
        {
            double largest = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
            }
            return largest;
        }


        //7. generates and returns an array of fifty integer values
        public static int[] FifityValues()
        {
            int[] fifty = new int[50];
            for (int i = 0; i < fifty.Length; i++)
            {
                fifty[i] = 1;
            }

            return fifty;
                   
        }
        

        //8. takes two bool variable and returns true if they have the same value. false if otherwise
        public static bool SameBoolValue(bool a, bool b)
        {
            if (a == b)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        //9. takes an int and a double and returns their product
        public static double Product(int a, double b)
        {
            double product = a * b;

            return product;
        }


        //10. takes two-dimensional array of integers and returns the average of the entries
        public static double AverageOfTwoDimensional(double[,] a)
        {
            double sum = 0;
            for (int i =0; i < a.GetLength(0); i++)
            {
                for (int r = 0; r < a.GetLength(1); r++)
                {
                    sum += a[i, r];
                }
            }

            double average = sum / (a.GetLength(0) * a.GetLength(1));

            return average;
        }
        
    }
}
