using System.ComponentModel.DataAnnotations.Schema;

namespace ReportService
{
    [Table("Produto")]
    public partial class ProdutoModel
    {
        public int id { get; set; }

        public string nome { get; set; }
       
        public int seq { get; set; }

        public int id_filial { get; set; }
        
    }
}
