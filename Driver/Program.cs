class Driver
{
    static void Main(string[] args)
    {
        MovieSystem.AddRentalDispatcher.Instance.registerInterceptor(new MovieSystem.AddRentalLogger());
        MovieSystem.AddRentalDispatcher.Instance.registerInterceptor(new MovieSystem.RentalCounter());
        
        var movie1 = new MovieSystem.Movie("Shrek", MovieSystem.Movie.CHILDREN);
        var movie2 = new MovieSystem.Movie("Batman", MovieSystem.Movie.NEW_RELEASE);
        var cust1 = new MovieSystem.Customer("Dave");
        var cust2 = new MovieSystem.Customer("Bob");
        cust1.addRental(new MovieSystem.Rental(movie1, 4));
        cust2.addRental(new MovieSystem.Rental(movie2, 1));
        cust1.addRental(new MovieSystem.Rental(movie2, 3));
    }
}
