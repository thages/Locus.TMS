using Locus.TMS.Domain.Common.Enums;

namespace Locus.TMS.Domain.Transportation.Enums
{
    public abstract class Commodity : Enumeration
    {
        protected const int DRY = 1;
        protected const int HAZARDOUS = 2;
        protected const int HIGH_VALUE = 3;
        protected const int LIQUID = 4;
        protected const int LIVESTOCK = 5;
        protected const int TEMPERATURE_CONTROLLED = 6;

        protected Commodity() { }
        protected Commodity(int value, string displayName) : base(value, displayName) { }

        public static readonly Commodity DryGoodsFood = new Dry(0, "Dry Goods (Food)");
        public static readonly Commodity DryGoodsGeneral = new Dry(1, "Dry Goods (General)");
        public static readonly Commodity Chemicals = new Hazardous(2, "Chemicals");
        public static readonly Commodity Explosives = new Hazardous(3, "Explosives");
        public static readonly Commodity Firearms = new Hazardous(4, "Firearms / Ammunition");
        public static readonly Commodity HazardousMaterials = new Hazardous(5, "Hazardous Materials");
        public static readonly Commodity Oil = new Hazardous(6, "Oil / Petrolium");
        public static readonly Commodity Alcohol = new HighValue(7, "Alcohol");
        public static readonly Commodity Antiques = new HighValue(8, "Antiques / Work of Arts");
        public static readonly Commodity Cash = new HighValue(9, "Cash, Checks, Currency");
        public static readonly Commodity Eletronics = new HighValue(10, "Consumer Eletronics");
        public static readonly Commodity Jewelry = new HighValue(11, "Jewelry");
        public static readonly Commodity Tobacco = new HighValue(12, "Tobacco Products");
        public static readonly Commodity TankerFreight = new Liquid(13, "Tanker Freight");
        public static readonly Commodity LiveAnimals = new LiveStock(14, "Live Animals");
        public static readonly Commodity RefrigeratedFood = new TempControlled(15, "Refrigerated (Food)");
        public static readonly Commodity RefrigeratedGeneral = new TempControlled(16, "Refrigerated (General)");


        public abstract int Type { get; }
        
        private class Dry : Commodity
        {
            public Dry(int value, string displayName) : base(value, displayName) { }
            public override int Type => DRY;
        }

        private class Hazardous : Commodity
        {
            public Hazardous(int value, string displayName) : base(value, displayName) { }
            public override int Type => HAZARDOUS;
        }

        private class HighValue : Commodity
        {
            public HighValue(int value, string displayName) : base(value, displayName) { }
            public override int Type => HIGH_VALUE;
        }
        
        private class Liquid : Commodity
        {
            public Liquid(int value, string displayName) : base(value, displayName) { }
            public override int Type => LIQUID;
        }

        private class LiveStock : Commodity
        {
            public LiveStock(int value, string displayName) : base(value, displayName) { }
            public override int Type => LIVESTOCK;
        }

        private class TempControlled : Commodity
        {
            public TempControlled(int value, string displayName) : base(value, displayName) { }
            public override int Type => TEMPERATURE_CONTROLLED;
        }

    }
}
