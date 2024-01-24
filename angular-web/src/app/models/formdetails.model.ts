export interface BidCalculationResponse {
    vehicleBasePrice: number;
    basicFees: number;
    specialFees: number;
    associationFees: number;
    storageFees: number;
    total: number;
  }
  
  export interface BidCalculationRequest {
    vehicleBasePrice: number;
    vehicleType: number;
  }
  