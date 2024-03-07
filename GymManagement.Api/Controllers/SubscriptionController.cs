using GymManagement.Application.Services;
using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionController : ControllerBase
{
    private readonly ISubscriptionsService _subscriptionsService;

    public SubscriptionController(ISubscriptionsService subscriptionsService)
    {
        _subscriptionsService = subscriptionsService;
    }

    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        var subscriptionId = _subscriptionsService.CreateSubscription(
            request.SubscriptionType.ToString(),
            request.AdminId);

        var response = new SubscriptionResponce(
            subscriptionId, 
            request.SubscriptionType);

        return Ok(response);
    }
}
