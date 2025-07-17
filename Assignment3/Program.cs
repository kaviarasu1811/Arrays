namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int choice;

                do
                {
                    Console.WriteLine("\n=== MENU ===");
                    Console.WriteLine("1. Sum of only positive numbers from 10 elements");
                    Console.WriteLine("2. Sum of 2 matrices (3x3)");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");

                    string? input = Console.ReadLine();
                    if (!int.TryParse(input, out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            SumOfPositiveNumbers();
                            break;

                        case 2:
                            SumOfTwoMatrices();
                            break;

                        case 0:
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter 1, 2 or 0.");
                            break;
                    }

                } while (choice != 0);
            }

            static void SumOfPositiveNumbers()
            {
                int[] numbers = new int[10];
                int sum = 0;

                Console.WriteLine("\nEnter 10 numbers:");

                for (int i = 0; i < 10; i++)
                {
                    while (true)
                    {
                        Console.Write("Number " + (i + 1) + ": ");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out numbers[i]))
                        {
                            if (numbers[i] > 0)
                            {
                                sum += numbers[i];
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                }

                Console.WriteLine("Sum of only positive numbers = " + sum);
            }

            static void SumOfTwoMatrices()
            {
                int[,] matrix1 = new int[3, 3];
                int[,] matrix2 = new int[3, 3];
                int[,] result = new int[3, 3];

                Console.WriteLine("\nEnter elements for Matrix 1:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        while (true)
                        {
                            Console.Write($"Matrix1[{i},{j}]: ");
                            string? input = Console.ReadLine();
                            if (int.TryParse(input, out matrix1[i, j]))
                                break;
                            else
                                Console.WriteLine("Invalid input. Enter a valid number.");
                        }
                    }
                }

                Console.WriteLine("Enter elements for Matrix 2:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        while (true)
                        {
                            Console.Write($"Matrix2[{i},{j}]: ");
                            string? input = Console.ReadLine();
                            if (int.TryParse(input, out matrix2[i, j]))
                                break;
                            else
                                Console.WriteLine("Invalid input. Enter a valid number.");
                        }
                    }
                }

                Console.WriteLine("\nSum of Matrix 1 and Matrix 2:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

