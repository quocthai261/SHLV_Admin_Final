using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class CriteriasController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public CriteriasController(IApiService apiService)
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

        #region -- Methods --

        [HttpGet]
        public object GetCriteriasList(DataSourceLoadOptions loadOptions)
        {
            var _response = criteriasList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<CriteriasResponseModel> criteriasList = new List<CriteriasResponseModel>()
        {
            new CriteriasResponseModel {
                        CriteriaId = 1,
                        CriteriaContent = "Đánh giá về ứng viên (SDM)",
                        CriteriaType = 3,
                        CriteriaCode = "p_INTERVIEW_AD",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new CriteriasResponseModel {
                        CriteriaId = 3,
                        CriteriaContent = "Đánh giá về ứng viên (UM/DM)",
                        CriteriaType = 3,
                        CriteriaCode = "P_EVALUATION_CANDIDATE",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new CriteriasResponseModel {
                        CriteriaId = 4,
                        CriteriaContent = "Cam kết của người quản lý trực tiếp",
                        CriteriaType = 1,
                        CriteriaCode = "P_EVALUATION_CANDIDATE",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        #endregion
    }
}
