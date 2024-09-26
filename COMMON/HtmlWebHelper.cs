using HtmlAgilityPack;

namespace COMMON;

public class HtmlWebHelper
{
   public static HtmlNode LoadHtml(string path)
   {
      HtmlWeb web = new();
      HtmlDocument htmlDocument = web.Load(path);
      HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode("//title");
      return htmlNode;
   }
}
