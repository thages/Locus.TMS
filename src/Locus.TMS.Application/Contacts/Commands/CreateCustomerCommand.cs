using Locus.TMS.Application.Common.Commands;
using Locus.TMS.Domain.Contacts.Enums;
using Locus.TMS.Domain.Contacts.Models;

namespace Locus.TMS.Application.Contacts.Commands
{
    public class CreateCustomerCommand : IApplicationCommand<Customer>
    {
        public CreateCustomerCommand(
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
