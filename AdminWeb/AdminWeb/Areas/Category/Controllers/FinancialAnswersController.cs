using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class FinancialAnswersController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public FinancialAnswersController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetFinancialAnswersList(DataSourceLoadOptions loadOptions)
        {
            var _response = financialAnswersList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<FinancialAnswersResponseModel> financialAnswersList = new List<FinancialAnswersResponseModel>()
        {
            new FinancialAnswersResponseModel()
            {
                FinAnswerId =1,
                QuestionCode = "HVCC-CHR-01",
                AnswerCode = "HVCC_AS01",
                Index = 1,
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
             new FinancialAnswersResponseModel()
            {
                FinAnswerId =2,
                QuestionCode = "HVCC-CHR-02",
                AnswerCode = "HVCC_AS02",
                Index = 2,
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
              new FinancialAnswersResponseModel()
            {
                FinAnswerId =3,
                QuestionCode = "HVCC-CHR-03",
                AnswerCode = "HVCC_AS03",
                Index = 3,
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
               new FinancialAnswersResponseModel()
            {
                FinAnswerId =4,
                QuestionCode = "HVCC-CHR-04",
                AnswerCode = "HVCC_AS04",
                Index = 4,
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
