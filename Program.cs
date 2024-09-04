using Repository_ConsoleApp.Bussiness_Layer;
using Repository_ConsoleApp.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeacherBussiness Business = new TeacherBussiness(new TeacherAssign());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type '1' for List, '2' for Add, '3' for Update '4' for Delete, '5' for Search,'6' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "1")
                    {
                        List<Teacher> listTeacher = Business.Get();
                        Console.WriteLine("List of Teacher:");
                        Console.WriteLine("EnrollId   |   TeacherName    |   Subject");
                        foreach (Teacher teacher in listTeacher)
                        {
                            Console.WriteLine(teacher.EnrollId + "  |   " + teacher.TeacherName + "  |   " + teacher.Subject);
                        }
                    }
                    else if (command == "5")
                    {
                        Console.WriteLine("Input a EnrollId to find a Teacher:");
                        string enrollId = Console.ReadLine();
                        Teacher a = Business.Get(Convert.ToInt32(enrollId));
                        Console.WriteLine(a.EnrollId + ". " + a.TeacherName + " -- " + a.Subject);
                    }
                    else if (command == "2")
                    {
                        Console.WriteLine("Input an EnrollId:");
                        string enrollId = Console.ReadLine();
                        Console.WriteLine("Input a Teacher Name:");
                        string teacherName = Console.ReadLine();
                        Console.WriteLine("Input a Subject Name:");
                        string subject = Console.ReadLine();
                        Teacher a = new Teacher();
                        a.EnrollId = Convert.ToInt32(enrollId);
                        a.TeacherName = teacherName;
                        a.Subject = subject;
                        bool isExecuted = Business.Add(a);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "3")
                    {
                        Console.WriteLine("Input a id:");
                        string accountno = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string teacherName = Console.ReadLine();
                        Console.WriteLine("Input a Subject:");
                        string subject = Console.ReadLine();
                        Teacher a = new Teacher();
                        a.EnrollId = Convert.ToInt32(accountno);
                        a.TeacherName = teacherName;
                        a.Subject = subject;
                        bool isExecuted = Business.Update(a);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "4")
                    {
                        Console.WriteLine("Input a EnrollId:");
                        string enrollId = Console.ReadLine();
                        bool isExecuted = Business.Delete(Convert.ToInt32(enrollId));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "6")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
