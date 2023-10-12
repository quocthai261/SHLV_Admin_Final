using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class HospitalController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HospitalController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Hospital");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }


        public static List<HospitalResponseModel> model = new List<HospitalResponseModel>()
        {
            new HospitalResponseModel {
                        HospitalId = 1,
                        HospitalCode = "01G01",
                        HospitalName = "TRẠM Y TẾ P.  CẦU DIỄN",
                        HospitalNameVN = "TRẠM Y TẾ P.  CẦU DIỄN",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new HospitalResponseModel {
                        HospitalId = 2,
                        HospitalCode = "01A03",
                        HospitalName = "TRẠM Y TẾ P.  CỐNG VỊ (TTYT BA ĐÌNH)",
                        HospitalNameVN = "TRẠM Y TẾ P.  CỐNG VỊ (TTYT BA ĐÌNH)",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new HospitalResponseModel {
                        HospitalId = 3,
                        HospitalCode = "01229G",
                        HospitalName = "TRẠM Y TẾ P.  CỔ NHUẾ 2",
                        HospitalNameVN = "TRẠM Y TẾ P.  CỔ NHUẾ 2",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new HospitalResponseModel {
                        HospitalId = 4,
                        HospitalCode = "01B64",
                        HospitalName = "TRẠM Y TẾ P.  CỰ KHỐI (TTYTQ.LB)",
                        HospitalNameVN = "TRẠM Y TẾ P.  CỰ KHỐI (TTYTQ.LB)",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
