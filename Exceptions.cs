using System;

namespace Interfaces
{
    public class MaxPassengerCapacityException: Exception
    {
        public MaxPassengerCapacityException(): base ("Passenger Capacity will exceed maximum passenger capacity") {}
    }
}