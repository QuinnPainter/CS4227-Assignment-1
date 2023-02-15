namespace Framework
{
    public class Movie {
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        public const int CHILDREN = 2;

        private String title;
        private Price price = default!;

        public Movie(String title, int priceCode)
        {
            this.title = title;
            setPriceCode(priceCode);
        }

        public String getTitle()
        {
            return title;
        }

        private void setPriceCode(int priceCode)
        {
            switch (priceCode)
            {
                case REGULAR:
                    price = new RegularPrice();
                    break;
                case NEW_RELEASE:
                    price = new NewReleasePrice();
                    break;
                case CHILDREN:
                    price = new ChildrensPrice();
                    break;
            }
        }

        public double getCharge(int daysRented)
        {
            return price.getCharge(daysRented);
        }

        public int getFrequentRenterPoints(int daysRented)
        {
            return price.getFrequentRenterPoints(daysRented);
        }
    }
}
