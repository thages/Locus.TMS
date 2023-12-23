using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Transportation.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Locus.TMS.Domain.Transportation.Models
{
    public class EquipamentInformation : ValueObject
    {
        public EquipamentInformation(
            EquipamentType? equipamentType, 
            double temperature, 
            string containerNumber, 
            DateTimeOffset lastFreeDay
            )
        {
            EquipamentType = equipamentType;
            Temperature = temperature;
            ContainerNumber = containerNumber;
            LastFreeDay = lastFreeDay;
        }

        private EquipamentInformation() { }
        
        [NotMapped]
        public EquipamentType? EquipamentType
        {
            get => _EquipamentType == null ? null : JsonSerializer.Deserialize<EquipamentType>(_EquipamentType);
            set { _EquipamentType = JsonSerializer.Serialize(value); }
        }

        [JsonIgnore]
        public string _EquipamentType { get; private set; }
        public double Temperature { get; private set; }
        public string ContainerNumber { get; private set; }
        public DateTimeOffset LastFreeDay { get; private set; }

       
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return EquipamentType;
            yield return Temperature;
            yield return ContainerNumber;
            yield return LastFreeDay;
        }
    }
}
