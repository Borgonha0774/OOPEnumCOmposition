
using OOPEnumComposition.Entities.Enums;

namespace OOPEnumCOmposition.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

    }
}
