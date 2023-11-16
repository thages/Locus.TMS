using Locus.TMS.Domain.Common.Models;

namespace Locus.TMS.Domain.Contacts.Models
{
    public class Driver : EntityModel
    {
        protected Driver() { }
        public Driver(
            string firstName, 
            string lastName, 
            string driverLicense, 
            string email, 
            string phone, 
            Address address, 
            Guid? carrierId
            )
        {
            FirstName = firstName;
            LastName = lastName;
            DriverLicense = driverLicense;
            Email = email;
            Phone = phone;
            Address = address;
            CarrierId = carrierId;
        }


        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DriverLicense { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
        public Guid? CarrierId { get; private set; }

    }
}
