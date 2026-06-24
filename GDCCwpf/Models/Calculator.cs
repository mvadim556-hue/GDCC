using System;

namespace GDCCwpf.Models
{
    public class Calculator
    {
        private const decimal ProgrammerSalary = 5200m;
        private const decimal ArtistSalary = 4200m;
        private const decimal ManagementOverhead = 1.2m;

        public decimal CalculateTotalCost(int programmers, int artists, int months)
        {
            if (programmers < 0)
                throw new ArgumentException("Количество программистов не может быть отрицательным");
            if (artists < 0)
                throw new ArgumentException("Количество художников не может быть отрицательным");
            if (months < 0)
                throw new ArgumentException("Количество месяцев не может быть отрицательным");

            decimal baseCost = (programmers * ProgrammerSalary + artists * ArtistSalary) * months;
            return baseCost * ManagementOverhead;
        }
    }
}
