namespace Inheriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student raya = new Student();
            raya.Name = "Raisa";
            raya.Age = 69;
            raya.School = "Fk";

            Teacher teacher1 = new Teacher();
            teacher1.Subject = "Istoriq";
            Employee employee = new Employee();
            employee.Company = "soft";

            teacher1.Sleep();
            employee.Sleep();
        }
    }
}
