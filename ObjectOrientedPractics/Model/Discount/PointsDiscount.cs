using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {

        private int _points;


        private const double MaxDiscountPercentage = 0.3;


        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Positive value is expected.");
                }
                _points = value;
            }
        }


        public double Calculate(List<Item> items)
        {
            double totalPrice = 0;

            foreach (var item in items)
            {
                totalPrice += item.Cost;
            }

            double maxDiscount = totalPrice * MaxDiscountPercentage;

            return Math.Min(Points, maxDiscount);

        }

        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            Points -= (int)Math.Floor(discount);

            return discount;
        }

        public void Update(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                totalCost += item.Cost;
            }

            int earnedPoints = (int)Math.Ceiling(totalCost * 0.10);
            Points += earnedPoints;
        }


        public PointsDiscount(int initialPoints)
        {
            Points = initialPoints;
        }

        public PointsDiscount()
        {
            Points = 0;
        }


        public string Info => $"Saved – {Points} points";
    }
}