using AdminWeb.Dtos.ApiResponse;

namespace AdminWeb.Models
{
    static class SampleData
    {
        public static List<CriteriaTypeDto> CriteriaTypes = new List<CriteriaTypeDto>()
        {
            new CriteriaTypeDto {
                        ID = 1,
                        NAME = "Chọn",
                    },
                    new CriteriaTypeDto {
                        ID = 2,
                        NAME = "Chọn nhiều",
                    },
                    new CriteriaTypeDto {
                        ID = 3,
                        NAME = "Nhập nội dung",
                    }
        };

        public static List<LST_ANSWERSDto> answers = new List<LST_ANSWERSDto>()
        {
            new LST_ANSWERSDto
            {
                ID = 1,
                CRITERIAID = 1,
                ANSWERCONTENT = "Gặp mặt trực tiếp",
                INDEX_ = 1,
                ANSWERCODE = "1"
            },
            new LST_ANSWERSDto
            {
                ID = 2,
                CRITERIAID = 1,
                ANSWERCONTENT = "Gọi thoại và hình (video call) qua ứng dụng Zalo, Viber, Messenger…",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 3,
                CRITERIAID = 4,
                ANSWERCONTENT = "Tôi sẽ chịu trách nhiệm với Công ty nếu có bất cứ thông tin, hồ sơ, hình ảnh nào của ứng viên được kê khai, cung cấp không trung thực.",
                INDEX_ = 1,
                ANSWERCODE = "1"
            },
            new LST_ANSWERSDto
            {
                ID = 4,
                CRITERIAID = 4,
                ANSWERCONTENT = "Tôi cam kết đã thực hiện đầy đủ và trung thực quá trình phỏng vấn ứng viên theo đúng trách nhiệm và nghĩa vụ được giao.",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 5,
                CRITERIAID = 3,
                ANSWERCONTENT = "Gia đình",
                INDEX_ = 1,
                ANSWERCODE = "1"
            },
            new LST_ANSWERSDto
            {
                ID = 6,
                CRITERIAID = 3,
                ANSWERCONTENT = "Bạn bè",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 7,
                CRITERIAID = 3,
                ANSWERCONTENT = "Không",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 8,
                CRITERIAID = 8,
                ANSWERCONTENT = "Thu nhập cao",
                INDEX_ = 1,
                ANSWERCODE = "1"
            },
            new LST_ANSWERSDto
            {
                ID = 9,
                CRITERIAID = 8,
                ANSWERCONTENT = "Du lịch",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 10,
                CRITERIAID = 8,
                ANSWERCONTENT = "Mở rộng mối quan hệ",
                INDEX_ = 3,
                ANSWERCODE = "3"
            },
            new LST_ANSWERSDto
            {
                ID = 11,
                CRITERIAID = 8,
                ANSWERCONTENT = "Thăng tiến",
                INDEX_ = 4,
                ANSWERCODE = "4"
            },
            new LST_ANSWERSDto
            {
                ID = 12,
                CRITERIAID = 8,
                ANSWERCONTENT = "Phát triển bản thân",
                INDEX_ = 5,
                ANSWERCODE = "5"
            },
            new LST_ANSWERSDto
            {
                ID = 13,
                CRITERIAID = 9,
                ANSWERCONTENT = "Người thân",
                INDEX_ = 1,
                ANSWERCODE = "1"
            },
            new LST_ANSWERSDto
            {
                ID = 14,
                CRITERIAID = 9,
                ANSWERCONTENT = "Bạn bè",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 15,
                CRITERIAID = 9,
                ANSWERCONTENT = "Hội thảo tuyển dụng (COP)",
                INDEX_ = 3,
                ANSWERCODE = "3"
            },
            new LST_ANSWERSDto
            {
                ID = 16,
                CRITERIAID = 9,
                ANSWERCONTENT = "Khác",
                INDEX_ = 4,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 17,
                CRITERIAID = null,
                ANSWERCONTENT = "Du lịch",
                INDEX_ = 2,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 18,
                CRITERIAID = null,
                ANSWERCONTENT = "Thăng tiến",
                INDEX_ = 4,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 19,
                CRITERIAID = null,
                ANSWERCONTENT = "Thu nhập cao",
                INDEX_ = 1,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 20,
                CRITERIAID = null,
                ANSWERCONTENT = "Mở rộng mối quan hệ",
                INDEX_ = 3,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 21,
                CRITERIAID = null,
                ANSWERCONTENT = "Thăng tiến",
                INDEX_ = 5,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 22,
                CRITERIAID = null,
                ANSWERCONTENT = "Khác",
                INDEX_ = 6,
                ANSWERCODE = null
            },
            new LST_ANSWERSDto
            {
                ID = 23,
                CRITERIAID = 6,
                ANSWERCONTENT = "Không",
                INDEX_ = 2,
                ANSWERCODE = "2"
            },
            new LST_ANSWERSDto
            {
                ID = 24,
                CRITERIAID = 6,
                ANSWERCONTENT = "Có",
                INDEX_ = 1,
                ANSWERCODE = "1"
            },
        };

