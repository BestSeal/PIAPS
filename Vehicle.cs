using System.Collections.Generic;

namespace lab1
{
    public abstract class Vehicle
    {
        protected Driver _driver;
        protected List<Passenger> _passengers;
        
        protected Vehicle(int capacity, float price)
        {
            Capacity = capacity;
            Price = price;
            CollectedMoney = 0;
            _passengers = new List<Passenger>();
            _driver = null;
        }

        public int Capacity
        {
            get;
            protected set;
        }

        public float Price
        {
            get;
            protected set;
        }
        
        public float CollectedMoney
        {
            get;
            protected set;
        }

        public void Embus(Passenger passenger)
        {
            if (Capacity <= _passengers.Count)
            {
                float? payed = passenger.Pay(Price);

                if (!(payed is null))
                {
                    _passengers.Add(passenger);
                    CollectedMoney += payed ?? 0;
                }  
            }
        }
        public abstract void Embus(Driver driver);
        
        public bool IsReadyToGo()
        {
            return _passengers.Count > 0 && !(_driver is null);
        }
    }

    public class Bus : Vehicle
    {
        Bus(int capacity, float price) : base(capacity, price){}

        public override void Embus(Driver driver)
        {
            if (driver is BusDriver)
            {
                _driver = driver;
            }
        }
    }

    public class Taxi : Vehicle
    {

        Taxi(int capacity, float price, bool childChair) : base(capacity, price) {}
        
        public override void Embus(Driver driver)
        {
            if (driver is TaxiDriver)
            {
                _driver = driver;
            }
        }
        
    }
}