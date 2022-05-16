using System.Text.RegularExpressions;

namespace PT4
{
    internal static class Utils
    {
        public static bool IsPhoneNumber(string number)
        {
            string regex = @"^([-]?|[0])?[1-9][0-9]{8}$";
            if (number != null) return Regex.IsMatch(number, regex);
            else return false;
        }

        public static bool IsEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
