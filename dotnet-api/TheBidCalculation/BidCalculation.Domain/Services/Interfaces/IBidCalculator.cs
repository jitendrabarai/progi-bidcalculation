using BidCalculation.DTOs.BidCalculation;

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
