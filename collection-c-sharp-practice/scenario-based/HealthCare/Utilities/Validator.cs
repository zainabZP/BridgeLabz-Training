using System.Text.RegularExpressions;

namespace HealthClinicApp.Utilities
{
    public static class Validator
    {
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{10}$");
        }

        public static bool IsRequired(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}