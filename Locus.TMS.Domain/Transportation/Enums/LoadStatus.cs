using Locus.TMS.Domain.Common.Enums;

namespace Locus.TMS.Domain.Transportation.Enums
{
    public abstract class LoadStatus : Enumeration
    {
        protected const int PLANNING = 1;
        protected const int ACTIVE_LOAD = 2;

        protected LoadStatus() { }
        protected LoadStatus(int value, string displayName) : base(value, displayName) { }

        public static readonly LoadStatus Pending = new PendingType();
        public static readonly LoadStatus NeedsCarrier = new NeedsCarrierType();
        public static readonly LoadStatus NeedsDriver = new NeedsDriverType();
        public static readonly LoadStatus BookedAwaitingConfirmation = new BookedAwaitingConfirmationType();
        public static readonly LoadStatus ReadyConfirmationSigned = new ReadyConfirmationSignedType();
        public static readonly LoadStatus DriverAssigned = new DriverAssignedType();
        public static readonly LoadStatus Dispatched = new DispatchedType();
        public static readonly LoadStatus InTransit = new InTransitType();
        public static readonly LoadStatus Watch = new WatchType();
        public static readonly LoadStatus PossibleClaim = new PossibleClaimType();
        public static readonly LoadStatus Delivered = new DeliveredType();


        public abstract int Stage { get; } 

        private class PendingType : LoadStatus
        {
            public PendingType() : base(0, "Pending") { }
            public override int Stage => PLANNING;
        }

        private class NeedsCarrierType : LoadStatus
        {
            public NeedsCarrierType() : base(1, "Needs Carrier") { }
            public override int Stage => PLANNING;
        }

        private class NeedsDriverType : LoadStatus
        {
            public NeedsDriverType() : base(2, "Needs Driver") { }
            public override int Stage => PLANNING;
        }

        private class BookedAwaitingConfirmationType : LoadStatus
        {
            public BookedAwaitingConfirmationType() : base(3, "Booked Awaiting Confirmation") { }
            public override int Stage => PLANNING;
        }

        private class ReadyConfirmationSignedType : LoadStatus
        {
            public ReadyConfirmationSignedType() : base(4, "Ready - Confirmation Signed") { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class DriverAssignedType : LoadStatus
        {
            public DriverAssignedType() : base(5,"Driver Assigned") { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class DispatchedType : LoadStatus
        {
            public DispatchedType() : base(6, "Dispatched") { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class InTransitType : LoadStatus
        {
            public InTransitType() : base(7, "In Transit") { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class WatchType : LoadStatus
        {
            public WatchType() : base(8, "Watch") { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class PossibleClaimType : LoadStatus
        {
            public PossibleClaimType() : base(9, "Possible Claim") { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class DeliveredType : LoadStatus
        {
            public DeliveredType() : base(10,"Delivered") { }
            public override int Stage => ACTIVE_LOAD;
        }
    }

    
}