using System.ComponentModel;

namespace Profile.Domain.Enums
{
    public enum ProfileActivity
    {
        [Description("Отсутствует")]
        None,
        [Description("Активен")]
        Available,
        [Description("Не в сети")]
        Offline,
        [Description("Занят")]
        Busy
    }
}
