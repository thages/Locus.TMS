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

        public static readonly LoadStatus Pending = new Planning(0,"Pending");
        public static readonly LoadStatus NeedsCarrier = new Planning(1, "Needs Carrier");
        public static readonly LoadStatus NeedsDriver = new Planning(2,"Needs Driver");
        public static readonly LoadStatus BookedAwaitingConfirmation = new Planning(3, "Booked Awaiting Confirmation");
        public static readonly LoadStatus ReadyConfirmationSigned = new ActiveLoad(4, "Ready - Confirmation Signed");
        public static readonly LoadStatus DriverAssigned = new ActiveLoad(5, "Driver Assigned");
        public static readonly LoadStatus Dispatched = new ActiveLoad(6, "Dispatched");
        public static readonly LoadStatus InTransit = new ActiveLoad(7, "In Transit");
        public static readonly LoadStatus Watch = new ActiveLoad(8, "Watch");
        public static readonly LoadStatus PossibleClaim = new ActiveLoad(9, "Possible Claim");
        public static readonly LoadStatus Delivered = new ActiveLoad(10, "Delivered");
        public static readonly LoadStatus Completed = new LoadCompleted(11, "Completed");
        public static readonly LoadStatus ToBeBilled = new LoadCompleted(11, "To Be Billed");
        public static readonly LoadStatus ActualClaim = new LoadCompleted(11, "Actual Claim");

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