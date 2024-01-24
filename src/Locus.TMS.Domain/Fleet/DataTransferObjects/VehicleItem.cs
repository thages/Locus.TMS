using System.Text.Json.Serialization;
using Locus.TMS.Domain.Common.Enums;
using Locus.TMS.Domain.Fleet.Enums;
using Locus.TMS.Domain.Fleet.Models;

namespace Locus.TMS.Domain.Fleet.DataTransferObjects
{
    public class VehicleItem(
        Guid id,
        string registrationNumber,
        string name,
        double carriageRate,
        Currency currency,
        string comments,
        Guid contractorId,
        Guid driverId,
        Loading loading,
        Model model,
        Fuel fuel,
        VehicleType type)
    {
        public Guid Id { get; private set; } = id;
        public string RegistrationNumber { get; private set; } = registrationNumber;
        public string Name { get; private set; } = name;
        public double CarriageRate { get; private set; } = carriageRate;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Currency Currency { get; private set; } = currency;

        public string Comments { get; private set; } = comments;
        public Guid ContractorId { get; private set; } = contractorId;
        public Guid DriverId { get; private set; } = driverId;
        public Loading Loading { get; private set; } = loading;
        public Model Model { get; private set; } = model;
        public Fuel Fuel { get; private set; } = fuel;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VehicleType Type { get; private set; } = type;
    }
}
