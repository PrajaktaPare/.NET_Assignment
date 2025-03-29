using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "todo.txt";
            int choice;

            do
            {
                Console.WriteLine("\n===== File Operations Menu =====");
                Console.WriteLine("1. Create and Write to File");
                Console.WriteLine("2. Read File");
                Console.WriteLine("3. Append to File");
                Console.WriteLine("4. Delete File");
                Console.WriteLine("5. List Files in Directory");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                // Read user input
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateAndWriteToFile(filePath);
                        break;
                    case 2:
                        ReadFile(filePath);
                        break;
                    case 3:
                        AppendToFile(filePath);
                        break;
                    case 4:
                        DeleteFile(filePath);
                        break;
                    case 5:
                        ListFilesInDirectory();
                        break;
                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            } while (choice != 6);
        }

        // Function to Create and Write to a File
        static void CreateAndWriteToFile(string filePath)
        {
            try
            {
                Console.Write("Enter text to write to the file: ");
                string content = Console.ReadLine();
                File.WriteAllText(filePath, content);
                Console.WriteLine("File created and written successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Function to Read from a File
        static void ReadFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine("\n===== File Content =====");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Function to Append Data to a File
        static void AppendToFile(string filePath)
        {
            try
            {
                Console.Write("Enter text to append: ");
                string newContent = Console.ReadLine();
                File.AppendAllText(filePath, newContent + Environment.NewLine);
                Console.WriteLine("Data appended successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Function to Delete a File
        static void DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Function to List Files in the Current Directory
        static void ListFilesInDirectory()
        {
            try
            {
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                if (files.Length > 0)
                {
                    Console.WriteLine("\n===== Files in Directory =====");
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
                else
                {
                    Console.WriteLine("No files found in the directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
