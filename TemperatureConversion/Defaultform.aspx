<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaultform.aspx.cs" Inherits="TemperatureConversion.Defaultform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Conversion</title>
    <link href="Style.css" rel="stylesheet" />
</head>

<body>
    <h1>Temperature Convertor: </h1>
    <form id="form1" runat="server">
        <div>
            <table >
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server"  ImageUrl="~/images/thermometer.jpg" />
                    </td>
                    <td class="column1">
                       
            <asp:Label ID="lblFrom" runat="server" cssclass="labelfrom" Text="From: "></asp:Label>

            <asp:Label ID="lblTo0" runat="server" cssclass="labelto" Text="To:"></asp:Label><br/>
            <asp:DropDownList ID="ddlFrom" runat="server">
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem>Fahrenheit</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList>

            <asp:DropDownList ID="ddlTo" runat="server">
                <asp:ListItem>Fahrenheit</asp:ListItem>
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList><br/><br />
                          


            <asp:Label ID="LblInputTemp" runat="server"  Text="Input Temperature: "></asp:Label>

            <asp:TextBox ID="txtInputTemp" runat="server" class="text"></asp:TextBox><br/><br/><br/>
                        
            <asp:Label ID="LblOutputTemp" runat="server"  Text="Output Temperature: "></asp:Label>

            <asp:Label ID="lblresult" runat="server"></asp:Label><br/>
            
                        
            <asp:Button ID="btnConvert" runat="server"   Text="Convert"  OnClick="btnConvert_Click" CssClass="buttonconvert"  />

            <asp:Button ID="btnClear" runat="server" CssClass="buttonclear"  Text="Clear"  OnClick="btnClear_Click"
                CausesValidation="False"  />
                    </td>
                    <td class="coulmn2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInputTemp"
                            ErrorMessage="Please enter a value!" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtInputTemp" 
                            ErrorMessage="The value entered has to be a number between -1000 to 1000" CssClass="validator" MaximumValue="1000"
                            MinimumValue="-1000" Type="Double" Display="Dynamic"></asp:RangeValidator> <br /><br /><br />
                        
                    </td>
                    <td class ="column3">
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
