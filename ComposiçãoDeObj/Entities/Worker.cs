using System;
using System.Collections.Generic;
using ComposiçãoDeObj.Entities.Enums;
namespace ComposiçãoDeObj.Entities
{
    public class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker(){}

        public Worker(string name, WorkerLevel level, double basSalary, Department department)
        {
            this.name = name;
            this.level = level;
            this.BaseSalary = basSalary;
            this.department = department;
        }

        public void addContract(HourContract contract )
        {
            Contract.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            return sum;
            }
        }
    }
}

