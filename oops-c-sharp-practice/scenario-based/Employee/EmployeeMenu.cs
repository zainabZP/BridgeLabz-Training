
using System;

namespace BridgeLabzTraning.Payroll
{
    sealed class PayrollMenu
    {
        private readonly IStaffService service;

        public PayrollMenu()
        {
            service = new StaffSalaryService();
            Launch();
        }

        private void Launch()
        {
            int option;
            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine(" Employee Payroll Management ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Generate Salary");
                Console.WriteLine("2. Close Application");
                Console.Write("Select option: ");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                    service.CalculateMonthlySalary();
                else if (option == 2)
                    Console.WriteLine("System shutting down...");
                else
                    Console.WriteLine("Invalid input.");

            } while (option != 2);
        }
    }
}


