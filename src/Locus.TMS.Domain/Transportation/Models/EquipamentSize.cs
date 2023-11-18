using Locus.TMS.Domain.Common.Models;

namespace Locus.TMS.Domain.Transportation.Models
{
    public class EquipamentSize : ValueObject
    {
        public EquipamentSize(
            double length, 
            double width, 
            double height, 
            double weightGross, 
            double weightNet, 
            double cubature, 
            double loadingMetre, 
            int quantity
            )
        {
            Length = length;
            Width = width;
            Height = height;
            WeightGross = weightGross;
            WeightNet = weightNet;
            Cubature = cubature;
            LoadingMetre = loadingMetre;
            Quantity = quantity;
        }

        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double WeightGross { get; private set; }
        public double WeightNet { get; private set; }
        public double Cubature { get; private set; }
        public double LoadingMetre { get; private set; } //LDM
        public int Quantity { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Length;
            yield return Width;
            yield return Height;
            yield return WeightGross;
            yield return WeightNet;
            yield return Cubature;
            yield return LoadingMetre;
            yield return Quantity;
        }
    }
}
