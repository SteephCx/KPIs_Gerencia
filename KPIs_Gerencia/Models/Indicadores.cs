using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIs_Gerencia.Models
{
    public class Indicadores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_IND {  get; set; }
        ForeignKeyAttribute ID_DEP { get; set; }
        [Required]
        public string INDICADOR { get; set; }
        public string DESCRIPCION { get; set; }
        public Boolean ACTIVO { get; set; }

    }
}
