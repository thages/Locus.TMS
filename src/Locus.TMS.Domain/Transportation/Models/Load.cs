using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Transportation.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locus.TMS.Domain.Transportation.Models
{
    public class Load : EntityModel
    {
        public Load() { }

        [NotMapped]
        public LoadStatus? LoadStatus
        {
            get => _LoadStatus == null ? null : JsonConvert.DeserializeObject<LoadStatus>(_LoadStatus);
            set { _LoadStatus = JsonConvert.SerializeObject(value); }
        }

        public string _LoadStatus { get; private set; }

        [NotMapped]
        public VehicleStatus? VehicleStatus 
        {
            get => _VehicleStatus == null ? null : JsonConvert.DeserializeObject<VehicleStatus>(_VehicleStatus);
            set { _VehicleStatus = JsonConvert.SerializeObject(value); }
        }

        public string _VehicleStatus { get; private set; }

        public string LoadReferenceId { get; private set; }

        [NotMapped]
        public Commodity? Commodity 
        { 
            get => _Commodity == null ? null : JsonConvert.DeserializeObject<Commodity>(_Commodity);
            set { _Commodity = JsonConvert.SerializeObject(value); } 
        }

        public string _Commodity { get; private set; }
        public double DeclaredValue { get; private set; }
        public LoadCapacity LoadCapacity { get; private set; }
        public LoadCondition LoadCondition { get; private set; }
        public EquipamentInformation EquipamentInformation { get; private set; }
        public EquipamentSize EquipamentSize { get; private set; }
        public string PublicNote { get; private set; }
        public string PrivateNote { get; private set; }
        public string PostingNotes { get; private set; }

    }
}
