using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class RegisterContestController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RegisterContestController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
        {
            _apiService = apiService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "RegisterContest");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetRegisterContestList(DataSourceLoadOptions loadOptions)
        {
            var _response = registerContestList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<RegisterContestResponseModel> registerContestList = new List<RegisterContestResponseModel>()
        {
            new RegisterContestResponseModel()
            {
                RegisterContestId = 1,
                UserId = 1,
                FCCode  = "62209577",
                ContestId = "4aa3cae0zsty82r5anewfmwt50",
                RegisterDate = DateTime.Now,
                Option = "Chọn 1",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new RegisterContestResponseModel()
            {
                RegisterContestId = 2,
                UserId = 1,
                FCCode  = "62209577",
                ContestId = "45xbbyyhebfcgrhqe2s51bx842",
                RegisterDate = DateTime.Now,
                Option = "Chọn 2",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new RegisterContestResponseModel()
            {
                RegisterContestId = 3,
                UserId = 1,
                FCCode  = "62209577",
                ContestId = "4aa3cae0zsty82r5anewfmwt50",
                RegisterDate = DateTime.Now,
                Option = "Chọn 3",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
