using System.ComponentModel;

namespace SCHS.User.Domain.Enums
{
    /// <summary>
    /// Статусы активности пользователя
    /// </summary>
    public enum ActivityStatus
    {
        [Description("Пользователь активен")]
        Available,
        [Description("Не в сети")]
        Offline,
        [Description("Отошёл")]
        AppearAway,
        [Description("Занят")]
        Busy
    }
}
