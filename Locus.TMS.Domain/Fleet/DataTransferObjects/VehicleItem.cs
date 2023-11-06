using Locus.TMS.Domain.Common.Enums;
using Locus.TMS.Domain.Fleet.Enums;
using Locus.TMS.Domain.Fleet.Models;
using System.Text.Json.Serialization;

namespace Locus.TMS.Domain.DataTransferObjects.Fleet
{
    public class VehicleItem
    {
        public VehicleItem(
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
            VehicleType type
            )
        {
            Id = id;
            RegistrationNumber = registrationNumber;
            Name = name;
            CarriageRate = carriageRate;
            Currency = currency;
            Comments = comments;
            ContractorId = contractorId;
            DriverId = driverId;
            Loading = loading;
            Model = model;
            Fuel = fuel;
            Type = type;
        }

        public Guid Id { get; private set; }
        public string RegistrationNumber { get; private set; }
        public string Name { get; private set; }
        public double CarriageRate { get; private set; }
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Currency Currency { get; private set; }
        public string Comments { get; private set; }
        public Guid ContractorId { get; private set; }
        public Guid DriverId { get; private set; }
        public Loading Loading { get; private set; }
        public Model Model { get; private set; }
        public Fuel Fuel { get; private set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VehicleType Type { get; private set; }
    }
}
