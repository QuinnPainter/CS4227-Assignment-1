namespace MovieSystem
{
    public abstract class Price
    {
        public abstract int getPriceCode();
        public abstract double getCharge(int daysRented);

        public virtual int getFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}
