namespace Locus.TMS.Domain.Fleet.DataTransferObjects;

public class FleetItem(
    Guid id, 
    string registrationNumber, 
    string name, 
    double carriageRate)
{
    public Guid Id { get; private set; } = id;
    public string RegistrationNumber { get; private set; } = registrationNumber;
    public string Name { get; private set; } = name;
    public double CarriageRate { get; private set; } = carriageRate;
}