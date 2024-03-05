using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace KPIs_Gerencia.Models
{
    public class kpi_logs
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_LOG { get; set; }
        ForeignKeyAttribute ID_IND1 { get; set; }

        [Required]
        public DateTime FECHA { get; set; }
        [Required]
        public int CANT { get; set; }
        [Required(ErrorMessage = "El número de empleado es obligatorio.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Ingrese solo números.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de empleado debe ser mayor que cero.")]
        ForeignKeyAttribute NO_EMPLEADO { get; set; }
        public DateTime FECHA_IND { get; set; }
        //fecha el la que el indicador fue hecho 


    }
}
