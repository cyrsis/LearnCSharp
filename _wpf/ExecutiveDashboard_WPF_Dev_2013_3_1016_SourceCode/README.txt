Telerik Executive Dashboard for WPF

How to use your local service and database (instead of the demos.telerik.com ones):
 - Open the app.config configuration file.
 - Locate the <add key="DataServiceURL_Localhost> tag.
 - Change the url inside of the tag to match the url and port of the web server you're running (ex. localhost:3993).
 - Make sure you append the name of the WCF DataService file to the url - "AWDWDataService.svc" (or your own, if you use something else.
 
Example: 

app.config:
...
	<appSettings>
		<add key="DataServiceURL_DemosTelerikCom" value="http://demos.telerik.com/silverlight/ExecutiveDashboard/AWDWDataService.svc/"></add>
		<add key="DataServiceURL_Localhost" value="http://localhost:12345/AWDWDataService.svc/"></add>
	</appSettings>
...