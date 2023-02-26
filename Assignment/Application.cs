namespace MovieSystem
{
    public class Application
    {
        public void run()
        {
            MovieSystem.AddRentalDispatcher.Instance.registerInterceptor(new AddRentalLogger());
            MovieSystem.AddRentalDispatcher.Instance.registerInterceptor(new RentalCounter());
        }
    }
}
