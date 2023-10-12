using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class FinancialQuestionController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public FinancialQuestionController(IApiService apiService)
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
        public object GetFinancialQuestionList(DataSourceLoadOptions loadOptions)
        {
            var _response = financialQuestionList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<FinancialQuestionResponseModel> financialQuestionList = new List<FinancialQuestionResponseModel>()
        {
            new FinancialQuestionResponseModel {
    FinQuestionId = 1,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-01",
    QuestionName = "Gia đình Anh (Chị) có bao nhiêu con?",
    QuestionType = 1,
    Step = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 2,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-01",
    QuestionName = "Gia đình Anh (Chị) có bao nhiêu con?",
    QuestionType = 1,
    Step = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 3,
    ProductTypeCode = "HTTV",
    QuestionCode = "HTTV_QE01",
    QuestionName = "Đâu là mối quan tâm hàng đầu của Anh (Chị) và gia đình mình?",
    QuestionType = 1,
    Step = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Parse("2022-01-24T18:30:20"),
    LastUpdatedBy = 1
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 4,
    ProductTypeCode = "HTTV",
    QuestionCode = "HTTV_QE02",
    QuestionName = "Anh (Chị) mong muốn an hưởng tuổi vàng của mình như thế nào:",
    QuestionType = 1,
    Step = 2,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 5,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-02",
    QuestionName = "Chọn thông tin giới tính",
    QuestionType = 1,
    Step = 2,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:10:36"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 6,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-03",
    QuestionName = "Nhập thông tin tên khách hàng",
    QuestionType = 1,
    Step = 3,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:11:40"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 7,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-04",
    QuestionName = "Nhập thông tin ngày sinh",
    QuestionType = 1,
    Step = 4,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:12:11"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 8,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-05",
    QuestionName = "Điều Anh/Chị mong muốn nhất đối với bé là gì?",
    QuestionType = 1,
    Step = 5,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:12:41"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 9,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-06",
    QuestionName = "Anh chị đã tính toán cho bé, khi lớn lên học trường nào chưa?",
    QuestionType = 1,
    Step = 6,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:14:23"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 10,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-CHR-07",
    QuestionName = "Anh chị cần bao nhiêu tiền, để cho tương lai học vấn của bé?",
    QuestionType = 1,
    Step = 7,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:16:59"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 11,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-ACMLT-01",
    QuestionName = "Hiện tại anh chị đã chuẩn bị được bao nhiêu cho quỹ giáo dục này?",
    QuestionType = 1,
    Step = 8,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:17:27"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 12,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-ACMLT-02",
    QuestionName = "Lãi suất dự kiến",
    QuestionType = 1,
    Step = 9,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:17:53"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 13,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-ACMLT-03",
    QuestionName = "Khoản thiếu hụt/ dư thừa",
    QuestionType = 1,
    Step = 10,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:18:29"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 14,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-ACMLT-04",
    QuestionName = "Khi nào anh chị bắt đầu tích lũy cho số tiền còn thiếu?",
    QuestionType = 1,
    Step = 11,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:19:03"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 15,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-ACMLT-05",
    QuestionName = "Thử thách khi tiết kiệm/ sức mạnh của lãi kép",
    QuestionType = 1,
    Step = 12,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:20:17"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 16,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-01",
    QuestionName = "Tim mạch",
    QuestionType = null,
    Step = null,
    IsActive = null,
    CreationDate = null,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 17,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-01",
    QuestionName = "Tim mạch",
    QuestionType = 1,
    Step = 13,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:21:49"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 18,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-02",
    QuestionName = "Ung thư",
    QuestionType = 1,
    Step = 14,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:22:24"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 19,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-03",
    QuestionName = "Tai nạn giao thông",
    QuestionType = 1,
    Step = 15,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:22:50"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 20,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-04",
    QuestionName = "Theo Anh chị, giải pháp nào để quỹ giáo dục dành cho tương lai học vấn của con yêu được chu toàn, dù mọi bất trắc có thể xảy ra cho người trụ cột",
    QuestionType = 1,
    Step = 16,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:23:17"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 21,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-05",
    QuestionName = "Liệu Anh chị có chắc chắn 100% ở tuổi 60",
    QuestionType = 1,
    Step = 17,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:25:53"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 22,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-06",
    QuestionName = "Gia đình nợ nần và nghèo khó vì tai nạn giao thông",
    QuestionType = 1,
    Step = 18,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:29:09"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 23,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-MED-07",
    QuestionName = "Nước mắt vợ chồng có con bị bệnh",
    QuestionType = 1,
    Step = 19,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:29:38"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 24,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-SLT-01",
    QuestionName = "Vậy đâu là giải pháp?",
    QuestionType = 1,
    Step = 20,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:30:09"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  },
  new FinancialQuestionResponseModel {
    FinQuestionId = 25,
    ProductTypeCode = "HVCC",
    QuestionCode = "HVCC-SLT-02",
    QuestionName = "Anh chị định tích lũy bao nhiêu tiền mỗi năm cho giải pháp này?",
    QuestionType = 1,
    Step = 21,
    IsActive = true,
    CreationDate = DateTime.Parse("2022-02-09T11:30:31"),
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
  }
        };

        #endregion
    }
}
