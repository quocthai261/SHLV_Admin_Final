using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class SyncScheduleTypeController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public SyncScheduleTypeController(IApiService apiService)
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
        public object GetSyncScheduleTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = syncScheduleTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SyncScheduleTypeResponseModel> syncScheduleTypeList = new List<SyncScheduleTypeResponseModel>()
        {
            new SyncScheduleTypeResponseModel
            {
                ScheduleTypeId = 1,
                Description = "Second"
            },
            new SyncScheduleTypeResponseModel
            {
                ScheduleTypeId = 2,
                Description = "Minute"
            },
            new SyncScheduleTypeResponseModel
            {
                ScheduleTypeId = 3,
                Description = "Hour"
            },
            new SyncScheduleTypeResponseModel
            {
                ScheduleTypeId = 4,
                Description = "Daily"
            },
            new SyncScheduleTypeResponseModel
            {
                ScheduleTypeId = 5,
                Description = "Weekly"
            }

        };
    }
}
