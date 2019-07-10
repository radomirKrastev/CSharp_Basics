using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTimeAsMinutes = examHour * 60 + examMinute;
            int arrivalTimeAsMinutes = arrivalHour * 60 + arrivalMinute;

            if (arrivalTimeAsMinutes > examTimeAsMinutes)
            {
                int latency = arrivalTimeAsMinutes - examTimeAsMinutes;
                Console.WriteLine("Late");

                if (latency < 60)
                {
                    Console.WriteLine($"{latency} minutes after the start");
                }
                else
                {
                    int hoursLatency = latency / 60;
                    int minutesLatency = latency % 60;
                    Console.WriteLine($"{hoursLatency}:{minutesLatency:D2} hours after the start");
                }
            }
            else if (examTimeAsMinutes - arrivalTimeAsMinutes <= 30 || arrivalTimeAsMinutes == examTimeAsMinutes)
            {
                Console.WriteLine("On Time");

                int minutesBefore = examTimeAsMinutes - arrivalTimeAsMinutes;
                if (minutesBefore != 0)
                {
                    Console.WriteLine($"{minutesBefore} minutes before the start");
                }
            }
            else
            {
                int veryEarly = examTimeAsMinutes - arrivalTimeAsMinutes;
                Console.WriteLine("Early");

                if (veryEarly < 60)
                {
                    Console.WriteLine($"{veryEarly} minutes before the start");
                }
                else
                {
                    int hoursVeryEarly = veryEarly / 60;
                    int minutesVeryEarly = veryEarly % 60;

                    Console.WriteLine($"{hoursVeryEarly}:{minutesVeryEarly:D2} hours before the start");
                }
            }



        }
    }
}
