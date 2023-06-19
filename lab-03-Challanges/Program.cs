namespace lab_03_Challanges
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 2, 2, 1, 1, 8, 5, 8, 8, 8, 9 };
                int[] maxArray = { -5, -25, -99, -123, -78, -96, -555, -108, -4 };
                string path = "../../../words.txt";
                string sentence = "This is a sentance about important things";
                //Console.WriteLine("Your Product of the 3 Numbers You inputted is : " + ProductNumbers());

                //Console.WriteLine($"Your Avverage Number is : {AverageRandomNumbers()}");

                // Pattern();
                //foreach (int i in array)
                //{
                 //   Console.Write(" " +i+" ");
                //}
                //Console.WriteLine();
                //Console.WriteLine(MostTime(array));
                //Console.WriteLine(MaxNumber(maxArray));
                // InsertAWordToFile(path);
                // ReadContent(path);
                //RemoveWord(path);
                //string[] words = WordCounter(sentence);
                //foreach (string wordLength in words)
                //{
                //    Console.Write(wordLength + " ");
                //}
               

                
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Wrong input Format asd ");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //ProductNumbers();
        }
        

        public static int ProductNumbers()
        {
            int result = 1;
            int neagtive = 0;

            
                Console.Write("Please Enter 3 Numbers: ");

                string inputNumbers = Console.ReadLine();

                if (string.IsNullOrEmpty(inputNumbers))
                {
                    return 1;
                }

                string[] numbers = inputNumbers.Trim().Split(' ');

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!int.TryParse(numbers[i], out int n))
                    {
                        numbers[i] = "1";
                    }
                }
                
                int[] arrayOfNumbers = numbers.Select(int.Parse).ToArray();

                if (arrayOfNumbers.Length == 3)
                {
                    for (int i = 0; i < arrayOfNumbers.Length; i++)
                    {
                        if (arrayOfNumbers[i] < 0)
                        {
                            neagtive++;
                            Console.WriteLine($"You Entered neagtive numbers {neagtive} Times. to Positave");
                        }
                        result = result * arrayOfNumbers[i];
                    }
                }
                else if (arrayOfNumbers.Length > 3)
                {
                    Console.WriteLine("You inputted more than 3 numbers. We will calculate the product of the first 3 numbers for you.");
                    for (int i = 0; i < 3; i++)
                    {
                        result = result * arrayOfNumbers[i];
                    }
                }
                else if (arrayOfNumbers.Length < 3)
                {
                    result = 0;
                }
            return result;
        }
        
        public static double AverageRandomNumbers()
        {
            double avg = 0;
            try
            {
                Console.Write("Please enter a number between 2-10: ");
                int size = Convert.ToInt32(Console.ReadLine());
                while (size <= 2 || size >= 10)
                {
                    Console.Write("Please re-Enter a number between 2-10: ");
                    size = Convert.ToInt32(Console.ReadLine());
                }
                double[] randomNumber = new double[size];
                
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"{i + 1} of {size} - Enter a number: ");
                    randomNumber[i] = Convert.ToDouble(Console.ReadLine());
                    while (randomNumber[i] < 0)
                    {
                        Console.WriteLine("You Inputted a negative number re try again ^_^ ");
                        Console.Write($"{i + 1} of {size} - Enter a number: ");
                        randomNumber[i] = Convert.ToDouble(Console.ReadLine());

                    }
                    avg += randomNumber[i];

                }
                avg=avg / size;
                return Math.Floor(avg);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                AverageRandomNumbers();
            }
            return 0;

        }

        public static void Pattern()
        {
            int n = 5; // Number of rows

             for (int i = 1; i <= n; i++)
             {
                 for (int j = 1; j <= n - i; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int k = 1; k <= 2 * i - 1; k++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             for (int i = n-1; i >=1; i--)
             {
                 for (int j = 1; j <= n-i; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int k = 1; k <= 2* i-1  ; k++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
        }

        public static int MostTime(int[] array)
        {

            if (array.Length == 0)
            {
                MostTime(array);
            }
            int frequentNumber = array[0];
            int maxFrequent = 1;
            for (int i = 0; i < array.Length; i++)
            {
                int frequent = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        frequent++;
                    }
                }
                if (frequent > maxFrequent)
                {
                    maxFrequent = frequent;
                    frequentNumber = array[i];
                }
            }

            return frequentNumber;
        }

        public static int MaxNumber(int[] MaxArray)
        {
            int max = MaxArray[0];
            foreach (int i in MaxArray)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }

        public static void InsertAWordToFile(string path)
        {
            Console.Write("Please Enter a Word :");
            string word = Console.ReadLine();
            File.AppendAllText(path, word + Environment.NewLine);
            Console.WriteLine("Word Added Successfully");
        }

        public static void ReadContent(string path)
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content); 
        }

        public static void RemoveWord(string path)
        {
            ReadContent(path);
            Console.Write("Enter A Word to Delete : ");
            string[] wordsToRemove = File.ReadAllLines(path);
            string input = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < wordsToRemove.Length  ; i++)
            {
                if (wordsToRemove[i] == input)
                {
                    wordsToRemove[i] = string.Empty;
                    check = true;
                }
            }
            if (check)
            {
                File.WriteAllLines(path,wordsToRemove);
                ReadContent(path);
                Console.WriteLine("Word Removed Successfully");
            }
        }

        public static string[] WordCounter(string sentence)
        {
            if (sentence == null)
            {
                return null;
            }
            else
            {
                string[] words = sentence.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i] + $" : {words[i].Length}";
                }

                return words;
            }
        }

        
    }
}