using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ReportService
{
    public class ProdutoRepository : IProdutoRepository
    {       
        private AppDbConnection _context;

        public ProdutoRepository(AppDbConnection context)
        {
            _context = context;
        }

        public List<ProdutoModel> GetProdutos()
        {           
            //Retorna os produtos da filial desejada <FAÇA O FILTRO COMO PREFERIR>
            return _context.produtoModel.Where(p => p.id_filial == 174).ToList();
        }
    }
}
