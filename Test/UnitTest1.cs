using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestRentalCounterInterceptor()
    {
        // Initialise interceptor
        var interceptor = new Client.RentalCounter();
        Framework.AddRentalDispatcher.Instance.registerInterceptor(interceptor);
        int beforeRentalCount = interceptor.getRentalCount();

        // Add rental
        var cust = new Framework.Customer("TestCustomer");
        var movie = new Framework.Movie("TestMovie", Framework.Movie.REGULAR);
        var rental = new Framework.Rental(movie, 0);
        cust.addRental(rental);

        int afterRentalCount = interceptor.getRentalCount();
        Assert.IsTrue(afterRentalCount == beforeRentalCount + 1);
    }
}
