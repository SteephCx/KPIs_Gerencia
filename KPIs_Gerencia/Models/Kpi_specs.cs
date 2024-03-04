using System.ComponentModel.DataAnnotations.Schema;

namespace KPIs_Gerencia.Models
{
    public class Kpi_specs
    {
        ForeignKeyAttribute ID_IND2 {  get; set; }
        public string UNIDAD_MEDIDA { get; set; }
        public int META {set; get; } 
        

    }
}
