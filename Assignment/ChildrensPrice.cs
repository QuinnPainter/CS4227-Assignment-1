namespace MovieSystem
{
    public class ChildrensPrice : Price
    {
        public override int getPriceCode()
        {
            return Movie.CHILDREN;
        }

        public override double getCharge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;
            }
            return result;
        }
    }
}
