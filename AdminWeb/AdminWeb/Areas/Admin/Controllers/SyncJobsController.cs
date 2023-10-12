using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class SyncJobsController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public SyncJobsController(IApiService apiService)
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
        public object GetSyncJobsList(DataSourceLoadOptions loadOptions)
        {
            var _response = syncJobsList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SyncJobsResponseModel> syncJobsList = new List<SyncJobsResponseModel>()
        {
            new SyncJobsResponseModel()
            {
                JobId = 1,
                ScheduleTypeId = 4,
                ScheduleDescription="Occurs every day at 22:00:00",
                Description="Đồng bộ thông tin tình trạng sản phẩm chính",
                JobIsRunning=true,
            },
             new SyncJobsResponseModel()
            {
                JobId = 2,
                ScheduleTypeId = 3,
                ScheduleDescription="Occurs hour interval , interval = 5000",
                Description="Đồng bộ thông tin tên bệnh viện",
                JobIsRunning = false,
            },
             new SyncJobsResponseModel()
            {
                JobId = 27,
                ScheduleTypeId = 3,
                ScheduleDescription="Occurs every day at 22:00:00 ",
                Description="Đồng bộ thông tin phương pháp vô cảm",
                JobIsRunning = false,
            },
              new SyncJobsResponseModel()
            {
                JobId = 28,
                ScheduleTypeId = 4,
                ScheduleDescription="Occurs every day at 22:00:00 ",
                Description="Đồng bộ thông tin loại giấy tờ tùy thân",
                JobIsRunning = true,
            },
              new SyncJobsResponseModel()
            {
                JobId = 29,
                ScheduleTypeId = 4,
                ScheduleDescription="Occurs every day at 22:00:00 ",
                Description="Đồng bộ thông tin định kỳ đóng phí",
                JobIsRunning = true,
            },
              new SyncJobsResponseModel()
            {
                JobId = 30,
                ScheduleTypeId = 4,
                ScheduleDescription="Occurs every day at 22:00:00 ",
                Description="Đồng bộ thông tin tình trạng hợp đồng",
                JobIsRunning = true,
            },
              new SyncJobsResponseModel()
            {
                JobId = 30,
                ScheduleTypeId = 4,
                ScheduleDescription="Occurs every day at 22:00:00 ",
                Description="Đồng bộ thông tin giới tính",
                JobIsRunning = true,
            },
        };
    }
}
