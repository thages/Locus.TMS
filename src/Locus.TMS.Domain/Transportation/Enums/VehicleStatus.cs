using Locus.TMS.Domain.Common.Enums;

namespace Locus.TMS.Domain.Transportation.Enums
{
    public abstract class VehicleStatus : Enumeration
    {
        protected const int CARRIER_SETUP = 1;
        protected const int BEFORE_YOUR_LOAD = 2;
        protected const int DURING_YOUR_LOAD = 3;
        protected const int AFTER_YOUR_LOAD = 4;

        protected VehicleStatus() { }
        protected VehicleStatus(int value, string displayName) : base(value, displayName) { }

        public static readonly VehicleStatus CarrierNeedsSetup = new CarrierSetup(0, "Carrier Needs Setup");
        public static readonly VehicleStatus SetupPacketSentToCarrier = new CarrierSetup(1, "Setup Packet Sent To Carrier");
        public static readonly VehicleStatus InsuranceVerificationNeeded = new CarrierSetup(2, "Insurance Verification Needed");
        public static readonly VehicleStatus CarrierSetupNotComplete = new CarrierSetup(3, "Carrier Setup Not Complete");
        public static readonly VehicleStatus CarrierSetupComplete = new CarrierSetup(4, "Carrie Setup Complete");
        public static readonly VehicleStatus AtPriorLoad = new BeforeLoad(5, "At Prior Load");
        public static readonly VehicleStatus Dispatched = new BeforeLoad(5, "Dispatched");
        public static readonly VehicleStatus AtPickupWaiting = new DuringLoad(6, "At Pickup - Waiting");
        public static readonly VehicleStatus AtPickupLoading = new DuringLoad(7, "At Pickup - Loading");
        public static readonly VehicleStatus OnTime = new DuringLoad(8, "On Time");
        public static readonly VehicleStatus RunningLate = new DuringLoad(9, "Running Late");
        public static readonly VehicleStatus AtDeliveryWaiting = new DuringLoad(10, "At Delivery - Waiting");
        public static readonly VehicleStatus AtDeliveryUnloading = new DuringLoad(11, "At Delivery - Unloading");
        public static readonly VehicleStatus BrokenDown = new DuringLoad(12, "Broken Down");
        public static readonly VehicleStatus InAccident = new DuringLoad(13, "In Accident");
        public static readonly VehicleStatus Empty = new AfterLoad(14, "Empty");
        public static readonly VehicleStatus DriverPaid = new AfterLoad(15, "Driver Paid");

        public abstract int Stage { get; }

        private class CarrierSetup : VehicleStatus
        {
            public CarrierSetup(int value, string displayName) : base(value,displayName) { }
            public override int Stage => CARRIER_SETUP;
        }

        private class BeforeLoad : VehicleStatus
        {
            public BeforeLoad(int value, string displayName) : base(value, displayName) { }
            public override int Stage => BEFORE_YOUR_LOAD;
        }

        private class DuringLoad : VehicleStatus
        {
            public DuringLoad(int value, string displayName) : base(value, displayName) { }
            public override int Stage => DURING_YOUR_LOAD;
        }

        private class AfterLoad : VehicleStatus
        {
            public AfterLoad(int value, string displayName) : base(value, displayName) { }
            public override int Stage => AFTER_YOUR_LOAD;
        }
    }
}
