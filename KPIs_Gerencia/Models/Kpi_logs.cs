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
        ForeignKeyAttribute NO_EMPLEDO { get; set; }
        public DateTime FECHA_IND { get; set; }



    }
}
