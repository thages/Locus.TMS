using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Transportation.Enums;

namespace Locus.TMS.Domain.Transportation.Models
{
    public class EquipamentInformation : ValueObject
    {
        public EquipamentType EquipamentType { get; private set; }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
