namespace AluguelDeCarro.Application.ResponseModel
{
    public class ResponseCreateUser(string userName)
    {
        public string UserName { get; set; } = userName;

        public override string ToString()
        {
            return $"Usuário {UserName} criado com sucesso";
        }
    }
}
