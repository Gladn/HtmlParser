using AngleSharp.Html.Dom;

namespace HTML_parser.Core
{
    //Обобщенный интерфейс, классы будут возвращать данные любого типа
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
