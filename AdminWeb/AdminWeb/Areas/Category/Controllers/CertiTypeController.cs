using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdminWeb.Areas.Category.Controllers
{
    public class CertiTypeController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CertiTypeController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "CertiType");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region -- Methods --

        [HttpGet]
        public object GetCertiTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = certiTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<CertiTypeResponseModel> certiTypeList = new List<CertiTypeResponseModel>()
        {
            new CertiTypeResponseModel {
                        CertiTypeId = 1,
                        CertiTypeName = "Birth certificate",
                        CertiTypeNameVN = "Giấy khai sinh",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new CertiTypeResponseModel {
                        CertiTypeId = 2,
                        CertiTypeName = "Passport",
                        CertiTypeNameVN = "Hộ chiếu",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new CertiTypeResponseModel {
                        CertiTypeId = 3,
                        CertiTypeName = "Other",
                        CertiTypeNameVN = "Khác",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new CertiTypeResponseModel {
                        CertiTypeId = 4,
                        CertiTypeName = "VN National ID",
                        CertiTypeNameVN = "CMND/CCCD",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        #endregion
    }
}
