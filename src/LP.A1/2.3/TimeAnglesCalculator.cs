using System;

namespace LP.A1._2._3
{
    /// <summary>
    /// Time Angles
    ///  Given an input representing a time of day(in the appropriate data type for the language used), output the angle in degrees between two hands of an analogue clock at that time.The angle should be expressed as the acute or obtuse(i.e. less than 180 degrees) angle between the hour hand and minute hand, and should be rounded to 2 decimal places.
    ///  If no argument is supplied, the output should be the angle for the current system time.
    /// </summary>
    public class TimeAnglesCalculator
    {
        private const decimal ClockFaceDegrees = 360;
        private const decimal NumHours = 12;
        private const decimal NumMinutes = 60;

        private const decimal DegreesPerHour = ClockFaceDegrees / NumHours;
        private const decimal DegreesPerMinute = ClockFaceDegrees / NumMinutes;

        public decimal Calculate(DateTime dateTime)
        {
            return Calculate(dateTime.TimeOfDay);
        }

        //Having this method here could be considered a violation of SRP
        //The conversion of a time to a 12 hour time should be the responsibility of another class
        //For example, it would make sense as an extension, which could be tested independently
        public decimal Calculate(TimeSpan time)
        {
            int hour = time.Hours;
            int min = time.Minutes;

            if (hour >= 12)
                hour = hour - 12;

            return Calculate(hour, min);

        }

        public decimal Calculate(int hour, int minute)
        {
            if (hour < 0 || hour > 11)
                throw new ArgumentOutOfRangeException(nameof(hour), "hour must be between 0 and 12 (inclusive)");

            if (minute < 0 || minute > 59)
                throw new ArgumentOutOfRangeException(nameof(minute), "minute must bet between 0 and 59 (inclusive)");

            var minuteHandAngle = minute * DegreesPerMinute;
            var hourHandleAngle = hour * DegreesPerHour;

            //The hour hand also moves as the minute hand moves, adjust for this.
            hourHandleAngle = hourHandleAngle + (DegreesPerHour * minute / NumMinutes);

            var diff = Math.Abs(hourHandleAngle - minuteHandAngle);

            if (diff > 180)
                diff = 360 - diff;

            return diff;

        }

    }
}
