using System.Text.RegularExpressions;

namespace Cadastro.Helpers
{
    public static class CpfHelper
    {
        const string CpfRegex = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$";

        public static bool IsValid(string cpf)
        {
            var regex = new Regex(CpfRegex);
            var math = regex.Match(cpf);
            return math.Success;
        }
    }
}
