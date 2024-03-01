using System.ComponentModel.DataAnnotations.Schema;

namespace KPIs_Gerencia.Models
{
    public class CapturaKPIs
    {
        public int ID_LOG { get; set; }
        public int ID_IND1 { get; set; }
        public DateTime FECHA { get; set; }
        public int CANT { get; set; }
        public int NO_EMPLEDO { get; set; }
        public DateTime FECHA_IND { get; set; }



    }
}

/*
namespace Gerencia_KPIs.Models
{
    [Table("TB_IND_LOG")]
    public class tbl_TB_IND_LOG : BaseEntity
    {
        
    }
}*/