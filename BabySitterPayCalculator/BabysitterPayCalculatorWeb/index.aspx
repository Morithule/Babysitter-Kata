<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BabysitterPayCalculatorWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Babysitter Pay Calculator</title>
    <link href="css/BabysitterPayCalculator.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="mainContainer">
            <div class="flex-container" >
                <div> Start Time &nbsp;
                    <asp:DropDownList ID="StartTimeList" runat="server" >
                        <asp:ListItem Text="5pm" Value="5"></asp:ListItem>
                        <asp:ListItem Text="6pm" Value="6"></asp:ListItem>
                        <asp:ListItem Text="7pm" Value="7"></asp:ListItem>
                        <asp:ListItem Text="8pm" Value="8"></asp:ListItem>
                        <asp:ListItem Text="9pm" Value="9"></asp:ListItem>
                        <asp:ListItem Text="10pm" Value="10"></asp:ListItem>
                        <asp:ListItem Text="11pm" Value="11"></asp:ListItem>
                        <asp:ListItem Text="12pm" Value="12"></asp:ListItem>
                        <asp:ListItem Text="1am" Value="13"></asp:ListItem>
                        <asp:ListItem Text="2am" Value="14"></asp:ListItem>
                        <asp:ListItem Text="3am" Value="15"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div> End Time &nbsp;
                    <asp:DropDownList ID="EndTimeList" runat="server" >
                        <asp:ListItem Text="6pm" Value="6"></asp:ListItem>
                        <asp:ListItem Text="7pm" Value="7"></asp:ListItem>
                        <asp:ListItem Text="8pm" Value="8"></asp:ListItem>
                        <asp:ListItem Text="9pm" Value="9"></asp:ListItem>
                        <asp:ListItem Text="10pm" Value="10"></asp:ListItem>
                        <asp:ListItem Text="11pm" Value="11"></asp:ListItem>
                        <asp:ListItem Text="12pm" Value="12"></asp:ListItem>
                        <asp:ListItem Text="1am" Value="13"></asp:ListItem>
                        <asp:ListItem Text="2am" Value="14"></asp:ListItem>
                        <asp:ListItem Text="3am" Value="15"></asp:ListItem>
                        <asp:ListItem Text="4am" Value="16"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div> Bed Time &nbsp;
                    <asp:DropDownList ID="BedTimeList" runat="server" >
                        <asp:ListItem Text="6pm" Value="6"></asp:ListItem>
                        <asp:ListItem Text="7pm" Value="7"></asp:ListItem>
                        <asp:ListItem Text="8pm" Value="8"></asp:ListItem>
                        <asp:ListItem Text="9pm" Value="9"></asp:ListItem>
                        <asp:ListItem Text="10pm" Value="10"></asp:ListItem>
                        <asp:ListItem Text="11pm" Value="11"></asp:ListItem>
                        <asp:ListItem Text="12pm" Value="12"></asp:ListItem>
                        <asp:ListItem Text="1am" Value="13"></asp:ListItem>
                        <asp:ListItem Text="2am" Value="14"></asp:ListItem>
                        <asp:ListItem Text="3am" Value="15"></asp:ListItem>
                        <asp:ListItem Text="4am" Value="16"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div style="flex-grow: 2;">
                    <asp:Button ID="SubmitButton" runat="server" Text="Calculate" OnClick="SubmitButton_Click" /> 
                </div>
                
            </div>
            <div class="flex-container">
                <div  id="results" runat="server" > Result </div>
            </div>
            
        </div>
    </form>
</body>
</html>
