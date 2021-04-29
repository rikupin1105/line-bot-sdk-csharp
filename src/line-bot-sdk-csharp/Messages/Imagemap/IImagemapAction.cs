namespace LineMessagingAPI
{
    public interface IImagemapAction
    {
        ImagemapActionType Type { get; }
        ImagemapArea Area { get; }
    }    
}
