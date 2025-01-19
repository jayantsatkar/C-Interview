// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.ReadKey();

using Interviews;

interface VehicleFactory
{
    Bike GetBike(string Bike);
    Scooter GetScooter(string Scooter);
}

interface Bike
{
    string Name();
}

/// <summary>
/// The 'AbstractProductB' interface
/// </summary>
interface Scooter
{
    string Name();
}

class RegularBike : Bike
{
    public string Name()
    {
        return "Regular Bike- Name";
    }
}

/// <summary>
/// The 'ProductA2' class
/// </summary>
class SportsBike : Bike
{
    public string Name()
    {
        return "Sports Bike- Name";
    }
}

/// <summary>
/// The 'ProductB1' class
/// </summary>
class RegularScooter : Scooter
{
    public string Name()
    {
        return "Regular Scooter- Name";
    }
}

/// <summary>
/// The 'ProductB2' class
/// </summary>
class Scooty : Scooter
{
    public string Name()
    {
        return "Scooty- Name";
    }
}

class HondaFactory : VehicleFactory
{
    //
    //Calculator calculator = new Calculator();
    //calculator.VehicleFactory
    public Bike GetBike(string Bike)
    {
        
        if (Bike == "Sports") {
            return new SportsBike();
        }
        else if (Bike == "Regular")
        {
            return new RegularBike();
        }
        else
        {
            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
        }

    }

    public Scooter GetScooter(string Scooter)
    {
        if (Scooter == "Sports")
        {
            return new Scooty();
        }
        else if (Scooter == "Regular")
        {
            return new RegularScooter();
        }
        else
        {
            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
        }

    }
}

/// <summary>
/// The 'ConcreteFactory2' class.
/// </summary>
class HeroFactory : VehicleFactory
{
    public Bike GetBike(string Bike)
    {
        if (Bike == "Sports")
        {
            return new SportsBike();
        }
        else if (Bike == "Regular")
        {
            return new RegularBike();
        }
        else
        {
            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
        }

    }

    public Scooter GetScooter(string Scooter)
    {
        if (Scooter == "Sports")
        {
            return new Scooty();
        }
        else if (Scooter == "Regular")
        {
            return new RegularScooter();
        }
        else
        {
            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
        }

    }
}

/// <summary>
/// The 'AbstractProductA' interface
/// </summary>


/// <summary>
/// The 'ProductA1' class
/// </summary>

/// <summary>
/// The 'Client' class 
/// </summary>
class VehicleClient
{
    Bike bike;
    Scooter scooter;

    public VehicleClient(VehicleFactory factory, string type)
    {
        bike = factory.GetBike(type);
        scooter = factory.GetScooter(type);
    }

    public string GetBikeName()
    {
        return bike.Name();
    }

    public string GetScooterName()
    {
        return scooter.Name();
    }

}

/// <summary>
/// Abstract Factory Pattern Demo
/// </summary>
class Program
{
    static void Main(string[] args)
    {

              
        /// Factory Design Patten

        IPaymentGateway gateway = PaymentGatewayFactoty.CreatePaymentGateway("Google");
        gateway.ProcessPayment(100);


        /// Singleton Design Patten
        Singleton fromTeachaer = Singleton.GetInstance();
        fromTeachaer.PrintDetails("From Teacher");
        //Call the GetInstance static method to get the Singleton Instance
        Singleton fromStudent = Singleton.GetInstance();
        fromStudent.PrintDetails("From Student");
        Console.ReadLine();


        SafeSingleton safeSingleton = SafeSingleton.GetInstance();
        safeSingleton.PrintDetails("Hello");

        //VehicleFactory honda = new HondaFactory();
        //VehicleClient hondaclient = new VehicleClient(honda, "Regular");

        //Console.WriteLine("******* Honda **********");
        //Console.WriteLine(hondaclient.GetBikeName());
        //Console.WriteLine(hondaclient.GetScooterName());

        //hondaclient = new VehicleClient(honda, "Sports");
        //Console.WriteLine(hondaclient.GetBikeName());
        //Console.WriteLine(hondaclient.GetScooterName());

        //VehicleFactory hero = new HeroFactory();
        //VehicleClient heroclient = new VehicleClient(hero, "Regular");

        //Console.WriteLine("******* Hero **********");
        //Console.WriteLine(heroclient.GetBikeName());
        //Console.WriteLine(heroclient.GetScooterName());

        //heroclient = new VehicleClient(hero, "Sports");
        //Console.WriteLine(heroclient.GetBikeName());
        //Console.WriteLine(heroclient.GetScooterName());

        Console.ReadKey();
    }
}

