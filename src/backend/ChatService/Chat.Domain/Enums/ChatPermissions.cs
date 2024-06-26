using System.ComponentModel;

namespace Chat.Domain.Enums
{
    public enum ChatPermissions
    {
        [Description("Чтение сообщений")]
        Read,
        [Description("Отправка сообщений")]
        Write,
        [Description("Изменение сообщений")]
        Update,
        [Description("Удаление сообщений")]
        Delete,
        [Description("Отправка медиа контента")]
        PostMedia,
    }
}
