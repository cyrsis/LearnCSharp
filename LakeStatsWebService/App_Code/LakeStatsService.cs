using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using DataManager;

[WebService(Namespace = "http://example.com/lakependoreillelakestats")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class LakeStatsService : System.Web.Services.WebService
{

    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]

    public void GetLakeStats(string start, string end)
    {

        FeedManager mgr = new FeedManager();

        //Set default date values
        if (start.Length == 0)
        {
            start = "2014-01-01";
        }
        if (end.Length == 0)
        {
            end = "2014-01-03";
        }

        DateTime startDate;
        DateTime endDate;
        try
        {
            //Parse dates into DateTime values
            startDate = DateTime.Parse(start);
            endDate = DateTime.Parse(end);

            //Get data from the cached web service responses
            Dictionary<String, FeedResult> returnData = new Dictionary<string, FeedResult>();
            FeedResult windResult = mgr.GetData(startDate, endDate, FeedManager.WIND_SPEED);
            returnData.Add("windSpeed", windResult);
            FeedResult tempResult = mgr.GetData(startDate, endDate, FeedManager.AIR_TEMP);
            returnData.Add("airTemperature", tempResult);
            FeedResult baroResult = mgr.GetData(startDate, endDate, FeedManager.BARO_PRESSURE);
            returnData.Add("barometricPressure", baroResult);

            //Serialize the results as JSON and return to client
            var json = new JavaScriptSerializer().Serialize(returnData);
            Context.Response.Write(json);
        }
        catch (Exception ex)
        {
            string exJson = GetExceptionAsJson(ex);
            Context.Response.Write(exJson);
            return; 
        }

    }

    private string GetExceptionAsJson(Exception ex)
    {
        Dictionary<String, String> exDict = new Dictionary<string,string>();
        exDict.Add("Error", ex.Message);
        return new JavaScriptSerializer().Serialize(exDict);
    }
}
