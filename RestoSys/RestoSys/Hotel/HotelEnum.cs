
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoSys.Hotel
{

    public static class BookingStatus
    {
        public const string Booked = "Booked";
        public const string Occupied = "Occupied";
        public const string Cleared = "Cleared";
        public const string Canceled = "Canceled";
    
        public static string GetDisplayValue(string dbvalue)
        {
            switch (dbvalue)
            {
                case Booked:
                    return "Booked";
                case Occupied:
                    return "Occupied";
                case Cleared:
                    return "Cleared";
                case Canceled:
                    return "Canceled";
                default:
                    return "";
            }

        }

        public static string GetdbValue(string displayValue)
        {
            switch (displayValue)
            {
                case "Booked":
                    return Booked;
                case "Occupied":
                    return Occupied;
                case "Cleared":
                    return Cleared;
                case "Canceled":
                    return Canceled;
                default:
                    return "";
            }

        }
    }

}
