namespace Interfaces
{
    public class Vehicle
    {
        public int PassengerCapacity { get; set; }
        public int Passengers { get; set; }
        /// <summary>
        /// Weight in kilograms
        /// </summary>
        /// <value></value>
        public int Weight { get; set; }

        public Vehicle (int passengerCapacity, int passengers, int weight) {
            this.PassengerCapacity = passengerCapacity;
            this.Passengers = passengers;
            this.Weight = weight;
        }

        public void AddPassengers(int newPassengers) {
            if (newPassengers + Passengers <= PassengerCapacity) {
                Passengers += newPassengers;
                return;
            }

            throw new MaxPassengerCapacityException();
        }

        public void RemovePassengers(int outPassengers) {
            this.Passengers -= outPassengers;
            this.Passengers < 0 ? this.Passengers = 0 : true;
        }
    }

    interface IFuel {
        double MaxFuelCapacity { get; set; }
        double Fuel { get; set; }

        double CalcFuelUsage (int distance);
        void FillFuel();
    }

    interface IMove {
        double Odometer { get; set; }
        
        void AddTravel(int metres);
        double EnergyUsed(int metres);
    }

    interface ICost {
        double CalcCost(int metres);
    }
}