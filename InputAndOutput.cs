namespace J1.S.P0001
{
    public class InputAndOutput
    {
        int numberOfArray;
        int[] arrays;

        public void inputNumberOfArray()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter number of array: ");
                Console.ResetColor();
                if (int.TryParse(Console.ReadLine(), out numberOfArray) && numberOfArray > 2)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an integer number of array more than two.");
                    Console.ResetColor();
                }
            }
        }

        public void inputArray()
        {
            arrays = new int[numberOfArray];
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Input array: ");
            Console.ResetColor();
            for (int i = 0; i < numberOfArray; i++)
            {
                System.Console.Write("Number " + (i + 1) + ": ");
                arrays[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void outputUnsortedArray()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write("Unsorted array: [");
            for (int i = 0; i < numberOfArray; i++)
            {
                if (i == (numberOfArray - 1))
                {
                    System.Console.Write(arrays[i]);
                }
                else
                {
                    System.Console.Write(arrays[i] + " ");
                }
            }
            System.Console.WriteLine("]");
            Console.ResetColor();
        }

        //Use bubble sort to sort array
        public void outputSortedArray()
        {
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                for (int j = 0; j < arrays.Length - i - 1; j++)
                {
                    if (arrays[j] > arrays[j + 1])
                    {
                        int temp = arrays[j];
                        arrays[j] = arrays[j + 1];
                        arrays[j + 1] = temp;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("Sorted array: [");
            for (int i = 0; i < arrays.Length; i++)
            {
                if (i == (arrays.Length - 1))
                {
                    System.Console.Write(arrays[i]);
                }
                else
                {
                    System.Console.Write(arrays[i] + " ");
                }
            }
            System.Console.WriteLine("]");
            Console.ResetColor();
        }
    }
}
