using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class BankController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public BankController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
        public object GetBankList(DataSourceLoadOptions loadOptions)
        {
            var _response = bankList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<BankResponseModel> bankList = new List<BankResponseModel>()
        {

  new BankResponseModel{
    BankId=1,
    BankCode="VCB",
    BankName="NH TMCP NGOẠI THƯƠNG VIỆT NAM (VIETCOMBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel{
    BankId=2,
    BankCode="VCCB",
    BankName="NH TMCP BẢN VIỆT (VIETCAPITAL BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel{
    BankId=3,
    BankCode="VIB",
    BankName="NH TMCP QUỐC TẾ VIỆT NAM (VIB)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel{
    BankId=4,
    BankCode="VID",
    BankName="VID PUBLIC BANK",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel{
BankId=5,
    BankCode="VPB",
    BankName="NH TMCP VIỆT NAM THỊNH VƯỢNG (VPBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel{
BankId=6,
    BankCode="VRB",
    BankName="NH LIÊN DOANH VIỆT – NGA (VR BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel{
    BankId=7,
    BankCode="VTB",
    BankName="NH TMCP CÔNG THƯƠNG VIỆT NAM (VIETINBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
      BankId=8,
    BankCode="WOORI",
    BankName="WOORI BANK VIETNAM",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
      BankId=9,
    BankCode="ABB",
    BankName="NH TMCP AN BÌNH (AB BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
      BankId=10,
    BankCode="ACB",
    BankName="NH TMCP Á CHÂU (ACB)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=11,
    BankCode="AGRIB",
    BankName="NH NÔNG NGHIỆP  NÔNG THÔN VN (AGRIBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=12,
    BankCode="ANZ",
    BankName="AUSTRALIAN  ZEALAND (ANZ)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=13,
    BankCode="BAB",
    BankName="NH TMCP BẮC Á (BACA BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=14,
    BankCode="BI",
    BankName="NH PHÁT TRIỂN VIỆT NAM (VDB)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=15,
    BankCode="BIDV",
    BankName="NH TMCP ĐẦU TƯ VÀ PHÁT TRIỂN VN (BIDV)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
    new BankResponseModel
  {
    BankId=16,
    BankCode="BVB",
    BankName="NH TMCP BẢO VIỆT (BAOVIET BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
    new BankResponseModel
  {
    BankId=17,
    BankCode="CBBank",
    BankName="NH TM TNHH MTV XÂY DỰNG (CB BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now
    },
    new BankResponseModel
  {
    BankId=18,
    BankCode="CITI",
    BankName="CITI BANK",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=19,
    BankCode="COOPB",
    BankName="NH HỢP TÁC XÃ VIỆT NAM (COOPBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=20,
    BankCode="DGACB",
    BankName="NH TMCP ĐÔNG Á (DONGA BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=21,
    BankCode="EXIM",
    BankName="NH TMCP XUẤT NHẬP KHẨU (EXIMBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=22,
    BankCode="GPB",
    BankName="NH TM TNHH MTV DẦU KHÍ TOÀN CẦU (GP BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=23,
    BankCode="HANA",
    BankName="KEB HANA BANK",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=24,
    BankCode="HB",
    BankName="NH TMCP PHÁT TRIỂN TP.HCM (HDBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=25,
    BankCode="HHC",
    BankName="NH TMCP HÀNG HẢI VIỆT NAM (MARITIME BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },  new BankResponseModel
  {
    BankId=26,
    BankCode="HLB",
    BankName="HONG LEONG VIET NAM",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=27,
    BankCode="HSBC",
    BankName="HSBC VIET NAM",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=28,
    BankCode="IVB",
    BankName="INDOVINA BANK",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=29,
    BankCode="KBNN",
    BankName="KHO BẠC NHÀ NƯỚC",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=30,
    BankCode="KLB",
    BankName="NH TMCP KIÊN LONG (KIENLONG BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=31,
    BankCode="LVPB",
    BankName="NH TMCP BƯU ĐIỆN LIÊN VIỆT (LIENVIETBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=32,
    BankCode="MCB",
    BankName="NH TMCP QUÂN ĐỘI (MBBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=33,
    BankCode="NACB",
    BankName="NH TMCP NAM Á (NAMA BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=34,
    BankCode="NCB",
    BankName="NH TMCP QUỐC DÂN (NCB)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=35,
    BankCode="NNB",
    BankName="NGÂN HÀNG NHÀ NƯỚC VIỆT NAM",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
    new BankResponseModel
  {
    BankId=36,
    BankCode="OB",
    BankName="NH TM TNHH MTV ĐẠI DƯƠNG (OCEANBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=37,
    BankCode="ORIC",
    BankName="NH TMCP PHƯƠNG ĐÔNG (OCB)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=38,
    BankCode="PETRO",
    BankName="NH TMCP XĂNG DẦU PETROLIMEX (PG BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=39,
    BankCode="PVCOM",
    BankName="NH TMCP ĐẠI CHÚNG VIỆT NAM (PVCOMBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=40,
    BankCode="SACO",
    BankName="NH TMCP SÀI GÒN THƯƠNG TÍN (SACOMBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=41,
    BankCode="SB",
    BankName="NH TMCP ĐÔNG NAM Á (SEABANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=42,
    BankCode="SCB",
    BankName="STANDARD CHARTERED BANK VIET NAM",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=43,
    BankCode="SGB",
    BankName="NH TMCP SÀI GÒN (SCB)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=44,
    BankCode="SGCT",
    BankName="NH TMCP SÀI GÒN CÔNG THƯƠNG (SAIGON BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=45,
    BankCode="SHB",
    BankName="NH TMCP SÀI GÒN - HÀ NỘI (SHB BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },  new BankResponseModel
  {
    BankId=46,
    BankCode="SHINHAN",
    BankName="SHINHAN BANK VIET NAM",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=47,
    BankCode="TCB",
    BankName="NH TMCP KỸ THƯƠNG VIỆT NAM (TECHCOMBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=48,
    BankCode="TPB",
    BankName="NH TMCP TIÊN PHONG (TPBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=49,
    BankCode="UOB",
    BankName="UNITED OVERSEAS BANK",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=50,
    BankCode="VAB",
    BankName="NH TMCP VIỆT Á (VIETA BANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=51,
    BankCode="VB",
    BankName="NH TMCP VIỆT NAM THƯƠNG TÍN (VIETBANK)",
    BankIcon=null,
    Color1=null,
    Color2=null,
    IsActive=true,
    CreationDate=DateTime.Now,
    CreatedBy=null,
    LastUpdatedDate=DateTime.Now,
    LastUpdatedBy=null
  },
  new BankResponseModel
  {
    BankId=52,
    BankCode="VBSP",
    BankName="NH CHÍNH SÁCH XÃ HỘI",
    BankIcon=null,
    Color1=null,
    Color2=null,
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
