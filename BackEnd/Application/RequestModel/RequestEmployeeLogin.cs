using System.ComponentModel.DataAnnotations;

namespace AluguelDeCarro.Application.RequestModel
{
    public class RequestEmployeeLogin
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Passwords { get; set; }
    }
}
