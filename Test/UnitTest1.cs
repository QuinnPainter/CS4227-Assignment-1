using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestCustomerAddRental()
    {
        var cust = new Framework.Customer("TestCustomer");
        var movie = new Framework.Movie("TestMovie", Framework.Movie.REGULAR);
        var rental = new Framework.Rental(movie, 0);
        cust.addRental(rental);
        Assert.IsTrue(cust.getRentals().Contains(rental));
    }
}
