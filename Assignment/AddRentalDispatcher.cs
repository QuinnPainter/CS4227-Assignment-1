namespace MovieSystem
{
    public sealed class AddRentalDispatcher
    {
        // Singleton pattern
        private static AddRentalDispatcher? instance;

        public static AddRentalDispatcher Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddRentalDispatcher();
                }
                return instance;
            }
        }

        // Private constructor so object can only be used through singleton
        private AddRentalDispatcher() {}

        private List<IAddRentalInterceptor> interceptors = new List<IAddRentalInterceptor>();

        public void registerInterceptor(IAddRentalInterceptor i)
        {
            interceptors.Add(i);
        }

        public void unregisterInterceptor(IAddRentalInterceptor i)
        {
            interceptors.Remove(i);
        }

        public void dispatchInterceptors(Rental rental, Customer customer)
        {
            AddRentalContext context = new AddRentalContext(rental, customer);
            foreach (IAddRentalInterceptor i in interceptors)
            {
                i.onAddRental(context);
            }
        }
    }
}
