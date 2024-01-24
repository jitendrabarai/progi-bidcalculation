using BidCalculation.Common;
using BidCalculation.Domain.Services.Interfaces;
using BidCalculation.DTOs.BidCalculation;
using Microsoft.AspNetCore.Mvc;

namespace BidCalculation.Controllers
{
    /// <summary>
    /// Handles the bid calculation requests
    /// </summary>
    /// <inheritdoc/>
    [Route("[controller]")]
    [ApiController]
    public class CalculateBidController(IBidCalculator bidCalculator) : ControllerBase
    {
        private readonly IBidCalculator _bidCalculator = bidCalculator;

        // GET: CalculateBidController
        /// <summary>
        /// Calculates the bid parameters based on provided inputs
        /// </summary>
        /// <param name="request">Request paramteres</param>
        /// <returns>Returns calculated bid parameters</returns>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BidCalculationResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public IActionResult Post(BidCalculationRequest request)
        {
            if (ModelState.IsValid && request.VehicleBasePrice > 0)
            {
                var response = _bidCalculator.CalculateBid(request);
                return Ok(response);
            }
            else
            {
                return BadRequest(new BaseResponse { Message = "Invalid request parameters" });//we can manipulate ModelState class here for detailed error and can return, for simplicity I just used static message
            }
        }
    }
}
