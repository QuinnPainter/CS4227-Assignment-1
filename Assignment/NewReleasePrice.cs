namespace MovieSystem
{
    public class NewReleasePrice : Price
    {
        public override int getPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override double getCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int getFrequentRenterPoints(int daysRented)
        {
            return (daysRented > 1) ? 2 : 1;
        }
    }
}
