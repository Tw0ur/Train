using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Models
{
    public class Schedule
    {
        public int ScheduleID;
        public int TrainID;
        public DateTime DepartureDate;
        public TimeSpan DepartureTime;
        public string DeparturePlace = "";
        public TimeSpan ArrivalTime;
        public string ArrivalPlace = "";
        public string Route = "";
        public decimal TicketPrice = 0.00M;
    }
}
