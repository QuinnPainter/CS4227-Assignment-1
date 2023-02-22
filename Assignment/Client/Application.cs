namespace Client
{
    public class Application
    {
        public void run()
        {
            Framework.AddRentalDispatcher.Instance.registerInterceptor(new AddRentalLogger());
        }
    }
}
