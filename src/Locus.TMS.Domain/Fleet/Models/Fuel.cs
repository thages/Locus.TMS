using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Fleet.Enums;

namespace Locus.TMS.Domain.Fleet.Models
{
    public class Fuel : ValueObject
    {
        public Fuel(
            FuelKind kind,
            string quality,
            int tankCapacity,
            double consumptionCity,
            double consumptionHighway,
            double consumptionCombined
            )
        {
            Kind = kind;
            Quality = quality;
            TankCapacity = tankCapacity;
            ConsumptionCity = consumptionCity;
            ConsumptionHighway = consumptionHighway;
            ConsumptionCombined = consumptionCombined;
        }

        public FuelKind Kind { get; private set; }
        public string Quality { get; private set; }
        public int TankCapacity { get; private set; } //L
        public double ConsumptionCity { get; private set; } // L/100km
        public double ConsumptionHighway { get; private set; } // L/100km
        public double ConsumptionCombined { get; private set; } // L/100km
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Kind;
            yield return Quality;
            yield return TankCapacity;
            yield return ConsumptionCity;
            yield return ConsumptionHighway;
            yield return ConsumptionCombined;
        }
    }
}