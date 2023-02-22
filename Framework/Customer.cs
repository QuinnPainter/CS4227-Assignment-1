namespace Framework
{
    public class Customer
    {
        private String name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void addRental(Rental rental)
        {
            rentals.Add(rental);
            AddRentalDispatcher.Instance.dispatchInterceptors();
        }

        public String statement()
        {
            String result = "Rental Record for " + getName() + "\n";
            foreach (Rental rental in rentals)
            {
                result += "\t" + rental.getMovie().getTitle() + "\t" + rental.getCharge() + "\n";
            }
            result += "Amount owed is " + getTotalCharge() + "\n";
            result += "You earned " + getTotalFrequentRenterPoints() + " frequent renter points";
            return result;
        }

        public String htmlStatement()
        {
            String result = "<H1>Rentals for <EM>" + getName() + "</EM></H1><P>\n";
            foreach (Rental rental in rentals)
            {
                result += rental.getMovie().getTitle() + ": " + rental.getCharge() + "<BR>\n";
            }
            result += "<P>You owe <EM>" + getTotalCharge() + "</EM></P>";
            result += "<P>On this rental you earned <EM>" + getTotalFrequentRenterPoints()
                + "</EM> frequent renter points</P>";
            return result;
        }

        private double getTotalCharge()
        {
            double total = 0;
            foreach (Rental rental in rentals)
            {
                total += rental.getCharge();
            }
            return total;
        }

        private int getTotalFrequentRenterPoints()
        {
            int total = 0;
            foreach (Rental rental in rentals)
            {
                total += rental.getFrequentRenterPoints();
            }
            return total;
        }
    }
}
