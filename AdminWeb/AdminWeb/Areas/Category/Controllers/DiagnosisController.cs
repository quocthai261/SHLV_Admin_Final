using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class DiagnosisController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DiagnosisController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Diagnosis");
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
        public object GetDiagnosisList(DataSourceLoadOptions loadOptions)
        {
            var _response = diagnosisList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<DiagnosisResponseModel> diagnosisList = new List<DiagnosisResponseModel>()
        {
  new DiagnosisResponseModel
  {
      DiagnosisId = 235,
      DiagnoDescription = "Nang bào thai của vòi trứng (Q50.4)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q50.4",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 236,
      DiagnoDescription = "Nang nguồn gốc bào thai của dây chằng rộng (Q50.5)",
      ParentId = 16313,
      DiagnoCategory = 1,
      DiagnoName = "Q50.5",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 237,
      DiagnoDescription = "Những dị tật bẩm sinh khác của vòi trứng và dây chằng rộng (Q50.6)",
      ParentId = 16313,
      DiagnoCategory = 2,
      DiagnoName = "Q50.6",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 238,
      DiagnoDescription = "Dị tật bẩm sinh của tử cung và cổ tử cung (Q51)",
      ParentId = 16313,
      DiagnoCategory = 2,
      DiagnoName = "Q51",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 239,
      DiagnoDescription = "Bất sản và ngừng phát triển của tử cung (Q51.0)",
      ParentId = 16313,
      DiagnoCategory = 1,
      DiagnoName = "Q51.0",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 240,
      DiagnoDescription = "Tử cung đôi với cổ tử cung và âm đạo đôi (Q51.1)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q51.1",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 241,
      DiagnoDescription = "Các loại tử cung đôi khác (Q51.2)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q51.2",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 242,
      DiagnoDescription = "Tử cung hai sừng (Q51.3)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q51.3",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 243,
      DiagnoDescription = "Tử cung một sừng (Q51.4)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q51.4",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 244,
      DiagnoDescription = "Bất sản và ngừng phát triển của cổ tử cung (Q51.5)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q51.5",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  },
  new DiagnosisResponseModel
  {
      DiagnosisId = 245,
      DiagnoDescription = "Nang nguồn gốc bào thai của cổ tử cung (Q51.6)",
      ParentId = 16313,
      DiagnoCategory = 3,
      DiagnoName = "Q51.6",
      Acceptable = "N",
      IsActive = true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = null,
      LastUpdatedBy = null
  }
        };
        #endregion
    }
}
