<%@ Page Language="C#" MasterPageFile="~/Default.master"  EnableEventValidation="false" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Index" Title="“智人慧心”助学网：因为爱所以我们快乐！Head Start Heart Go" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">
<table align=center width = "741">
<tr><td style="width: 196px">
    <span style="color: #666666">2007年1月20日，截至今日</span><br />
    <span style="color: #666666">
                    还有 </span><span class="textNubpink">6</span><span style="color: #666666">
        个学生等待您的捐助！</span></td><td></td></tr>
    <tr>
        <td style="width: 196px; height: 16px">
                <table bgcolor="#b5de62" border="0" cellpadding="0" cellspacing="0" class="text1218"
                    width="180">
                    <form action="member_index.html">
                        <tr>
                            <td colspan="3" style="height: 32px">
                                <img height="32" src="images/login_title.gif" width="180" /></td>
                        </tr>
                        <tr>
                            <td width="8">
                                &nbsp;</td>
                            <td width="38">
                            
                                <nobr />用户名</td>
                            <td width="134">
                                <label>
                                    <asp:TextBox ID="txtUserName" runat="server" Width="100px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                        Display="Dynamic" ErrorMessage="用户名不能为空"></asp:RequiredFieldValidator></label></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                密码</td>
                            <td>
                                <asp:TextBox ID="txtPassword" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                                    Display="Dynamic" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                验证码</td>
                            <td>
                                <a href="#">
                                    <img align="absMiddle" border="0" height="18" src="images/login_certcode.gif" width="63" /></a>
                                <input class="textbox" name="textfield22" size="7" style="width: 51px" /></td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <label>
                                </label>
                            </td>
                            <td>
                                &nbsp;
                                <asp:Button ID="btnLogin" runat="server" CssClass="greenButton" Text="用户登录" OnClick="btnLogin_Click" />
                                <asp:Button ID="Button1" runat="server" CssClass="greenButton" Text="重填" /></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <a class="linknav" href="member_register.aspx">新用户注册</a> | <a class="linknav" href="member_forgetps.html">
                                    忘记密码</a>
                            </td>
                        </tr>
                    </form>
                </table>

</table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
</asp:Content>

