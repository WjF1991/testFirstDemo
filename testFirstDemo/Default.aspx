<%@ Page Language="C#" Inherits="testFirstDemo.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
        <center>
		    <asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
        <div>
            <asp:DropDownList id="ddl_button1_attr" runat="server"></asp:DropDownList>
        </div>
        </center>
    </form>
</body>
</html>
