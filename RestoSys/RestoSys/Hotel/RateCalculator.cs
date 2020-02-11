using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsoft.Hotel
{
    /// <summary>
    /// Standard means without considering no of person
    /// </summary>
    class RateCalculator
    {
        /// <summary>
        ///discount rates set by user
        /// </summary>
        public decimal StandardDiscountRate
        {
            get;
            set;
        }

        public bool IsPerPersonRate
        {
            get;
            set;
        }

        /// <summary>
        /// No of guests
        /// </summary>
        public decimal Nos
        {
             get;
            set;
        }

        /// <summary>
        /// Days
        /// </summary>
        public decimal Days
        {
            get;
            set;
        }
        public decimal PerPersonRate
        {
            private get;
            set;
        }

        public decimal PerRoomRate
        {
            private get;
            set;
        }

        /// <summary>
        /// rate
        /// </summary>
        public decimal StandardRate
        {
            get
            {
                if (IsPerPersonRate)
                {
                    return PerPersonRate;
                }
                else
                {
                    return PerRoomRate;
                }
            }
        }

        /// <summary>
        /// rate
        /// </summary>
        public decimal PerDayRate
        {
            get
            {
                if (IsPerPersonRate)
                {
                    return StandardRate * Nos;
                }
                else
                {
                    return StandardRate;
                }
            }
        }

        /// <summary>
        /// rate after discount
        /// </summary>
        public decimal StandardDiscountedRate
        {
            get
            {
                return StandardRate - StandardDiscountRate;
            }

        }

        /// <summary>
        /// rate per day
        /// </summary>
        public decimal PerDayDiscountedRate
        {
            get
            {
                if (IsPerPersonRate)
                {
                    return StandardDiscountedRate * Nos;
                }
                else
                {

                    return StandardDiscountedRate;
                }
            }

        }

        /// <summary>
        /// Real amount
        /// </summary>
        public decimal DiscountedAmount
        {
            get
            {
                return Days * PerDayDiscountedRate;
            }
        }

        /// <summary>
        /// The total Amount
        /// </summary>
        public decimal Amount
        {
            get
            {
                return Days * PerDayRate ;
            }
        }
        /// <summary>
        /// The total Discount
        /// </summary>
        public decimal Discount
        {
            get
            {
                return Amount - DiscountedAmount;
            }
        }

    }
}
