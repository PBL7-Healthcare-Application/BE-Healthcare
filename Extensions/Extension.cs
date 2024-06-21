using System.Text.RegularExpressions;

namespace BE_Healthcare.Extensions
{
    public static class Extension
    {
        public static bool ValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsValidPassword(string password)
        {

            string passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=])(?!.*\s).{8,}$";
            return Regex.IsMatch(password, passwordRegex);
        }
    }
}
