﻿using ErrorOr;

namespace GymManagement.Domain.Gyms;

public class GymErrors
{
    public static readonly Error CannotHaveMoreRoomsThanSubscriptionAllows = Error.Validation(
    "Room.CannotHaveMoreRoomsThanSubscriptionAllows",
    "A gym cannot have more rooms than the subscription allows");

}
