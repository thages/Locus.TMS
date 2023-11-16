using Locus.TMS.Domain.Common.Models;

namespace Locus.TMS.Domain.Contacts.Models
{
    public class Responsible : ValueObject
    {
        public Responsible(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Phone;
            yield return Email;
        }
    }
}