        public static List<LST_CRITERIASDto> criterias = new List<LST_CRITERIASDto>()
        {
            new LST_CRITERIASDto
            {
                ID = 1,
                CRITERIACONTENT = "Anh/Chị đã phỏng vấn ứng viên bằng hình thức gì?",
                CRITERIATYPE = 1,
                ISACTIVE = true,
                CRITERIACODE = "p_INTERVIEW_METHOD"
            },
            new LST_CRITERIASDto
            {
                ID = 2,
                CRITERIACONTENT = "Đánh giá về ứng viên (UM/DM)",
                CRITERIATYPE = 3,
                ISACTIVE = true,
                CRITERIACODE = "P_EVALUATION_CANDIDATE"
            },
            new LST_CRITERIASDto
            {
                ID = 3,
                CRITERIACONTENT = "Anh/Chị có quan hệ gì với ứng viên?",
                CRITERIATYPE = 1,
                ISACTIVE = true,
                CRITERIACODE = "p_RELATIONSHIP"
            },
            new LST_CRITERIASDto
            {
                ID = 4,
                CRITERIACONTENT = "Cam kết của người quản lý trực tiếp",
                CRITERIATYPE = 1,
                ISACTIVE = true,
                CRITERIACODE = ""
            },
            new LST_CRITERIASDto
            {
                ID = 5,
                CRITERIACONTENT = "Mục tiêu thu nhập cụ thể mà Ứng viên muốn đạt được ở Hanwha Life Việt Nam là bao nhiêu?",
                CRITERIATYPE = 3,
                ISACTIVE = true,
                CRITERIACODE = "p_EXPECT_SALARY_AD"
            },
            new LST_CRITERIASDto
            {
                ID = 6,
                CRITERIACONTENT = "Anh/Chị có thể tham gia đào tạo theo quy định trong thời khoá biểu không?",
                CRITERIATYPE = 1,
                ISACTIVE = true,
                CRITERIACODE = "p_JOIN_TRAINING_AD"
            },
            new LST_CRITERIASDto
            {
                ID = 7,
                CRITERIACONTENT = "Anh/Chị có kế hoạch gì để ứng viên đạt được mục tiêu đó?",
                CRITERIATYPE = 3,
                ISACTIVE = true,
                CRITERIACODE = "p_PLANNING_CONTENT"
            },
            new LST_CRITERIASDto
            {
                ID = 8,
                CRITERIACONTENT = "Mục tiêu của ứng viên trong 3 năm/5 năm sau:",
                CRITERIATYPE = 1,
                ISACTIVE = true,
                CRITERIACODE = "p_PERSONAL_GOAL"
            },
            new LST_CRITERIASDto
            {
                ID = 9,
                CRITERIACONTENT = "Anh/chị tuyển dụng ứng viên dưới hình thức nào?",
                CRITERIATYPE = 1,
                ISACTIVE = true,
                CRITERIACODE = "p_RECRUIMENT_FORM_CONTENT"
            },
            new LST_CRITERIASDto
            {
                ID = 10,
                CRITERIACONTENT = "Công việc đã làm gần đây nhất (hoặc hiện tại) là công việc gì?",
                CRITERIATYPE = 3,
                ISACTIVE = true,
                CRITERIACODE = "p_PRIOR_WORK_AD"
            },
            new LST_CRITERIASDto
            {
                ID = 11,
                CRITERIACONTENT = "Đánh giá về ứng viên (SDM)",
                CRITERIATYPE = 3,
                ISACTIVE = true,
                CRITERIACODE = "p_INTERVIEW_AD"
            }
        };

        public static List<SysUsersModel> users = new List<SysUsersModel>()
        {
            new SysUsersModel
            {
                UserId = 1,
                UserName = "62116622",
                SurName = "62116622",
                Name = "ĐẶNG QUANG DŨNG (Agency)",
                UserType = 2,
                PhoneNumber = "0908764589",
                Email = "dung@gmail.com"
            },
            new SysUsersModel()
                {
                    UserId = 2,
                    UserName = "62123422",
                    SurName = "62123422",
                    Name = "LÊ HẰNG THY (Agency)",
                    UserType = 2,
                    PhoneNumber = "0908763459",
                    Email = "thyhang@gmail.com"
                },
            new SysUsersModel()
                {
                    UserId = 3,
                    UserName = "62123789",
                    SurName = "62123789",
                    Name = "TRẦN MẠNH HUY (Unit Manager)",
                    UserType = 3,
                    PhoneNumber = "0908234459",
                    Email = "manhhuyg@gmail.com"
                },
            new SysUsersModel()
                {
                    UserId = 4,
                    UserName = "61243789",
                    SurName = "61243789",
                    Name = "VŨ THẢO NHUNG (Agency)",
                    UserType = 2,
                    PhoneNumber = "0908234124",
                    Email = "nhungthao@gmail.com"
                },
            new SysUsersModel()
                {
                    UserId = 5,
                    UserName = "admin",
                    SurName = "admin",
                    Name = "NGUYỄN VĂN LONG (Admin)",
                    UserType = 1,
                    PhoneNumber = "0908234890",
                    Email = "longvan@shinhan.com"
                }
        };

        
    }
}


