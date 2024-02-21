using System;

namespace ConsoleApp1
{
    class Parking
    {
        private string plateNum;
        private string vehType;
        private string brand;
        private DateTime parkIn;
        //private DateTime parkOut = DateTime.Now.AddHours(16);

        public Parking(string plateNum, string vehType, string brand, DateTime parkIn)
        {
            this.plateNum = plateNum;
            this.vehType = vehType;
            this.brand = brand;
            this.parkIn = parkIn;
        }

        public void ComputeParking(DateTime parkOut, int flagDown, int succedingPay)
        {
            Console.WriteLine("Date/Time In:" + parkIn + "\n         Out:" + parkOut);

            TimeSpan duration = parkOut - parkIn;
            /*double seconds = timeDifference.TotalSeconds;

            int minute = (int)seconds / 60;

            int hours = minute / 60;
            
            int day = 0;*/
            double hour = 0;
            int day = 0;
            int year = parkOut.Year - parkIn.Year;

            if (year >= 1)
            {
                day = (int)duration.TotalDays % 365;
                hour = (duration.TotalHours - year * 24 * 365) % 24;
                Console.WriteLine("Parking Time: " + year + " Year/s " + day + " Day/s " + " and " + hour.ToString("0.00") + " Hour/s");
            }
            else if (duration.TotalHours > 23)
            {
                day = (int)duration.TotalDays;
                hour = duration.TotalHours % 24;
                Console.WriteLine("Parking Time: " + day + " Day/s " + " and " + hour.ToString("0.00") + " Hour/s");
            }
            else
            {
                Console.WriteLine("Parking Time: " + duration.Hours.ToString("0.00") + " Hour/s");
            }
            hour = duration.TotalHours;
            Console.WriteLine(duration.Hours);
            double amount = flagDown;
            double totalAmount = 0;

            if (hour >= 1)
            {
               totalAmount = amount + succedingPay * hour;
            }
            else
            {
                totalAmount = amount;
            }

            Console.WriteLine("Amount:" + totalAmount.ToString("0.00"));
            Console.Write("\nThank you for parking with us!!");

        }

        public void ShowParkingInfo()
        {
            Console.WriteLine("Plate No: " + plateNum);
            Console.WriteLine("Type: " + vehType);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("ParkIn(Date/Time): " + parkIn);
        }
    }
}
