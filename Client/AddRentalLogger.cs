namespace Client
{
    // Concrete Interceptor
    public class AddRentalLogger: Framework.IAddRentalInterceptor
    {
        public void onAddRental(/*context here*/) {
            Console.WriteLine("intercepted");
        }
    }
}
