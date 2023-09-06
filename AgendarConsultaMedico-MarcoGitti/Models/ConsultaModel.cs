using System.ComponentModel.DataAnnotations;

namespace AgendarConsultaMedico_MarcoGitti.Models
{
    public class ConsultaModel
    {
        [Required(ErrorMessage ="Não é necessário preencher o ID!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informa a Data e Hora!")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "Insira seu Nome!")]
        public string Paciente { get; set; }

        [Required(ErrorMessage = "Insira o nome do Médico que você irá se consultar!")]
        public string Medico { get; set; }
    }
}