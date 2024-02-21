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
            Console.WriteLine(duration);
            /*double seconds = timeDifference.TotalSeconds;

            int minute = (int)seconds / 60;

            int hours = minute / 60;
            
            int day = 0;*/
            int hour = duration.Hours;
            int day = (int)duration.TotalDays;
            int year = parkOut.Year - parkIn.Year;

            if (duration.Hours > 24)
            {
                day = duration.Hours / 24;
                hour = duration.Hours % 24;
                Console.WriteLine("Parking Time: " + day + "Day/s" + " and " + hour + "Hours");
            }
            else if (year >= 1)
            {
                Console.WriteLine("Parking Time: " + year + "Year/s" + day + "Day/s" + " and " + hour + "Hours");
                Console.WriteLine(duration.Hours);
            }
            else
            {
                Console.WriteLine("Parking Time: " + duration.Hours + "Hours");
            }

            int amount = flagDown;
            int totalAmount = 0;

            if (hour >= 1)
            {
                totalAmount = amount + succedingPay * hour;
            }
            else
            {
                totalAmount = amount;
            }

            Console.WriteLine("Amount:" + totalAmount);
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
