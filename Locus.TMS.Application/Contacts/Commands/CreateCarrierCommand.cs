using Locus.TMS.Application.Common.Commands;
using Locus.TMS.Domain.Contacts.Models;

namespace Locus.TMS.Application.Contacts.Commands
{
    public class CreateCarrierCommand : IApplicationCommand<Carrier>
    {
        public CreateCarrierCommand(
            string companyName, 
            string shortName, 
            string email, 
            string phone, 
            string website, 
            Address address, 
            Responsible responsible
            )
        {
            CompanyName = companyName;
            ShortName = shortName;
            Email = email;
            Phone = phone;
            Website = website;
            Address = address;
            Responsible = responsible;
        }

        public string CompanyName { get; private set; }
        public string ShortName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Website { get; private set; }
        public Address Address { get; private set; }
        public Responsible Responsible { get; private set; }
    }
}
