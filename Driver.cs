namespace lab1
{ 
    public class Driver{}

    public class BusDriver : Driver{}

    public class TaxiDriver : Driver{}

    public abstract class DriverFactory
    {
        public abstract Driver CreateDriver();

    }

    public class BusDriverFactory : DriverFactory
    {
        public override Driver CreateDriver()
        {
            return new BusDriver();
        }
    }

    public class TaxiDriverFactory : DriverFactory
    {
        public override Driver CreateDriver()
        {
            return new TaxiDriver();
        }
    }
}