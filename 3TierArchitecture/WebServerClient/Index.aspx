<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebServerClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script>
        function callServer() {
            var xmlhttp;
            if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                xmlhttp = new XMLHttpRequest();
            }
            else {// code for IE6, IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    document.getElementById("text01").innerHTML = xmlhttp.responseText;
                }
            }
            xmlhttp.open("GET", "Server/Ships.aspx?action=move&shipId=1&direction=4", true);
            xmlhttp.send();
        }

    </script>

</head>
<body onload="bodyOnLoad()">    
    <div>
        Hello 
    </div>

    <div id="text01">
        World 
    </div>

    <button id="button01" type="button" onclick="callServer()">Click me</button>
    
</body>



</html>
