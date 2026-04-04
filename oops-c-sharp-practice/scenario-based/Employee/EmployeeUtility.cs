

using System;

namespace BridgeLabzTraning.Payroll
{
    internal class StaffSalaryService : IStaffService
    {
        private readonly StaffProfile staff;
        private readonly Random rng;

        public StaffSalaryService()
        {
            staff = new StaffProfile("BridgeLabz Staff", 501);
            rng = new Random();
        }

        public void CalculateMonthlySalary()
        {
            Console.WriteLine("\nSalary calculation initiated...\n");

            while (staff.DaysWorked < StaffProfile.MaxDays &&
                   staff.HoursWorked < StaffProfile.MaxHours)
            {
                staff.DaysWorked++;

                int attendance = rng.Next(0, 3);
                int workedHours = 0;

                if (attendance == 1)
                {
                    workedHours = StaffProfile.FullShift;
                    Console.WriteLine($"Day {staff.DaysWorked}: Full Shift");
                }
                else if (attendance == 2)
                {
                    workedHours = StaffProfile.HalfShift;
                    Console.WriteLine($"Day {staff.DaysWorked}: Half Shift");
                }
                else
                {
                    Console.WriteLine($"Day {staff.DaysWorked}: No Show");
                }

                if (staff.HoursWorked + workedHours > StaffProfile.MaxHours)
                    workedHours = StaffProfile.MaxHours - staff.HoursWorked;

                staff.HoursWorked += workedHours;
                staff.Salary += workedHours * StaffProfile.RatePerHour;

                Console.WriteLine($"Worked Hours: {workedHours}, Earned: ₹{workedHours * StaffProfile.RatePerHour}\n");
            }

            PrintSummary();
        }

        private void PrintSummary()
        {
            Console.WriteLine("=================================");
            Console.WriteLine(" Payroll Summary ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Total Days   : {staff.DaysWorked}");
            Console.WriteLine($"Total Hours  : {staff.HoursWorked}");
            Console.WriteLine($"Final Salary : ₹{staff.Salary}");
            Console.WriteLine("=================================\n");
        }
    }
}

