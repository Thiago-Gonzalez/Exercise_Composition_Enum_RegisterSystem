using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            List<HourContract> contracts = Contracts.FindAll(contract => contract.Date.Month == month && contract.Date.Year == year);
            double income = BaseSalary;
            foreach(HourContract contract in contracts)
            {
                income += contract.TotalValue();
            }

            return income;
        }
    }
}
