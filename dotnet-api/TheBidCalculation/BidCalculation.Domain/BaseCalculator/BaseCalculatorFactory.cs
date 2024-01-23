using BidCalculation.Domain.Common;
namespace BidCalculation.Domain.BaseCalculator
{
    /// <summary>
    /// Base class for calculations, as per requirement we can add more calculation of tax, import duty etc.
    /// </summary>
    public abstract class BaseCalculatorFactory
    {
        public double BasePrice { get; set; }

        public abstract double CalculateBasicFee();

        public abstract double CalculateSpecialFee();
    }

    /// <summary>
    /// Implementaion class for Common Vehicle
    /// </summary>
    public class CommonVehicle : BaseCalculatorFactory
    {

        public CommonVehicle(double basePrice)
        {
            this.BasePrice = basePrice;
        }
        public override double CalculateSpecialFee()
        {
            return (BasePrice * Constants.CommonSellerSpecialFeePercent) / 100;
        }

        public override double CalculateBasicFee()
        {
            var baseFee = (BasePrice * Constants.BaseFeePercent) / 100;
            return baseFee <= Constants.CommonVehicleBasicsFeeMin ? Constants.CommonVehicleBasicsFeeMin : baseFee >= Constants.CommonVehicleBasicsFeeMax ? Constants.CommonVehicleBasicsFeeMax : baseFee;
        }
    }


    /// <summary>
    /// Implementaion class for Luxury Vehicle
    /// </summary>
    public class LuxuryVehicle : BaseCalculatorFactory
    {

        public LuxuryVehicle(double basePrice)
        {
            this.BasePrice = basePrice;
        }
        public override double CalculateSpecialFee()
        {
            return (BasePrice * Constants.LuxurySellerSpecialFeePercent) / 100;
        }

        public override double CalculateBasicFee()
        {
            var baseFee = (BasePrice * Constants.BaseFeePercent) / 100;
            return baseFee <= Constants.LuxuryVehicleBasicsFeeMin ? Constants.LuxuryVehicleBasicsFeeMin : baseFee >= Constants.LuxuryVehicleBasicsFeeMax ? Constants.LuxuryVehicleBasicsFeeMax : baseFee;
        }
    }


    /// <summary>
    /// We can have more class based on vehicle types
    /// </summary>
    public class SuperUltrLuxuryVehicle : BaseCalculatorFactory
    {
        public override double CalculateBasicFee()
        {
            throw new NotImplementedException();
        }

        public override double CalculateSpecialFee()
        {
            throw new NotImplementedException();
        }
    }

}
