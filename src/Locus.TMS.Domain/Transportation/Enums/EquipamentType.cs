using Locus.TMS.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locus.TMS.Domain.Transportation.Enums
{
    public abstract class EquipamentType : Enumeration
    {
        protected const int DRY_VAN = 1;
        protected const int TEMPERATURE_CONTROL = 2;
        protected const int FLATBED = 3;
        protected const int SPECIALIZED = 4;
        protected const int FLEXIBLE_TYPE = 5;
        protected const int MISCELLANEOUS = 6;

        public EquipamentType() { }

        public EquipamentType(int value, string displayName) : base(value, displayName) { }

        public static readonly EquipamentType Van = new DryVan(1, "Van");
        public static readonly EquipamentType VanAirRide = new DryVan(2, "Van - Air-Ride");
        public static readonly EquipamentType VanHazardous = new DryVan(3, "Van - Hazardous");
        public static readonly EquipamentType VanVented = new DryVan(4, "Van - Vented");
        public static readonly EquipamentType VanCurtains = new DryVan(5, "Van w/ Curtains");
        public static readonly EquipamentType VanPalletExchange = new DryVan(6, "Van w/ Pallet Exchange");
        public static readonly EquipamentType Refeer = new TempControl(7, "Refeer");
        public static readonly EquipamentType RefeerHazardous = new TempControl(8, "Refeer - Hazardous");
        public static readonly EquipamentType RefeerPalletExchange = new TempControl(9, "Refeer w/ Pallet Exchange");
        public static readonly EquipamentType DoubleDrop = new FlatbedType(10, "Double Drop");
        public static readonly EquipamentType Flatbed = new FlatbedType(11, "Flatbed");
        public static readonly EquipamentType FlatbedHazardous = new FlatbedType(12, "Flatbed - Hazardous");
        public static readonly EquipamentType FlatbedPalletExchange = new FlatbedType(13, "Flatbed  w/ Pallet Exchange");
        public static readonly EquipamentType FlatbedSides = new FlatbedType(14, "Flatbed  w/ Sides");
        public static readonly EquipamentType Lowboy = new FlatbedType(15, "Lowboy");
        public static readonly EquipamentType Maxi = new FlatbedType(16, "Maxi");
        public static readonly EquipamentType RemovableGooseneck = new FlatbedType(17, "Removable Gooseneck");
        public static readonly EquipamentType StepDeck = new FlatbedType(18, "Step Deck");
        public static readonly EquipamentType AutoCarrier = new Specialized(19, "Auto Carrier");
        public static readonly EquipamentType DumpTrailler = new Specialized(20, "Dump Trailler");
        public static readonly EquipamentType HooperBottom = new Specialized(21, "Hooper Bottom");
        public static readonly EquipamentType Hotshot = new Specialized(22, "Hotshot");
        public static readonly EquipamentType Tanker = new Specialized(23, "Tanker");
        public static readonly EquipamentType FlatbedStepDeck = new FlexibleType(24, "Flatbed/StepDeck");
        public static readonly EquipamentType FlatbedVan = new FlexibleType(25, "Flatbed/Van");
        public static readonly EquipamentType FlatbedRefeer = new FlexibleType(26, "Flatbed/Refeer");
        public static readonly EquipamentType RefeerVan = new FlexibleType(27, "Refeer/Van");
        public static readonly EquipamentType FlatbedRefeerVan = new FlexibleType(28, "Flatbed/Refeer/Van");
        public static readonly EquipamentType PowerOnly = new Misc(29, "Power Only");

        public abstract int Type { get; }

        private class DryVan : EquipamentType
        {
            public DryVan(int value, string displayName) : base(value, displayName) { }
            public override int Type => DRY_VAN;
        }
        
        private class TempControl : EquipamentType
        {
            public TempControl(int value, string displayName) : base(value, displayName) { }
            public override int Type => TEMPERATURE_CONTROL;
        }
        
        private class FlatbedType : EquipamentType
        {
            public FlatbedType(int value, string displayName) : base(value, displayName) { }
            public override int Type => FLATBED;
        }
        
        private class Specialized : EquipamentType
        {
            public Specialized(int value, string displayName) : base(value, displayName) { }
            public override int Type => SPECIALIZED;
        }
        
        private class FlexibleType : EquipamentType
        {
            public FlexibleType(int value, string displayName) : base(value, displayName) { }
            public override int Type => FLEXIBLE_TYPE;
        }
        
        private class Misc : EquipamentType
        {
            public Misc(int value, string displayName) : base(value, displayName) { }
            public override int Type => MISCELLANEOUS;
        }

    }
}
