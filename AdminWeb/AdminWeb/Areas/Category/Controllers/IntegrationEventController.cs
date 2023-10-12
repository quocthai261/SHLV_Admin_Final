using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class IntegrationEventController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IntegrationEventController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "IntegrationEvent");
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


        public static List<IntegrationEventResponseModel> model = new List<IntegrationEventResponseModel>()
        {
            new IntegrationEventResponseModel {
                        EventId = 1,
                        Content = "(HUGECLOB)",
                        State = 1,
                        SentTime = 0,
                        EventTypeName = "FIS.Agency.App.Events.UserCreated",
                        TransactionId = "a9c46349-f14e-4a6a-8d84-88a5e7f075cb",

                        CreationDate = DateTime.Now,
                    },
            new IntegrationEventResponseModel {
                        EventId = 2,
                        Content = "(HUGECLOB)",
                        State = 1,
                        SentTime = 0,
                        EventTypeName = "FIS.Agency.App.Events.UserCreated",
                        TransactionId = "63d0ef25-b7f0-49a5-830c-9bfb42f2b990",

                        CreationDate = DateTime.Now,
                    },
            new IntegrationEventResponseModel {
                        EventId = 3,
                        Content = "(HUGECLOB)",
                        State = 1,
                        SentTime = 0,
                        EventTypeName = "FIS.Agency.App.Events.UserCreated",
                        TransactionId = "b3900a95-e33a-4c2d-96c6-6485de041a23",

                        CreationDate = DateTime.Now,
                    },
            new IntegrationEventResponseModel {
                        EventId = 4,
                        Content = "(HUGECLOB)",
                        State = 1,
                        SentTime = 0,
                        EventTypeName = "FIS.Agency.App.Events.UserCreated",
                        TransactionId = "40218f33-f683-442f-ab6e-7eba1d7a116e",

                        CreationDate = DateTime.Now,
                    },
        };
    }
}
