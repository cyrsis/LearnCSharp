<%
For Each var As String in Request.ServerVariables
	Response.Write(var & ": " & Request(var) & "<br>")
Next
%>
