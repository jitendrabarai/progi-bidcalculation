namespace BidCalculation.Domain.Common
{
    public static class Shared
    {
        public static double GetAssociationFee(double basePrice)
        {
            return basePrice switch
            {
                >= 1 and <= 500 => 5,
                > 500 and <= 1000 => 10,
                > 1000 and <= 3000 => 15,
                _ => 20 // default value
            };
        }
    }
}
