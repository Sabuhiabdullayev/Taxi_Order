﻿namespace Taxi.Models.Order
{
    public class OrderAllList
    {
        public int Id { get; set; }
        public string FromWhere { get; set; }
        public string Where { get; set; }
        public string TransportationType { get; set; }
        public string Phone { get; set; }
        public string DateOfDeparture { get; set; }
        public string DateOfPosting { get; set; }
        public string FromWhereDate { get; set; }
        public string WhereDate { get; set; }
        public string FullHour { get; set; }
        public int Price { get; set; }

        public int AppUserId { get; set; }
    }
}
