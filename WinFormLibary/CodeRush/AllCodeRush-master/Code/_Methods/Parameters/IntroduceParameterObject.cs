using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace AllCodeRush.Code.Methods.Parameters
{
  /* •———————————————————————————————————————————————————————•
      Feature: Introduce Parameter Object
        
      Use Case: Replaces two or more parameters with a single 
      new parameter object, declaring the type and updating all 
      calls in the solution.
         
      Available:  
       - When the selection holds two or more adjacent 
         parameters in a method declaration.
        
      See also: Decompose Parameters, Reorder Parameters
     •———————————————————————————————————————————————————————• */
  public class IntroduceParameterObject
  {
    #region private constants...
    private const string STR_VirtualEarth = "http://dev.virtualearth.net/REST/v1/Locations/US/{0}, {1}, {2} {3}?o=xml&amp;key=BingMapsKey";
    private const string STR_RestSchema = "http://schemas.microsoft.com/search/local/ws/rest/v1";
    private const string STR_RestPrefix = ".//rest:";
    #endregion

    public void Test()
    {
      if (GetLatitudeLongitude("123 S Main Street", "Los Angeles", "CA", "90012-3701") != "(34.051908, -118.243893)")
        throw new Exception("Unexpected results.");
    }

    public static string GetLatitudeLongitude(string street, string city, string stateProvince, string postalCode)
    {
      string clearStreet = Regex.Replace(street, "#", "");
      string mapUri = string.Format(STR_VirtualEarth, clearStreet, city, stateProvince, postalCode);
      XmlDocument mapsXmlDoc = new XmlDocument();
      mapsXmlDoc.Load(mapUri);
      XmlNamespaceManager namespaceManager = new XmlNamespaceManager(mapsXmlDoc.NameTable);
      namespaceManager.AddNamespace("rest", STR_RestSchema);
      XmlElement document = mapsXmlDoc.DocumentElement;
      string longitude = GetCoordinate(document, namespaceManager, "Longitude");
      string latitude = GetCoordinate(document, namespaceManager, "Latitude");
      return string.Format("({0}, {1})", latitude, longitude);
    }

    private static string GetCoordinate(XmlElement document, XmlNamespaceManager namespaceManager, string coordinate)
    {
      return document.SelectSingleNode(STR_RestPrefix + coordinate, namespaceManager).InnerText;
    }
  }
}
