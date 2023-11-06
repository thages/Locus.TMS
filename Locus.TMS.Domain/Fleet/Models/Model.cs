using Locus.TMS.Domain.Common.Models;

namespace Locus.TMS.Domain.Fleet.Models
{
    public class Model : ValueObject
    {
        public Model(
            string make,
            string name,
            int year,
            string trimLevel,
            string vIN,
            int odometerReading,
            DateTimeOffset odometerReadingDate,
            double length,
            double width,
            double height,
            double heightExtened
            )
        {
            Make = make;
            Name = name;
            Year = year;
            TrimLevel = trimLevel;
            VIN = vIN;
            OdometerReading = odometerReading;
            OdometerReadingDate = odometerReadingDate;
            Length = length;
            Width = width;
            Height = height;
            HeightExtened = heightExtened;
        }

        public string Make { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }
        public string TrimLevel { get; private set; }
        public string VIN { get; private set; }
        public int OdometerReading { get; private set; } //km
        public DateTimeOffset OdometerReadingDate { get; private set; }
        public double Length { get; private set; } //cm
        public double Width { get; private set; } //cm
        public double Height { get; private set; } //cm
        public double HeightExtened { get; private set; } //cm

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Make;
            yield return Name;
            yield return Year;
            yield return TrimLevel;
            yield return VIN;
            yield return OdometerReading;
            yield return OdometerReadingDate;
            yield return Length;
            yield return Width;
            yield return Height;
            yield return HeightExtened;
        }
    }
}