using BidCalculation.DTOs.BidCalculation;
using static BidCalculation.Common.Enums;

namespace BidCalculation.Domain.Services.Interfaces
{
    /// <summary>
    /// Inteface for defination of calculator
    /// </summary>
    public interface IBidCalculator
    {
        BidCalculationResponse CalculateBid(BidCalculationRequest bidCalculationRequest);
    }
}
