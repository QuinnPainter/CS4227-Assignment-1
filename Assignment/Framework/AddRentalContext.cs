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

        public string getRentalTitle()
        {
            return rental.getMovie().getTitle();
        }

        public double getRentalCharge()
        {
            return rental.getCharge();
        }

        public string getCustomerName()
        {
            return customer.getName();
        }
    }
}
