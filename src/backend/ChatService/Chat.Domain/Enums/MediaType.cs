using System.ComponentModel;

namespace Chat.Domain.Enums
{
    public enum MediaType
    {
        [Description("Голосовое")]
        OnlyVoice,
        [Description("Изображение или фото")]
        Image,
        [Description("Видео")]
        Video
    }
}
