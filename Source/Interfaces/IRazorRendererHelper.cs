namespace PDFDemo.Interfaces
{
    public interface IRazorRendererHelper
    {
        string RenderPartialToString<TModel>(string partialName, TModel model);
    }
}
