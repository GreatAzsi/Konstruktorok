namespace Konstruktorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bodri", "Labrador", 5);
            Dog dog2 = new Dog("Morzsi", "Beagle", 3);
            Console.WriteLine(dog);
            Console.WriteLine(dog2);
            Phone phone = new Phone("Samsung", "Galaxy S24");
            Phone phone2 = new Phone("Apple", "iPhone 16", 350000);
            Console.WriteLine(phone);
            Console.WriteLine(phone2);
            Player player = new Player("Steve");
            Player player2 = new Player("Alex", 5, 1200);
            Console.WriteLine(player);
            Console.WriteLine(player2);
            Car car = new Car("Toyota", "Corolla", 2018);
            Car car2 = new Car("BMW", "320i", 2021);
            Console.WriteLine(car);
            Console.WriteLine(car2);
            Movie movie = new Movie("Interstellar", 8.7);
            Movie movie2 = new Movie("Minecraft Movie", 5.6);
            Console.WriteLine(movie);
            Console.WriteLine(movie2);
        }
    }
}
