using Framework;

namespace Client
{
    // Concrete Interceptor
    public class AddRentalLogger: IAddRentalInterceptor
    {
        public void onAddRental(AddRentalContext context) {
            Console.WriteLine(context.getRental().getMovie().getTitle()
                + " was rented by "
                + context.getCustomer().getName());
        }
    }
}
