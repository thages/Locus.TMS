using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Contacts.Enums;

namespace Locus.TMS.Domain.Contacts.Models
{
    public class Customer : EntityModel
    {
        public Customer() { } 
        public Customer(
            string name, 
            string phone, 
            string email, 
            PersonType personType, 
            Address address
            )
        {
            Name = name;
            Phone = phone;
            Email = email;
            PersonType = personType;
            Address = address;
        }

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public PersonType PersonType { get; private set; }
        public Address Address { get; private set; }

    }
}
