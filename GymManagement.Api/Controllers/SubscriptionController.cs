using GymManagement.Application.Subscriptions.Commands;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionController : ControllerBase
{
    private readonly ISender _mediator;

    public SubscriptionController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
    {
        var command = new CreateSubscriptionCommand(
            request.SubscriptionType.ToString(),
            request.AdminId);

        var subscriptionId = await _mediator.Send(command);

        var response = new SubscriptionResponce(
            subscriptionId, 
            request.SubscriptionType);

        return Ok(response);
    }
}
