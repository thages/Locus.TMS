using Locus.TMS.Application.Common.Commands;
using Locus.TMS.Domain.Common.Enums;
using Locus.TMS.Domain.Fleet.DataTransferObjects;
using Locus.TMS.Domain.Fleet.Enums;
using Locus.TMS.Domain.Fleet.Models;

namespace Locus.TMS.Application.Commands.Fleet
{
    public class CreateVehicleCommand : IApplicationCommand<VehicleItem>
    {
        public CreateVehicleCommand(
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

        public string RegistrationNumber { get; private set; }
        public string Name { get; private set; }
        public double CarriageRate { get; private set; }
        public Currency Currency { get; private set; }
        public string Comments { get; private set; }
        public Guid ContractorId { get; private set; }
        public Guid DriverId { get; private set; }
        public Loading Loading { get; private set; }
        public Model Model { get; private set; }
        public Fuel Fuel { get; private set; }
        public VehicleType Type { get; private set; }
    }
}
