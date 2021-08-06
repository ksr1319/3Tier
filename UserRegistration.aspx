<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="_3TierAsp.UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
            width: 998px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" style="background-color: Green; color: White;" align="center" class="auto-style2">  
                        User Registration</td>
                
            </tr>
            <tr>  
                    <td> Name </td>  
                    <td>  
           <asp:TextBox ID="txtname" Width="150px" runat="server"></asp:TextBox>  
                    &nbsp;</td>  
                </tr>  
                <tr>  
                    <td>  
                        Address </td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList1" runat="server" >
                            <asp:ListItem>select city</asp:ListItem>
                            <asp:ListItem>srpt</asp:ListItem>
                            <asp:ListItem>hyd</asp:ListItem>
                            <asp:ListItem>krtla</asp:ListItem>
                        </asp:DropDownList>
                    </td>  
                </tr>  
                <tr>  
                    <td> Sex</td>  
             <td>  
                 <asp:RadioButton ID="RadioButton1" runat="server" GroupName="S1" Text="Male" />
                 <asp:RadioButton ID="RadioButton2" runat="server" GroupName="S1" Text="Female" />
             &nbsp;
                 </td>  
                </tr>  
                <tr>  
                    <td> Cource</td>  
                    <td>  
                        <asp:CheckBox ID="CheckBox1" runat="server" Text=".Net" />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Java" />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" />
                    </td>  
                </tr>  
                <tr>  
                    <td> MobileNumber</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>  
                </tr>  
                <tr>  
                    <td align="center" colspan="2">  
         <asp:Button ID="BtnSave" runat="server" Width="100px" Text="Save" OnClick="BtnSave_Click" />  
                    </td>  
                </tr>  
            </table>  
        </div>  
    
   
    </form>
</body>
</html>
