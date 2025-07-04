using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Mail;

namespace AluguelDeCarro.Application.Validators
{
    public class ValidateEmail
    {
        public static bool Email(string email)
        {
            try
            {
                _ = new MailAddress(email);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
