using MovieSystem;

namespace MovieSystem
{
    // Concrete Interceptor
    // Logs all Add Rental transations to the console.
    public class AddRentalLogger: IAddRentalInterceptor
    {
        public void onAddRental(AddRentalContext context) {
            Console.WriteLine(context.getRentalTitle()
                + " was rented by "
                + context.getCustomerName());
        }
    }
}
