using Locus.TMS.Domain.Common.Enums;

namespace Locus.TMS.Domain.Transportation.Enums
{
    public class Commodity : Enumeration
    {
        protected const int DRY = 1;
        protected const int HAZARDOUS = 2;
        protected const int HIGH_VALUE = 3;
        protected const int LIQUID = 4;
        protected const int LIVESTOCK = 5;
        protected const int TEMPERATURE_CONTROLLED = 6;


        

        protected Commodity() { }
        protected Commodity(int value, string displayName) : base(value, displayName) { }
    }
}
