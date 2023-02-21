namespace Framework
{
    public class AddRentalDispatcher
    {
        private List<IAddRentalInterceptor> interceptors = new List<IAddRentalInterceptor>();

        public void registerInterceptor(IAddRentalInterceptor i)
        {
            interceptors.Add(i);
        }

        public void unregisterInterceptor(IAddRentalInterceptor i)
        {
            interceptors.Remove(i);
        }

        private void dispatchInterceptors()
        {
            foreach (IAddRentalInterceptor i in interceptors)
            {
                i.onAddRental(/*context*/);
            }
        }
    }
}
