using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportService
{
    public interface IProdutoRepository
    {
        List<ProdutoModel> GetProdutos();
    }
}
