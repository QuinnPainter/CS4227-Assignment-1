namespace Framework
{
    public class AddRentalContext
    {
        private Rental rental;
        private Customer customer;

        public AddRentalContext(Rental rental, Customer customer)
        {
            this.rental = rental;
            this.customer = customer;
        }

        public Rental getRental()
        {
            return rental;
        }

        public Customer getCustomer()
        {
            return customer;
        }
    }
}
