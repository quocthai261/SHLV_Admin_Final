using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class AnswersController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public AnswersController(IApiService apiService)
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

        public object GetCriteriaList(DataSourceLoadOptions loadOptions)
        {

            var _respone = criteriasList;
            return DataSourceLoader.Load(_respone, loadOptions);
        }

        [HttpGet]
        public object GetAnswersList(DataSourceLoadOptions loadOptions)
        {
            var _response = answerList;

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

        public static List<AnswersResponseModel> answerList = new List<AnswersResponseModel>()
        {
            new AnswersResponseModel {
                        AnswerId = 1,
                        CriteriaId = 1,
                        AnswerContent = "Gọi thoại và hình (video call) qua ứng dụng Zalo, Viber, Messenger…",
                        Index = 1,
                        AnswerCode = "2",
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new AnswersResponseModel {
                        AnswerId = 2,
                        CriteriaId = 1,
                        AnswerContent = "Gặp mặt trực tiếp",
                        Index = 1,
                        AnswerCode = "1",
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new AnswersResponseModel {
                        AnswerId = 3,
                        CriteriaId = 3,
                        AnswerContent = "Không",
                        Index = 3,
                        AnswerCode = "0",
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new AnswersResponseModel {
                        AnswerId = 4,
                        CriteriaId = 4,
                        AnswerContent = "Tôi sẽ chịu trách nhiệm với Công ty nếu có bất cứ thông tin, hồ sơ, hình ảnh nào của ứng viên được kê khai, cung cấp không trung thực.",
                        Index = 1,
                        AnswerCode = "1",
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        #endregion
    }
}
