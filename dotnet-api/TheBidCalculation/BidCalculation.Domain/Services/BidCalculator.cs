using BidCalculation.Domain.BaseCalculator;
using BidCalculation.Domain.Common;
using BidCalculation.Domain.Services.Interfaces;
using BidCalculation.DTOs.BidCalculation;

namespace BidCalculation.Domain.Services
{
    /// <summary>
    /// Implemenation of IBidCalculator inteface
    /// </summary>
    public class BidCalculator : IBidCalculator
    {
        public BidCalculationResponse CalculateBid(BidCalculationRequest bidCalculationRequest)
        {
            BidCalculationResponse bidCalculationResponse = new()
            {
                StorageFees = Constants.StorageFee,
                VehicleBasePrice = bidCalculationRequest.VehicleBasePrice,
                AssociationFees = Shared.GetAssociationFee(bidCalculationRequest.VehicleBasePrice)
            };

            switch (bidCalculationRequest.VehicleType)
            {
                case BidCalculation.Common.Enums.VehicleTypes.Common:
                    {
                        CommonVehicle commonVehicle = new(bidCalculationRequest.VehicleBasePrice);
                        bidCalculationResponse.SpecialFees = commonVehicle.CalculateSpecialFee();
                        bidCalculationResponse.BasicFees = commonVehicle.CalculateBasicFee();
                    }
                    break;
                case BidCalculation.Common.Enums.VehicleTypes.Luxury:
                    {
                        LuxuryVehicle luxuryVehicle = new(bidCalculationRequest.VehicleBasePrice);
                        bidCalculationResponse.SpecialFees = luxuryVehicle.CalculateSpecialFee();
                        bidCalculationResponse.BasicFees = luxuryVehicle.CalculateBasicFee();
                    }
                    break;
            }

            return bidCalculationResponse;
        }
    }
}