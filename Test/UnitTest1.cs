using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestRentalCounterInterceptor()
    {
        // Initialise interceptor
        var interceptor = new MovieSystem.RentalCounter();
        MovieSystem.AddRentalDispatcher.Instance.registerInterceptor(interceptor);
        int beforeRentalCount = interceptor.getRentalCount();

        // Add rental
        var cust = new MovieSystem.Customer("TestCustomer");
        var movie = new MovieSystem.Movie("TestMovie", MovieSystem.Movie.REGULAR);
        var rental = new MovieSystem.Rental(movie, 0);
        cust.addRental(rental);

        int afterRentalCount = interceptor.getRentalCount();
        Assert.IsTrue(afterRentalCount == beforeRentalCount + 1);
    }
}
