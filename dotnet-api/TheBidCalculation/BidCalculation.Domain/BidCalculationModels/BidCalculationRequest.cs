using System.ComponentModel.DataAnnotations;
using static BidCalculation.Common.Enums;

namespace BidCalculation.DTOs.BidCalculation
{
    /// <summary>
    /// Collection of properties of Bid calculation request
    /// </summary>
    public class BidCalculationRequest
    {
        /// <summary>
        /// Vehicle base price
        /// </summary>
        [Required]
        public double VehicleBasePrice { get; set; }
        /// <summary>
        /// Vehicle type
        /// </summary>
        [Required]
        public VehicleTypes VehicleType { get; set; }
    }
}
