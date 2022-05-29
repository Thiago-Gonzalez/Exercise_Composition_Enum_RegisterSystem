
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: $ ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, baseSalary, new Department(department));

            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());


            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: $ ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime incomeDate = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
            double income = worker.Income(incomeDate.Year, incomeDate.Month);
            Console.Write("Name: " + worker.Name);
            Console.WriteLine();
            Console.Write("Department: " + worker.Department.Name);
            Console.WriteLine();
            Console.Write("Income for " + incomeDate.Month + "/" + incomeDate.Year + ": " + income.ToString("F2", CultureInfo.InvariantCulture));

        }
    }

}