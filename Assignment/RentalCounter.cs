using MovieSystem;

namespace MovieSystem
{
    // Concrete Interceptor
    // Counts the total number of rentals added, and the total charge of all rentals.
    public class RentalCounter: IAddRentalInterceptor
    {
        private int rentalCount = 0;
        private double totalRentalCharge = 0;

        public void onAddRental(AddRentalContext context) {
            rentalCount += 1;
            totalRentalCharge += context.getRentalCharge();
            Console.WriteLine("Number of Rentals: " + rentalCount + ", Total Charge: " + totalRentalCharge);
        }

        public int getRentalCount()
        {
            return rentalCount;
        }
    }
}
