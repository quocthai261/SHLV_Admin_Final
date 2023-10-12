using AdminWeb.Dtos.ApiResponse;
using Microsoft.CodeAnalysis;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace AdminWeb.Models
{
    public class CriteriaTypeDto
    {
        public int ID { set; get; }

        public string NAME { set; get; }
    }   

    public class UserDetailViewModel
    {
        public SysUsersModel User { get; set; }

        public long[] RoleIDs { get; set; }

        public long[] PermissionIds { get; set; }
    }

    public class UpdateUserRequestModel
    {
        public long UserId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public long[] addRoleIds { get; set; }

        public long[] deleteRoleIds { get; set; }
        public long[] permissionIds { get; set; }
        public long[] roleIds { get; set; }
    }


    public class LST_CRITERIASDto
    {
        #region -- Properties --

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID.</value>
        [DataMember]
        public long ID { get; set; }

        /// <summary>
        /// Gets or sets the CRITERIACONTENT.
        /// </summary>
        /// <value>The CRITERIACONTENT.</value>
        [StringLength(256)]
        [DataMember]
        public string CRITERIACONTENT { get; set; }

        /// <summary>
        /// Gets or sets the CRITERIATYPE.
        /// </summary>
        /// <value>The CRITERIATYPE.</value>
        [DataMember]
        public int? CRITERIATYPE { get; set; }

        /// <summary>
        /// Gets or sets the ISACTIVE.
        /// </summary>
        /// <value>The ISACTIVE.</value>
        [DataMember]
        public bool? ISACTIVE { get; set; }

        /// <summary>
		/// Gets or sets the CRITERIACODE.
		/// </summary>
		/// <value>The CRITERIACODE.</value>
		[StringLength(50)]
        [DataMember]
        public string CRITERIACODE { get; set; }

        /// <summary>
		/// Gets or sets the ICON.
		/// </summary>
		/// <value>The ICON.</value>
		[StringLength(256)]
        [DataMember]
        public string ICON { get; set; }

        #endregion
    }

    public class LST_ANSWERSDto
    {
        #region -- Properties --

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID.</value>
        [DataMember]
        public long ID { get; set; }

        /// <summary>
        /// Gets or sets the CRITERIAID.
        /// </summary>
        /// <value>The CRITERIAID.</value>
        [DataMember]
        public long? CRITERIAID { get; set; }

        /// <summary>
        /// Gets or sets the ANSWERCONTENT.
        /// </summary>
        /// <value>The ANSWERCONTENT.</value>
        [StringLength(256)]
        [DataMember]
        public string ANSWERCONTENT { get; set; }

        /// <summary>
		/// Gets or sets the INDEX_.
		/// </summary>
		/// <value>The INDEX_.</value>
		[DataMember]
        public int? INDEX_ { get; set; }

        /// <summary>
		/// Gets or sets the ANSWERCODE.
		/// </summary>
		/// <value>The ANSWERCODE.</value>
		[StringLength(50)]
        [DataMember]
        public string ANSWERCODE { get; set; }

        #endregion
    }
}
