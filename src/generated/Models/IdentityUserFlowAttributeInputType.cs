using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum IdentityUserFlowAttributeInputType {
        [EnumMember(Value = "textBox")]
        TextBox,
        [EnumMember(Value = "dateTimeDropdown")]
        DateTimeDropdown,
        [EnumMember(Value = "radioSingleSelect")]
        RadioSingleSelect,
        [EnumMember(Value = "dropdownSingleSelect")]
        DropdownSingleSelect,
        [EnumMember(Value = "emailBox")]
        EmailBox,
        [EnumMember(Value = "checkboxMultiSelect")]
        CheckboxMultiSelect,
    }
}
