using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assessment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose an operation:");
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Read a file");
                Console.WriteLine("3. Append to a file");
                Console.WriteLine("4. Delete a file");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:

                        string path = "D:\\";
                        string fname;
                        Console.WriteLine("Enter file name");
                        fname = Console.ReadLine();
                        string fPath = path + fname;
                        if (File.Exists(fPath))
                        {
                            Console.WriteLine("The File is already exist!!!");
                        }
                        else
                        {
                            File.Create(fPath);
                            Console.WriteLine("File Created !!!");
                        }

                        break;
                    case 2:


                        StreamReader sr;


                        try
                        {

                            Console.WriteLine("enter file path to read");
                            string fpath = Console.ReadLine();
                            sr = new StreamReader(fpath);
                            string text = "";
                            while ((text = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(text);
                            }
                            sr.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error!" + ex.Message);
                        }
                        finally
                        {
                            Console.ReadKey();
                        }


                        break;
                    case 3:
                        try
                        {
                            string fpath = Console.ReadLine();
                            Console.WriteLine("Enter file name to Read out from");
                            string fName = Console.ReadLine();
                            //string fpath = path + fName;
                            if (File.Exists(fpath))
                            {
                                string[] lines = File.ReadAllLines(fpath);
                                foreach (string line in lines)
                                {
                                    Console.WriteLine(line);
                                }
                            }
                            else { Console.WriteLine("File does not exist"); }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error!" + ex.Message);
                        }
                        finally
                        {
                            Console.ReadKey();
                        }
                        break;
                    case 4:

                        try
                        {
                            string fpath = Console.ReadLine();
                            Console.WriteLine("Enter file name to Delete");
                            string fName = Console.ReadLine();
                            // string fpath = path + fName;
                            if (File.Exists(fpath))
                            {
                                File.Delete(fpath);
                                Console.WriteLine("File Deleted permanently");

                            }
                            else { Console.WriteLine("File does not exist"); }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error!" + ex.Message);
                        }
                        finally
                        {
                            Console.ReadKey();

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;



                }

            }
        }
    }
}
