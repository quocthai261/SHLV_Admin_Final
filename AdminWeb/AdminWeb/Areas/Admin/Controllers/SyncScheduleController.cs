using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class SyncScheduleController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public SyncScheduleController(IApiService apiService)
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
        public object GetSyncScheduleList(DataSourceLoadOptions loadOptions)
        {
            var _response = syncScheduleList;

            return DataSourceLoader.Load(_response, loadOptions);
        }
        [HttpGet]
        public object GetSchedule(DataSourceLoadOptions loadOptions)
        {
            var _response = scheduleList;
            return DataSourceLoader.Load(_response, loadOptions);
        }
        public static List<SyncScheduleResponseModel> syncScheduleList = new List<SyncScheduleResponseModel>()
        {


        };
        public static ScheduleModel[] scheduleList = new[] {
            new ScheduleModel
            {
                ID = 1,
                Text = "Monday"
            },
            new ScheduleModel
            {
                ID = 2,
                Text = "Tuesday"
            },
            new ScheduleModel
            {
                ID = 3,
                Text = "Wednesday"
            },
            new ScheduleModel
            {
                ID = 4,
                Text = "Thursday"
            },
            new ScheduleModel
            {
                ID = 5,
                Text = "Friday"
            },
            new ScheduleModel
            {
                ID = 6,
                Text = "Saturday"
            },
            new ScheduleModel
            {
                ID = 7,
                Text = "Sunday"
            }
        };
    }
}
