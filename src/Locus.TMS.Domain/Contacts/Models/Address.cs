using Locus.TMS.Domain.Common.Models;

namespace Locus.TMS.Domain.Contacts.Models
{
    public class Address : ValueObject
    {
        public Address(
            Guid countryId, 
            Guid stateId, 
            Guid cityId, 
            string postalCode, 
            string street, 
            int number, 
            string additional
            )
        {
            CountryId = countryId;
            StateId = stateId;
            CityId = cityId;
            PostalCode = postalCode;
            Street = street;
            Number = number;
            Additional = additional;
        }

        public Guid CountryId { get; private set; }
        public Guid StateId { get; private set; }
        public Guid CityId { get; private set; }
        public string PostalCode { get; private set; }
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string Additional { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CountryId;
            yield return StateId;
            yield return CityId;
            yield return PostalCode;
            yield return Street;
            yield return Number;
            yield return Additional;
        }
    }
}