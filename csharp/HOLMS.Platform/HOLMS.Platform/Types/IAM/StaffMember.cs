using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.IAM {
    public partial class StaffMember : EntityDTO<StaffMemberIndicator> {
        public StaffMember(StaffMemberIndicator s, string userid, string password,
            string displayName, string emergencyContactPhone, bool isPhoneDisplayable,
            DateTime dateHired, bool isActive,
            DepartmentIndicator dept, string deptName, ContactInformation contact) {
            EntityId = s;
            UserId = userid;

            if (password != null) {
                Password = password;
            }
            
            DisplayName = displayName;
            EmergencyContactPhoneNumber = emergencyContactPhone;
            IsPhoneDataDisplayable = isPhoneDisplayable;
            DateHired = dateHired.ToTS();
            IsActive = isActive;
            Department = dept;
            DepartmentName = deptName;
            ContactInfo = contact;
        }

        public override StaffMemberIndicator GetIndicator() => EntityId;
    }
}
