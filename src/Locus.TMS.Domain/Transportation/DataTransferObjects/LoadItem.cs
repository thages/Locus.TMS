using Locus.TMS.Domain.Transportation.Enums;
using Locus.TMS.Domain.Transportation.Models;
using System.Text.Json.Serialization;


namespace Locus.TMS.Domain.Transportation.DataTransferObjects
{
    public class LoadItem
    {
        public LoadItem(
            Guid id, 
            LoadStatus loadStatus, 
            VehicleStatus vehicleStatus, 
            string loadReferenceId, 
            Commodity commodity, 
            double declaredValue, 
            LoadCapacity loadCapacity, 
            LoadCondition loadCondition, 
            EquipamentInformation equipamentInformation, 
            EquipamentSize equipamentSize, 
            string publicNote, 
            string privateNote, 
            string postingNotes)
        {
            Id = id;
            LoadStatus = loadStatus;
            VehicleStatus = vehicleStatus;
            LoadReferenceId = loadReferenceId;
            Commodity = commodity;
            DeclaredValue = declaredValue;
            LoadCapacity = loadCapacity;
            LoadCondition = loadCondition;
            EquipamentInformation = equipamentInformation;
            EquipamentSize = equipamentSize;
            PublicNote = publicNote;
            PrivateNote = privateNote;
            PostingNotes = postingNotes;
        }

        public Guid Id { get; private set; }
        public LoadStatus LoadStatus { get; private set; }
        public VehicleStatus VehicleStatus { get; private set; }
        public string LoadReferenceId { get; private set; }
        public Commodity Commodity { get; private set; }
        public double DeclaredValue { get; private set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LoadCapacity LoadCapacity { get; private set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LoadCondition LoadCondition { get; private set; }
        public EquipamentInformation EquipamentInformation { get; private set; }
        public EquipamentSize EquipamentSize { get; private set; }
        public string PublicNote { get; private set; }
        public string PrivateNote { get; private set; }
        public string PostingNotes { get; private set; }
    }
}
