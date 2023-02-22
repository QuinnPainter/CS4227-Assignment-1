namespace Assigment
{
    class Driver
    {
        static void Main(string[] args)
        {
            var app = new Client.Application();
            app.run();
            Console.WriteLine("Hello, World!");
            var m = new Framework.Movie("hello", Framework.Movie.CHILDREN);
            var c = new Framework.Customer("Dave");
            c.addRental(new Framework.Rental(m, 4));
            Console.WriteLine(c.htmlStatement());
        }
    }
}
