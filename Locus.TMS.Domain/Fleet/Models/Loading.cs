using Locus.TMS.Domain.Common.Models;
using Locus.TMS.Domain.Fleet.Enums;
using System.Text.Json.Serialization;

namespace Locus.TMS.Domain.Fleet.Models
{
    public class Loading : ValueObject
    {
        public Loading(
            LoadingBody body,
            LoadingType type,
            double length,
            double width,
            double height,
            double heightExtended,
            double cargoVolume,
            double maxPayload,
            double gVWR,
            int passengerVolume
            )
        {
            Body = body;
            Type = type;
            Length = length;
            Width = width;
            Height = height;
            HeightExtended = heightExtended;
            CargoVolume = cargoVolume;
            MaxPayload = maxPayload;
            GVWR = gVWR;
            PassengerVolume = passengerVolume;
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LoadingBody Body { get; private set; } //Tipo de Carreta
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LoadingType Type { get; private set; }
        public double Length { get; private set; } //cm
        public double Width { get; private set; } //cm
        public double Height { get; private set; } //cm
        public double HeightExtended { get; private set; } //cm
        public double CargoVolume { get; private set; } //m3
        public double MaxPayload { get; private set; } //kg
        public double GVWR { get; private set; } //kg
        public int PassengerVolume { get; private set; } //qty

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Body;
            yield return Type;
            yield return Length;
            yield return Width;
            yield return Height;
            yield return HeightExtended;
            yield return CargoVolume;
            yield return MaxPayload;
            yield return GVWR;
            yield return PassengerVolume;
        }
    }
}