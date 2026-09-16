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
            Product product = new Product("Laptop", 350000, 20);
            Product product2 = new Product("Monitor", 120000, 15);
            Console.WriteLine(product);
            Console.WriteLine(product2);
            Student student = new Student("Kovács Péter;11A;82");
            Student student2 = new Student("Nagy Anna;10B;95");
            Console.WriteLine(student);
            Console.WriteLine(student2);

        }
    }
}
