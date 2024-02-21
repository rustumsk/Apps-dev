using ConsoleApp1;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime parkIn = DateTime.Now;

            int outerLoop = 0;

            Console.Write("Enter Plate Number: ");
            string plateNumber = Console.ReadLine();

            Console.Write("\nEnter Vehicle Brand: ");
            string vehBrand = Console.ReadLine();

            string vehType = "";
            int outerSwitchLoop = 0;
            int initial = 0;
            int proceeding = 0;

            while (outerSwitchLoop < 1)
            {
                int vehOpt = 0;

                int innerSwitchLoop = 0;
                while (innerSwitchLoop < 1)
                {
                    try
                    {
                        Console.Write("\nVehicle type: 1. MotorBike 2.SUV/VAN 3.Sedan: ");
                        vehOpt = Convert.ToInt32(Console.ReadLine());
                        innerSwitchLoop = 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input! Integer input only!");
                    }
                }

                Suv suv = new Suv(" ", " ", " ");
                MotorBike motor = new MotorBike(" ", " ", " ");
                Sedan sedan = new Sedan(" ", " ", " ");
                switch (vehOpt)
                {
                    case 1:
                        vehType = "MotorBike";
                        motor = new MotorBike(vehBrand, plateNumber, "MotorCycle");
                        plateNumber = motor.PlateNum;
                        vehBrand = motor.Brand;
                        vehType = motor.Type;
                        initial = (int)MotorBike.Amounts.value;
                        proceeding = (int)MotorBike.Amounts.perHour;
                        outerSwitchLoop = 1;
                        break;
                    case 2:
                        vehType = "SUV/VAN";
                        suv = new Suv(vehBrand, plateNumber, "Suv");
                        plateNumber = suv.PlateNum;
                        vehBrand = suv.Brand;
                        vehType = suv.Type;
                        initial = (int)Suv.Amounts.value;
                        proceeding = (int)Suv.Amounts.perHour;
                        outerSwitchLoop = 1;
                        break;
                    case 3:
                        vehType = "Sedan";
                        sedan = new Sedan(vehBrand, plateNumber, "Sedan");
                        plateNumber = sedan.PlateNum;
                        vehBrand = sedan.Brand;
                        vehType = sedan.Type;
                        initial = (int)Sedan.Amounts.value;
                        proceeding = (int)Sedan.Amounts.perHour;
                        outerSwitchLoop = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
            Parking park = new Parking(plateNumber, vehType, vehBrand, parkIn);

            Console.WriteLine("\n=======Here is your parking detail========");
            park.ShowParkingInfo();

            int innerWhileLoop = 0;
            while (innerWhileLoop < 1)
            {
                Console.Write("\nDo you want to park out? 1.Yes 2.No: ");
                int parkChoice = Convert.ToInt32(Console.ReadLine());

                switch (parkChoice)
                {
                    case 1:
                        do
                        {
                            try
                            {
                                Console.Write("Enter time park out: ");
                                string parkOut = Console.ReadLine();
                                DateTime toParkOut = DateTime.Parse(parkOut);
                                if (toParkOut < parkIn) /*|| toParkOut.Month < parkIn.Month || toParkOut.Year < parkIn.Year || toParkOut.Hour < parkIn.Hour || toParkOut.Minute < parkIn.Minute || toParkOut.Second < parkIn.Second)*/
                                {
                                    Console.WriteLine("\nINVALID DATE\n");
                                    outerLoop = 1;
                                }
                                else
                                {
                                    park.ComputeParking(toParkOut, initial, proceeding);
                                    outerLoop = 0;
                                    innerWhileLoop = 1;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Write("\nINVALID FORMAT, PLEASE USE MM/DD/YYYY HH:MM:SS\n");
                                outerLoop = 1;
                            }
                        } while (outerLoop != 0);
                        break;
                    case 2:
                        park.ShowParkingInfo();
                        innerWhileLoop = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Please choose a valid option!");
                        innerWhileLoop = 0;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
