namespace BidCalculation.DTOs.BidCalculation
{
    /// <summary>
    /// Collection of properties of Bid calculation response
    /// </summary>
    public class BidCalculationResponse
    {
        public double VehicleBasePrice { get; set; }
        public double BasicFees { get; set; }
        public double SpecialFees { get; set; }
        public double AssociationFees { get; set; }
        public double StorageFees { get; set; }
        public double Total => VehicleBasePrice + BasicFees + SpecialFees + AssociationFees + StorageFees;
    }
}
