<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Sixeyed.CarValet.Web.Index" %>
<%@ OutputCache CacheProfile="LongLived"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Valet My Motor - 1st Class Car Valeting</title>
    <link href="Content/Main.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
            <div style="float:left">
        <img src="Images/logo_100.png"/>
        </div>
    <div style="margin-left:110px;">
        <h1 class="logo">Valet My Motor</h1>
        <h2>1st Class Car Valeting at Your Home</h2>
    </div>
    <div style="clear:both">
        <hr />
        </div>
        <div id="about" style="float: left; width: 50%">
            <h2>About Us</h2>
            <p>
                Continetur devenietur id ex denegassem ponderibus imaginatio patrocinio. Falso et se re entis quasi im. Ipsum ne opera at potui ipsis mo. Hic advertisse manifestum uti blandisque objectivae imaginaria assignetur. Re dare dari data ad ex isti ad meas quin. Aeque neque at multo coeco ac. Ullius habens longum necdum negans si ut. 
            </p>
            <p>
                Advertisse id ac deveniatur consistere mo voluptatem ad facultates. Ii fide ad jure illa visu inde nudi. Mentibus dedissem pla dum abducere ita duo. Levitatem sae tes eos assentiar cau perfectum venientia imaginari. Hae ego notionibus res sit defectibus desiderant objectivus patrocinio viderentur. Cui motum mei rei qua eodem tangi. Mei perciperem aut ego agnoscitur artificium solutiones cohaereant. Angelos alienum agendam existam to spondeo de. 
            </p>
        </div>
        <div  style="float: left; padding-left: 10px;">
            <div id="getAQuote">
                <a href="Quotes/GetQuotes">Get a Quote Now!</a>
            </div>
                <asp:PlaceHolder ID="cms" runat="server"></asp:PlaceHolder>
        </div>
        <div id="quote">
            
        </div>
    </form>
</body>
</html>
