namespace AluguelDeCarro.Application.Validators
{
    public class ValidateName
    {
        public static bool Name(string name)
        {
            if(name.IndexOf(" ") == 0 || !name.Contains(" "))
                return false;

            return true;
        }
    }
}
