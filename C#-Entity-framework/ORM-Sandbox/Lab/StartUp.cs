using Lab.Data;
using System;
using System.Linq;

namespace Lab
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            string result = FindEmployeesWithJobTitle(context);
            Console.WriteLine(result);
        }

        //Lab 01
        public static string FindEmployeesWithJobTitle(SoftUniContext context)
        {
            //toto
            var employees = context.Employees
                .Where(e => e.JobTitle == "Design Engineer")
                .Select(e => e.FirstName)
                .ToList();

            return string.Join(Environment.NewLine, employees);
        }

        //Lab 02
        public static string FindProjectWithId(SoftUniContext context)
        {
            var project = context.Projects.Find(2);
            return project.Name;
        }
    }
}
