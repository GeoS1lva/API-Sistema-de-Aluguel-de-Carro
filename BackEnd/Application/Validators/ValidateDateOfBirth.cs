namespace AluguelDeCarro.Application.Validators
{
    public class ValidateDateOfBirth
    {
        public static bool DateOfBirth(DateOnly date)
        {
            int BirthYear = date.Year;
            int CurrentYear = DateOnly.FromDateTime(DateTime.Now).Year;

            int age = CurrentYear - BirthYear;

            if(age < 18)
                return false;

            return true;
        }
    }
}
