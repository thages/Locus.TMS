using Locus.TMS.Domain.Common.Enums;

namespace Locus.TMS.Domain.Transportation.Enums
{
    public abstract class LoadStatus : Enumeration
    {
        protected const int PLANNING = 1;
        protected const int ACTIVE_LOAD = 2;
        protected const int LOAD_COMPLETED = 3;

        protected LoadStatus() { }
        protected LoadStatus(int value, string displayName) : base(value, displayName) { }

        public static readonly LoadStatus Pending = new Planning(1,"Pending");
        public static readonly LoadStatus NeedsCarrier = new Planning(2, "Needs Carrier");
        public static readonly LoadStatus NeedsDriver = new Planning(3,"Needs Driver");
        public static readonly LoadStatus BookedAwaitingConfirmation = new Planning(4, "Booked Awaiting Confirmation");
        public static readonly LoadStatus ReadyConfirmationSigned = new ActiveLoad(5, "Ready - Confirmation Signed");
        public static readonly LoadStatus DriverAssigned = new ActiveLoad(6, "Driver Assigned");
        public static readonly LoadStatus Dispatched = new ActiveLoad(7, "Dispatched");
        public static readonly LoadStatus InTransit = new ActiveLoad(8, "In Transit");
        public static readonly LoadStatus Watch = new ActiveLoad(9, "Watch");
        public static readonly LoadStatus PossibleClaim = new ActiveLoad(10, "Possible Claim");
        public static readonly LoadStatus Delivered = new ActiveLoad(11, "Delivered");
        public static readonly LoadStatus Completed = new LoadCompleted(12, "Completed");
        public static readonly LoadStatus ToBeBilled = new LoadCompleted(13, "To Be Billed");
        public static readonly LoadStatus ActualClaim = new LoadCompleted(14, "Actual Claim");

        public abstract int Stage { get; } 

        private class Planning : LoadStatus
        {
            public Planning(int value, string displayName) : base(value, displayName) { }
            public override int Stage => PLANNING;
        }

        private class ActiveLoad : LoadStatus
        {
            public ActiveLoad(int value, string displayName) : base(value, displayName) { }
            public override int Stage => ACTIVE_LOAD;
        }

        private class LoadCompleted : LoadStatus
        {
            public LoadCompleted(int value, string displayName) : base(value, displayName) { }
            public override int Stage => LOAD_COMPLETED;
        }
    }

    
}