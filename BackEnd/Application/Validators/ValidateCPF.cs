namespace AluguelDeCarro.Application.Validators
{
    public class ValidateCPF
    {
        public static bool CPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            if (cpf.All(c => c == cpf[0]))
                return false;

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int primeiroDigitoVerificador = 11 - (soma % 11);
            if (primeiroDigitoVerificador >= 10)
                primeiroDigitoVerificador = 0;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            int segundoDigitoVerificador = 11 - (soma % 11);
            if (segundoDigitoVerificador >= 10)
                segundoDigitoVerificador = 0;

            return cpf[9] == primeiroDigitoVerificador.ToString()[0] && cpf[10] == segundoDigitoVerificador.ToString()[0];
        }
    }
}
