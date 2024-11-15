
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{

    public class PercentDiscount : IDiscount
    {

        private int _percent = 5;


        public Category Category { get; set; }

        public int Percent
        {
            get
            {
                return _percent;
            }
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("out of range");
                }
                _percent = value;
            }
        }

        public double SpendingPerCategory { get; private set; } = 0;


        public string Info
        {
            get
            {
                return $"Percent \"{Category}\" - {Percent}%";
            }
        }

        public double Calculate(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost * Percent / 100;

        }

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }

            SpendingPerCategory += totalCost;
            var percentage = (int)(SpendingPerCategory / 100);
            Percent = Math.Min(percentage, 10);
        }

        public PercentDiscount(Category category)
        {
            Category = category;
        }

        public PercentDiscount()
        {
            Category = Category.Sports;
        }

    }
}