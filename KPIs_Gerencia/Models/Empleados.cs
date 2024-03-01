using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KPIs_Gerencia.Models
{
    public class Empleados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int No_EMPLEADO { get; set; }
        ForeignKeyAttribute ID_DEP2 { get; set; }
        [Required]
        public string NOMBRE { get; set; }
        [Required]
        public String APELLIDO { get; set; }
        [Required]
        public float BONO {  get; set; }
        ForeignKeyAttribute ID_User { get; set; }


    }
}
