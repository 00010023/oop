using System;
using System.Collections.Generic;

namespace liwy
{
    public class Reservation
    {
        public int ID { get; set; }
        //create a Reserver property using User class (association) 
        public User UserReserving { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservedBookISBN { get; set; }

        /// <summary>
        /// How many days the reservation is active (in days)
        /// </summary>
        public int ReservationDuration { get; set; }

        public DateTime ReservationEndDate {
            get
            {
                return ReservationDate.AddDays(ReservationDuration);
            }
        }

        /// <summary>
       
        
        public ReservationStatus ReservationStatus { get; set; }
    }
    public enum ReservationStatus
    {
        Active,
        Expired,
        Fulfilled
    }
}