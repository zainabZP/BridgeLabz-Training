using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class DatabaseDataSource : IDataSource
    {
        // Change YOUR_SERVER to your actual SQL Server instance
        private string connectionString =
            "Server=WASEEM\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";


        public async Task SaveAsync(List<ContactPerson> contacts)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            await conn.OpenAsync();

            foreach (var p in contacts)
            {
                // Skip duplicate entries
                string checkQuery = "SELECT COUNT(*) FROM Contacts WHERE FirstName=@First AND LastName=@Last";
                using SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@First", p.FirstName);
                checkCmd.Parameters.AddWithValue("@Last", p.LastName);

                int count = (int)await checkCmd.ExecuteScalarAsync();
                if (count > 0)
                    continue;

                // Insert contact
                string insertQuery = @"INSERT INTO Contacts 
                    (FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email)
                    VALUES (@First, @Last, @Address, @City, @State, @Zip, @Phone, @Email)";

                using SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@First", p.FirstName);
                cmd.Parameters.AddWithValue("@Last", p.LastName);
                cmd.Parameters.AddWithValue("@Address", p.Address);
                cmd.Parameters.AddWithValue("@City", p.City);
                cmd.Parameters.AddWithValue("@State", p.State);
                cmd.Parameters.AddWithValue("@Zip", p.Zip);
                cmd.Parameters.AddWithValue("@Phone", p.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", p.Email);

                await cmd.ExecuteNonQueryAsync();
            }

            Console.WriteLine("Saved contacts to Database successfully.");
        }
    }
}