using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KPIs_Gerencia.Models
{
    public class Departamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        ForeignKeyAttribute ID_DEP {  get; set; }
        [Required]
        public string DEPARTAMENTO { get; set; }
    }
}
