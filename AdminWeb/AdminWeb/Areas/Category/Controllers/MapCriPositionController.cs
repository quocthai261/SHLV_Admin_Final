using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class MapCriPositionController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public MapCriPositionController(IApiService apiService)
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
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetPositionList(DataSourceLoadOptions loadOptions)
        {
            var _response = positionList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<PositionResponseModel> positionList = new List<PositionResponseModel>()
        {
            new PositionResponseModel {
                        PositionId = 1,
                        PositionCode = "FC",
                        PositionName = "Tư vấn viên tài chính",
                        IsRegister = true,
                        IsApproval = true,
                        NextPosition = "RM",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PositionResponseModel {
                        PositionId = 2,
                        PositionCode = "UM",
                        PositionName = "Quản lý ban KD",
                        IsRegister = true,
                        IsApproval = true,
                        NextPosition = "DM",
                        IsActive = false,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PositionResponseModel {
                        PositionId = 3,
                        PositionCode = "DM",
                        PositionName = "Quản lý KVKD",
                        IsRegister = true,
                        IsApproval = true,
                        NextPosition = "SrDM",
                        IsActive = false,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };


        public static List<CriteriasResponseModel> model = new List<CriteriasResponseModel>()
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
    }
}
