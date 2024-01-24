// It's used to serves as the root component, providing the structure and behavior for the entire application.
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ApiService } from 'src/app/services/api.service';
import { ConstantService } from 'src/app/services/constant.service';
import { BidCalculationRequest, BidCalculationResponse } from 'src/app/models/formdetails.model';

@Component({
  selector: 'app-formdetails',
  templateUrl: './formdetails.component.html',
  styleUrls: ['./formdetails.component.scss']
})
export class FormdetailsComponent implements OnInit {

  // FormGroup for the form
  calculationfrm: any = FormGroup;

  // Flag to track form submission
  isSubmitted: boolean = false;

  // Object to hold the calculation response
  calculationresp!: BidCalculationResponse;

  // Constructor with dependency injection
  constructor(
    private api: ApiService,
    private constant: ConstantService,
    private formBuilder: FormBuilder,
  ) {}

  // Lifecycle hook - ngOnInit
  ngOnInit(): void {
    // Initialize the form group with form controls and validators
    this.calculationfrm = this.formBuilder.group({
      vehicleBasePrice: ['', [Validators.required]],
      vehicleType: ['0', [Validators.required]]
    });
  }

  // Getter function to easily access form controls for validation
  get f() {
    return this.calculationfrm.controls;
  }

  // Function to handle the calculation response
  getCalculationResponse() {
    // Set form submission flag to true
    this.isSubmitted = true;

    // Check if the form is invalid
    if (this.calculationfrm.invalid) {
      return;
    } else {
      // Prepare the request body
      let body: BidCalculationRequest = {
        vehicleBasePrice: parseFloat(this.calculationfrm.value.vehicleBasePrice),
        vehicleType: parseInt(this.calculationfrm.value.vehicleType),
      };

      // Call API to get calculation response
      this.api.callApi(this.constant.CalculateBid, body, 'POST').subscribe(
        // Success callback
        (res: any) => {
          // Assign the response to the calculationresp property
          this.calculationresp = res;
          // Reset the form submission flag to false
          this.isSubmitted = false;
        },
        // Error callback
        (err: any) => {
          // Handle errors as needed
        }
      );
    }
  }
}
