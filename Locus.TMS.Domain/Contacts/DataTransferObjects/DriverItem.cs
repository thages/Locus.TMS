using Locus.TMS.Domain.Contacts.Models;

namespace Locus.TMS.Domain.Contacts.DataTransferObjects
{
    public class DriverItem
    {
        public DriverItem(
            Guid id,
            string firstName,
            string lastName,
            string driverLicense,
            string email,
            string phone,
            Address address,
            Guid? carrierId
            )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DriverLicense = driverLicense;
            Email = email;
            Phone = phone;
            Address = address;
            CarrierId = carrierId;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DriverLicense { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
        public Guid? CarrierId { get; private set; }
    }
}
