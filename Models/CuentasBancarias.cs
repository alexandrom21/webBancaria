using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace webbancaria.Models
{
    [Table("t_CuentasBancarias")]
    public class CuentasBancarias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? NombreTitular { get; set; }
        public string? Tipo { get; set; }
        public int SaldoInicial { get; set; }
        public string? Email { get; set;}
    }
}