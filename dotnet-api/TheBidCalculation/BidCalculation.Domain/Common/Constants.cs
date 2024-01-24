namespace BidCalculation.Domain.Common
{
    /// <summary>
    /// Basic constant values - we can move it to configurable files if we would require frequent change
    /// </summary>
    public class Constants
    {
        public const int BaseFeePercent = 10;//percentage value

        public const int CommonVehicleBasicsFeeMin = 10;
        public const int CommonVehicleBasicsFeeMax = 50;


        public const int LuxuryVehicleBasicsFeeMin = 25;
        public const int LuxuryVehicleBasicsFeeMax = 200;


        public const int CommonSellerSpecialFeePercent = 2;//fix value
        public const int LuxurySellerSpecialFeePercent = 4;

        public const int StorageFee = 100;
    }
}
