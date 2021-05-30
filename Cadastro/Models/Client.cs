using System.ComponentModel;

namespace Cadastro.Models
{
    public class Client
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Name { get; set; }
        [DisplayName("Data Nascimento")]
        public string BirthDate { get; set; }
        [DisplayName("Estado Civil")]
        public string MaritalStatus { get; set; }
        [DisplayName("Telefone")]
        public string Telephone { get; set; }
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        [DisplayName("Sexo")]
        public char Gender { get; set; }
        [DisplayName("Tem investimento?")]
        public bool HasInvestments { get; set; }
    }
}
