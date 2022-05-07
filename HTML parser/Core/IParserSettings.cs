using System;

namespace HTML_parser.Core
{
    interface IParserSettings
    {        
        string BaseUrl { get; set; } //Сайт с которого происходит парс  
        string Prefix { get; set; }
        int StartPoint { get; set; } //с какой страницы будет парсинг данных
        int EndPoint { get; set; } //конечный индекс страницы для парсинга
    }
}
