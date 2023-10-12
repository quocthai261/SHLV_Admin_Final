using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class BankOrgController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public BankOrgController(IApiService apiService)
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
        public object GetBankOrgList(DataSourceLoadOptions loadOptions)
        {
            var _response = bankOrgList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<BankOrgResponseModel> bankOrgList = new List<BankOrgResponseModel>()
        {

            new BankOrgResponseModel
            {
                BankOrgId = 5,
                BankOrgName = "NH Liên doanh Việt – Nga (VR Bank)",
                BankName = "NH Liên doanh Việt – Nga (VR Bank)",
                BankOrgCode = "VRB",
                IdType = 3,
                IdNumber = null,
                AbbrName = "VRB",
                Status = "1",
                IsActive=true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = null
            },
            new BankOrgResponseModel
            {
                BankOrgId = 6,
                BankOrgName = "NH TMCP Đông Nam Á (SeaBank)",
                BankName = "NH TMCP Đông Nam Á (SeaBank)",
                BankOrgCode = "SB",
                IdType = 3,
                IdNumber = null,
                AbbrName = "SEABANK",
                Status = "1",
                IsActive=true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = null
            },
            new BankOrgResponseModel
            {
                BankOrgId = 7,
                BankOrgName = "First Commercial Bank",
                BankName = "First Commercial Bank",
                BankOrgCode = "FCB",
                IdType = 3,
                IdNumber = null,
                AbbrName = "FCB",
                Status = "2",
                IsActive=true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = null
            },
            new BankOrgResponseModel
            {
                BankOrgId = 8,
                BankOrgName = "H.O_Write-off",
                BankOrgCode = "Write-off",
                IdType = 30,
                IdNumber = "999999999",
                AbbrName = "H.O_Write-off",
                Status = "1",
                IsActive=true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = null
            },
            new BankOrgResponseModel
            {
                BankOrgId = 9,
                BankOrgName = "NH TMCP Gia Định (GDB)",
                BankOrgCode = "GDB",
                IdType = 3,
                IdNumber = null,
                AbbrName = "GIADINHBANK",
                Status = "2",
                IsActive=true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = null
            },
            new BankOrgResponseModel
            {
                BankOrgId = 10,
                BankOrgName = "Chinfon Bank",
                BankOrgCode = "CFB",
                IdType = 3,
                IdNumber = null,
                AbbrName = "CHINFONBANK",
                Status = "2",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = null
            },

  new BankOrgResponseModel {
    BankOrgId=11,
    BankOrgName="NH TMCP Nhà Hà Nội",
    BankOrgCode="PTN",
    IdType=3,
    IdNumber=null,
    AbbrName="PTN",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=12,
    BankOrgName="Withholding PIT",
    BankOrgCode="PIT",
    IdType=30,
    IdNumber="123456789",
    AbbrName="Withholding PIT",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=13,
    BankOrgName="NH TMCP (TECO)",
    BankOrgCode="TECO",
    IdType=3,
    IdNumber=null,
    AbbrName="TECO",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=14,
    BankOrgName="NH Nông nghiệp & PT Nông thôn VN (AGRIBANK)",
    BankOrgCode="AGRIB",
    IdType=3,
    IdNumber=null,
    AbbrName="AGRIBANK",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=15,
    BankOrgName="NH TM TNHH MTV Xây dựng (CB Bank)",
    BankOrgCode="CBBank",
    IdType=3,
    IdNumber=null,
    AbbrName="CBBank",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=16,
    BankOrgName="H.O_WOORI_VND",
    BankOrgCode="WOORI",
    IdType=30,
    IdNumber="999999999",
    AbbrName="H.O_WOORI_VND",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=17,
    BankOrgName="NH TMCP Sài Gòn (SCB)",
    BankOrgCode="SGB",
    IdType=3,
    IdNumber=null,
    AbbrName="SCB",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=18,
    BankOrgName="NH Hợp tác xã Việt Nam (CoopBank)",
    BankOrgCode="COOPB",
    IdType=3,
    IdNumber=null,
    AbbrName="COOPB",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=19,
    BankOrgName="Ngan hang MUFG bank",
    BankOrgCode="BTM",
    IdType=3,
    IdNumber=null,
    AbbrName="BTM",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=20,
    BankOrgName="Kho Bạc Nhà Nước",
    BankOrgCode="KBNN",
    IdType=3,
    IdNumber=null,
    AbbrName="KHOBACNHANUOC",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=21,
    BankOrgName="NH TMCP Bảo Việt (BaoViet Bank)",
    BankOrgCode="BVB",
    IdType=9,
    IdNumber="999999",
    AbbrName="BAOVIETBANK",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=22,
    BankOrgName="Credit Lyonnais Co",
    BankOrgCode="CLC",
    IdType=3,
    IdNumber=null,
    AbbrName="CLC",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=23,
    BankOrgName="NH TMCP Sài Gòn Thương Tín (Sacombank)",
    BankOrgCode="SACO",
    IdType=30,
    IdNumber=null,
    AbbrName="SACOMBANK",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=24,
    BankOrgName="Sumitomo-Mitsui Banking Corporation",
    BankOrgCode="SUMI",
    IdType=3,
    IdNumber=null,
    AbbrName="SMBC",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=25,
    BankOrgName="NH TMCP Phương Tây (Western Bank)",
    BankOrgCode="WEB",
    IdType=3,
    IdNumber=null,
    AbbrName="WESTERNBANK",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=26,
    BankOrgName="NH TMCP Việt",
    BankOrgCode="VHCB",
    IdType=3,
    IdNumber=null,
    AbbrName="VHCB",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=27,
    BankOrgName="NH TMCP Nam Đô",
    BankOrgCode="NDCB",
    IdType=3,
    IdNumber=null,
    AbbrName="NAMDOBANK",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=28,
    BankOrgName="Chohung Vina Bank",
    BankOrgCode="CHVB",
    IdType=3,
    IdNumber=null,
    AbbrName="CHVB",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=29,
    BankOrgName="Dai-ichi Kangyo Bank Ltd",
    BankOrgCode="DIKB",
    IdType=3,
    IdNumber=null,
    AbbrName="DIKB",
    Status="2",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankOrgResponseModel {
    BankOrgId=30,
    BankOrgName="NH TMCP Phương Đông (OCB)",
    BankOrgCode="ORIC",
    IdType=3,
    IdNumber=null,
    AbbrName="OCB",
    Status="1",
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  }


            #endregion
        };
    }
}
