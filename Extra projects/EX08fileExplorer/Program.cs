using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX08fileExplorer
{
    
    internal class Program
        
    {
        // directory storing variable
        static string currentDirectory;
        static void Main(string[] args)
        {
            currentDirectory = Directory.GetCurrentDirectory();

            Console.WriteLine("This is the Basic File Explorer");
            // running menu
            while (true)
            {
              
                Console.WriteLine("Current Directory: " + currentDirectory);
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. List Contents");
                Console.WriteLine("2. Copy File");
                Console.WriteLine("3. Move File");
                Console.WriteLine("4. Delete File");
                Console.WriteLine("5. Rename File");
                Console.WriteLine("6. Navigate to Directory");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-7): ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ListContents();
                        break;
                    case "2":
                        CopyFile();
                        break;
                    case "3":
                        MoveFile();
                        break;
                    case "4":
                        DeleteFile();
                        break;
                    case "5":
                        RenameFile();
                        break;
                    case "6":
                        NavigateToDirectory();
                        break;
                    case "7":
                        Console.WriteLine("Good bye !");
                        return;
                    default:
                        Console.WriteLine("Wrong choice. Please try again.");
                        break;
                }
            }
        }

        // listing content of a directory
        static void ListContents()
        {
            try
            {
                string[] files = Directory.GetFiles(currentDirectory);
                string[] directories = Directory.GetDirectories(currentDirectory);

                Console.WriteLine("Files:");
                foreach (string file in files)
                    Console.WriteLine(Path.GetFileName(file));

                Console.WriteLine();

                Console.WriteLine("Directories:");
                foreach (string directory in directories)
                    Console.WriteLine(Path.GetFileName(directory));
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error with showing the content: " + ex.Message);
            }
        }

        // copying file
        static void CopyFile()
        {
            Console.Write("Enter the source file path: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Enter the destination file path: ");
            string destinationPath = Console.ReadLine();

            try
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine("File copied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error with copying the file: " + ex.Message);
            }
        }

        // moving file
        static void MoveFile()
        {
            Console.Write("Enter the source file path: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Enter the destination file path: ");
            string destinationPath = Console.ReadLine();

            try
            {
                File.Move(sourcePath, destinationPath);
                Console.WriteLine("File moved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error with moving the file: " + ex.Message);
            }
        }

        // removing file
        static void DeleteFile()
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            try
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error with deleting the file: " + ex.Message);
            }
        }

        // renaming file
        static void RenameFile()
        {
            Console.Write("Enter the current file path: ");
            string currentPath = Console.ReadLine();

            Console.Write("Enter the new file name: ");
            string newName = Console.ReadLine();

            string newPath = Path.Combine(Path.GetDirectoryName(currentPath), newName);

            try
            {
                File.Move(currentPath, newPath);
                Console.WriteLine("File renamed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error with renaming the file: " + ex.Message);
            }
        }

        // moving between directories
        static void NavigateToDirectory()
        {
            Console.Write("Enter the directory path: ");
            string directoryPath = Console.ReadLine();

            try
            {
                currentDirectory = directoryPath;
                Directory.SetCurrentDirectory(currentDirectory);
                Console.WriteLine("Navigated to directory: " + currentDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error with navigating to the directory: " + ex.Message);
            }
        }
    }
}
