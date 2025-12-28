using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class TimeZonesProblems
    {
        public static void Main()
        {
            // Get current UTC time
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            // Time zone definitions
            TimeZoneInfo gmtZone=TimeZoneInfo.Utc;
            TimeZoneInfo istZone=TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstZone=TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            // Convert time to each time zone
            DateTimeOffset gmtTime=TimeZoneInfo.ConvertTime(utcNow, gmtZone);
            DateTimeOffset istTime=TimeZoneInfo.ConvertTime(utcNow, istZone);
            DateTimeOffset pstTime=TimeZoneInfo.ConvertTime(utcNow, pstZone);
            // Display output
            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("GMT:"+gmtTime);
            Console.WriteLine("IST:"+istTime);
            Console.WriteLine("PST:"+pstTime);
        }
    }
}
