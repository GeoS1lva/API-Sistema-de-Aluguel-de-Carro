namespace AluguelDeCarro.Application.ResponseModel
{
    public class ResponseRegisterCarModel(string make, string model, int year, string licensePlate)
    {
        public string Make { get; private set; } = make;
        public string Model { get; private set; } = model;
        public int Year { get; private set; } = year;
        public string LicensePlate { get; private set; } = licensePlate;
    }
}
