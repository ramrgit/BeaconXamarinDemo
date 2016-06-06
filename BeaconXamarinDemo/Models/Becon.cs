using CoreLocation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeaconXamarinDemo.Models
{
    public static class Region
    {
        static CLBeaconRegion beaconRegion;

        static Region()
        {
            beaconRegion = new CLBeaconRegion(new NSUuid(Globals.BroadcastUUID), Globals.BeaconRegion);
            beaconRegion.NotifyEntryStateOnDisplay = true;
            beaconRegion.NotifyOnEntry = true;
            beaconRegion.NotifyOnExit = true;
        }

        public static CLBeaconRegion RegionToMonitor
        {
            get
            {
                return beaconRegion;
            }
        }
    }
}
