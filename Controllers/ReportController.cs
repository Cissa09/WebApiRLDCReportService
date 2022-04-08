using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReportService
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IProdutoRepository _produtoRepository;
        public ReportController(IWebHostEnvironment webHostEnvironment, IProdutoRepository produtoRepository)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._produtoRepository = produtoRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Print()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\rptProdutos.rdlc";
            Dictionary<string, string> parametros = new Dictionary<string, string>();
            var produtos = _produtoRepository.GetProdutos();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("DataSet1", produtos);
            var result = localReport.Execute(RenderType.Pdf, extension, parametros, mimtype);
            return File(result.MainStream, "application/pdf");
        }        
    }
}
