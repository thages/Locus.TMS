using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Transportation.Enums;

namespace Locus.TMS.Domain.Transportation.Models
{
    public class Load : EntityModel
    {
        public Load() { }

        public LoadStatus LoadStatus { get; private set; }
        public VehicleStatus VehicleStatus { get; private set; }
        public string LoadReferenceId { get; private set; }
        public Commodity Commodity { get; private set; }
        public double DeclaredValue { get; private set; }
        public LoadSize LoadSize { get; private set; }
        public LoadCondition LoadCondition { get; private set; }
        public EquipamentInformation EquipamentInformation { get; private set; }
        public EquipamentLength EquipamentLength { get; private set; }


    }
}
