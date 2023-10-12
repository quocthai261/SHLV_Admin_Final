using AdminWeb.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System;
using Microsoft.AspNetCore.Http;

namespace AdminWeb.ViewComponents
{
    public class vcNavbar : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public vcNavbar(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteMap = await GetSiteMap();
            ViewData["ActiveMenuItemSystemName"] = _httpContextAccessor.HttpContext.Session.GetString("ActiveMenuItemSystemName");
            ViewData["ActiveParentMenuSystemName"] = _httpContextAccessor.HttpContext.Session.GetString("ActiveParentMenuSystemName");

            return View();
        }

        private async Task<IEnumerable<TreeMenuItem<SiteMapNode>>> GetSiteMap()
        {
            IEnumerable<TreeMenuItem<SiteMapNode>> siteMap = null;

            List<SiteMapNode> menus = null;

            menus = new List<SiteMapNode>()
                {
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Chức năng nhân viên nghiệp vụ",
                        ICONCLASS = "bi bi-people-fill",
                        ID = 1,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = null,
                        SYSTEMNAME = "BUFeature",
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Duyệt thay đổi thông tin đại lý",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 2,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 1,
                        SYSTEMNAME = "AgentInfoChange",
                        URL = null,
                        URL_ =  "BUFeature/AgentInfoChange"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Duyệt chuyển đổi đại lý",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 3,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 1,
                        SYSTEMNAME = "ApprovalChangeAgency",
                        URL = null,
                        URL_ =  "BUFeature/ApprovalChangeAgency"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Duyệt chấm dứt hợp đồng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 4,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 1,
                        SYSTEMNAME = "ApprovalAgentTermination",
                        URL = null,
                        URL_ =  "BUFeature/ApprovalAgentTermination"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình thông báo",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 5,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 1,
                        SYSTEMNAME = "Notification",
                        URL = null,
                        URL_ =  "BUFeature/Notification"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quy trình chuyển đổi đại lý",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 6,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 1,
                        SYSTEMNAME = "ApprovalConfiguration",
                        URL = null,
                        URL_ =  "BUFeature/ApprovalConfiguration"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "DanhMuc",
                        ICONCLASS = "bi bi-receipt-cutoff",
                        ID = 7,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = null,
                        SYSTEMNAME = "Category",
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quốc gia",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 8,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 7,
                        SYSTEMNAME = "Nationalities",
                        URL = null,
                        URL_ =  "Category/Nationalities"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tỉnh thành phố",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 9,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 7,
                        SYSTEMNAME = "Province",
                        URL = null,
                        URL_ =  "Category/Province"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quận / huyện",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 10,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 7,
                        SYSTEMNAME = "District",
                        URL = null,
                        URL_ =  "Category/District"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Phường/Xã",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 11,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 7,
                        SYSTEMNAME = "Ward",
                        URL = null,
                        URL_ =  "Category/Ward"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Giới tính",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 12,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 7,
                        SYSTEMNAME = "Gender",
                        URL = null,
                        URL_ =  "Category/Gender"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Nhóm điện thoại",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 13,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 6,
                        PARENTID = 7,
                        SYSTEMNAME = "GroupPhoneNumber",
                        URL = null,
                        URL_ =  "Category/GroupPhoneNumber"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Danh mục ngân hàng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 14,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 7,
                        PARENTID = 7,
                        SYSTEMNAME = "Bank",
                        URL = null,
                        URL_ =  "Category/Bank"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Chi nhánh ngân hàng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 15,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 8,
                        PARENTID = 7,
                        SYSTEMNAME = "BankOrg",
                        URL = null,
                        URL_ =  "Category/BankOrg"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại khách hàng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 16,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 9,
                        PARENTID = 7,
                        SYSTEMNAME = "CustomerType",
                        URL = null,
                        URL_ =  "Category/CustomerType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại giấy tờ tùy thân",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 17,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 10,
                        PARENTID = 7,
                        SYSTEMNAME = "CertiType",
                        URL = null,
                        URL_ =  "Category/CertiType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Mối quan hệ",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 18,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 11,
                        PARENTID = 7,
                        SYSTEMNAME = "Relation",
                        URL = null,
                        URL_ =  "Category/Relation"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Bệnh viện",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 19,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 12,
                        PARENTID = 7,
                        SYSTEMNAME = "Hospital",
                        URL = null,
                        URL_ =  "Category/Hospital"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại chẩn đoán",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 20,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 13,
                        PARENTID = 7,
                        SYSTEMNAME = "DiagnosisCategory",
                        URL = null,
                        URL_ =  "Category/DiagnosisCategory"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Chẩn đoán",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 21,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 14,
                        PARENTID = 7,
                        SYSTEMNAME = "Diagnosis",
                        URL = null,
                        URL_ =  "Category/Diagnosis"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại sản phẩm chính",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 22,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 15,
                        PARENTID = 7,
                        SYSTEMNAME = "FinancialProductType",
                        URL = null,
                        URL_ =  "Category/FinancialProductType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại sản phẩm bổ sung",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 222,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 15,
                        PARENTID = 7,
                        SYSTEMNAME = "FinancialProductTypeSub",
                        URL = null,
                        URL_ =  "Category/FinancialProductTypeSub"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tình trạng phí của sản phẩm chính",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 23,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 16,
                        PARENTID = 7,
                        SYSTEMNAME = "PremiumStatus",
                        URL = null,
                        URL_ =  "Category/PremiumStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tình trạng sản phẩm",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 24,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 17,
                        PARENTID = 7,
                        SYSTEMNAME = "LiablityStatus",
                        URL = null,
                        URL_ =  "Category/LiablityStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Trạng thái hợp đồng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 25,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 18,
                        PARENTID = 7,
                        SYSTEMNAME = "PolicyStatus",
                        URL = null,
                        URL_ =  "Category/PolicyStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại quyền lợi bảo hiểm",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 26,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 19,
                        PARENTID = 7,
                        SYSTEMNAME = "ClaimType",
                        URL = null,
                        URL_ =  "Category/ClaimType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tình trạng hồ sơ",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 27,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 20,
                        PARENTID = 7,
                        SYSTEMNAME = "ClaimStatus",
                        URL = null,
                        URL_ =  "Category/ClaimStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại tình trạng hôn nhân",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 28,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 21,
                        PARENTID = 7,
                        SYSTEMNAME = "Marriage",
                        URL = null,
                        URL_ =  "Category/Marriage"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại thanh toán",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 29,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 22,
                        PARENTID = 7,
                        SYSTEMNAME = "PayMode",
                        URL = null,
                        URL_ =  "Category/PayMode"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại lý do",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 30,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 23,
                        PARENTID = 7,
                        SYSTEMNAME = "Reason",
                        URL = null,
                        URL_ =  "Category/Reason"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Danh sách tài liệu",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 31,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 24,
                        PARENTID = 7,
                        SYSTEMNAME = "DocumentType",
                        URL = null,
                        URL_ =  "Category/DocumentType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Vị trí kế tiếp",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 32,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 25,
                        PARENTID = 7,
                        SYSTEMNAME = "MappingNextPosition",
                        URL = null,
                        URL_ =  "Category/MappingNextPosition"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Vị trí",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 33,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 26,
                        PARENTID = 7,
                        SYSTEMNAME = "Position",
                        URL = null,
                        URL_ =  "Category/Position"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tiêu chí thăng/giáng chức",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 34,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 27,
                        PARENTID = 7,
                        SYSTEMNAME = "ProDeCriteria",
                        URL = null,
                        URL_ =  "Category/ProDeCriteria"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Đăng ký thi đua",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 35,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 28,
                        PARENTID = 7,
                        SYSTEMNAME = "RegisterContest",
                        URL = null,
                        URL_ =  "Category/RegisterContest"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Kỳ lương",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 36,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 29,
                        PARENTID = 7,
                        SYSTEMNAME = "SalaryPeriod",
                        URL = null,
                        URL_ =  "Category/SalaryPeriod"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Kế hoạch kinh doanh",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 37,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 30,
                        PARENTID = 7,
                        SYSTEMNAME = "SalePlanConfig",
                        URL = null,
                        URL_ =  "Category/SalePlanConfig"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại kế hoạch kinh doanh",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 38,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 31,
                        PARENTID = 7,
                        SYSTEMNAME = "SalePlanTypes",
                        URL = null,
                        URL_ =  "Category/SalePlanTypes"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình thăng/giáng chức",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 39,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 32,
                        PARENTID = 7,
                        SYSTEMNAME = "ConfigProDemotion",
                        URL = null,
                        URL_ =  "Category/ConfigProDemotion"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại chuyển đổi đại lý",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 40,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 33,
                        PARENTID = 7,
                        SYSTEMNAME = "AgentMoveTypes",
                        URL = null,
                        URL_ =  "Category/AgentMoveTypes"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Biểu mẫu email",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 41,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 34,
                        PARENTID = 7,
                        SYSTEMNAME = "EmailTemplate",
                        URL = null,
                        URL_ =  "Category/EmailTemplate"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình công thức",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 42,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 35,
                        PARENTID = 7,
                        SYSTEMNAME = "Formula",
                        URL = null,
                        URL_ =  "Category/Formula"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Sự kiện",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 43,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 36,
                        PARENTID = 7,
                        SYSTEMNAME = "IntegrationEvent",
                        URL = null,
                        URL_ =  "Category/IntegrationEvent"
                    },

                     new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Nguồn thu nhập",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 59,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 37,
                        PARENTID = 7,
                        SYSTEMNAME = "Income",
                        URL = null,
                        URL_ = "Category/Income"
                    },
                     new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Nghề nghiệp",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 60,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 38,
                        PARENTID = 7,
                        SYSTEMNAME = "Career",
                        URL = null,
                        URL_ = "Category/Career"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản trị hệ thống",
                        ICONCLASS = "bi bi-gear",
                        ID = 44,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = null,
                        SYSTEMNAME = "Admin",
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Người dùng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 45,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 44,
                        SYSTEMNAME = "Users",
                        URL = null,
                        URL_ = "Admin/Users"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Nhóm người dùng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 46,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 44,
                        SYSTEMNAME = "Roles",
                        URL = null,
                        URL_ = "Admin/Roles"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý quyền",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 47,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 44,
                        SYSTEMNAME = "Permissions",
                        URL = null,
                        URL_ = "Admin/Permissions"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý Menu",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 48,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 44,
                        SYSTEMNAME = "Menu",
                        URL = null,
                        URL_ = "Admin/Menu"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý Menu Mobile",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 49,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 44,
                        SYSTEMNAME = "MenuMobile",
                        URL = null,
                        URL_ = "Admin/MenuMobile"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý log",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 50,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 6,
                        PARENTID = 44,
                        SYSTEMNAME = "ActivityLog",
                        URL = null,
                        URL_ = "Admin/ActivityLog"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý ứng dụng",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 51,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 7,
                        PARENTID = 44,
                        SYSTEMNAME = "Application",
                        URL = null,
                        URL_ = "Admin/Application"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý ngôn ngữ",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 52,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 8,
                        PARENTID = 44,
                        SYSTEMNAME = "Language",
                        URL = null,
                        URL_ = "Admin/Language"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý thông báo",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 53,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 9,
                        PARENTID = 44,
                        SYSTEMNAME = "LocaleMessage",
                        URL = null,
                        URL_ = "Admin/LocaleMessage"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình mật khẩu",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 54,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 10,
                        PARENTID = 44,
                        SYSTEMNAME = "Setting",
                        URL = null,
                        URL_ = "Admin/Setting"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình SMTP",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 55,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 11,
                        PARENTID = 44,
                        SYSTEMNAME = "SmtpConfig",
                        URL = null,
                        URL_ = "Admin/SmtpConfig"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý job và đồng bộ",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 56,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 12,
                        PARENTID = 44,
                        SYSTEMNAME = "SyncJobs",
                        URL = null,
                        URL_ = "Admin/SyncJobs"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Lịch sử người dùng đăng nhập",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 57,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 13,
                        PARENTID = 44,
                        SYSTEMNAME = "UserLoginHistory",
                        URL = null,
                        URL_ = "Admin/UserLoginHistory"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý versions mobile",
                        ICONCLASS = "bi bi-record2-fill",
                        ID = 58,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 14,
                        PARENTID = 44,
                        SYSTEMNAME = "Version",
                        URL = null,
                        URL_ = "Admin/Version"
                    },
                };

            if (menus != null && menus.Count > 0)
            {
                siteMap = menus.GenerateTreeMenu(c => c.ID, c => c.PARENTID, c => c.ORDER_);
            }

            return siteMap;
        }
    }
}
