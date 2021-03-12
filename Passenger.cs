using System.Reflection;

namespace lab1
{
    public abstract class Passenger
    {
        public float? Money
        {
            get;
            private set;
        }

        public float? Pay(float price)
        {
            if (Money >= price)
            {
                Money -= price;
                return price;
            }
            else
            {
                return null;
            }
            
        }

    }
}