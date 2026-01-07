

using System;

namespace BridgeLabzTraning.Payroll
{
    internal class StaffProfile
    {
        public StaffProfile() { }

        public StaffProfile(string fullName, int id)
        {
            Name = fullName;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; } = "";

        public int DaysWorked { get; set; }
        public int HoursWorked { get; set; }
        public int Salary { get; set; }

        public const int RatePerHour = 20;
        public const int FullShift = 8;
        public const int HalfShift = 4;
        public const int MaxDays = 20;
        public const int MaxHours = 100;

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Salary: ₹{Salary}";
        }
    }
}


