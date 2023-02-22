namespace Assigment
{
    class Driver
    {
        static void Main(string[] args)
        {
            var app = new Client.Application();
            app.run();

            var movie1 = new Framework.Movie("Shrek", Framework.Movie.CHILDREN);
            var movie2 = new Framework.Movie("Batman", Framework.Movie.NEW_RELEASE);
            var cust1 = new Framework.Customer("Dave");
            var cust2 = new Framework.Customer("Bob");
            cust1.addRental(new Framework.Rental(movie1, 4));
            cust2.addRental(new Framework.Rental(movie2, 1));
            cust1.addRental(new Framework.Rental(movie2, 3));
        }
    }
}
