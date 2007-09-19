<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftSideControl.ascx.cs" Inherits="admin_LeftSideControl" %>
<p>
    欢迎您：<asp:Label ID="lblUserName" runat="server" Width="107px"></asp:Label><br />
    上次登录时间：<asp:Label ID="lblLastLoginDate" runat="server" Width="84px"></asp:Label><span style="color: #88b927"> 
            <br />
        </span>
    <span style="color: #88b927">
        <img height="23" src="../Images/left_line.gif" width="150" /></span>&nbsp;<br />
    <span class="text12titleGreen" contenteditable="true"
        style="color: #88b927">我的控制面板</span><span style="color: #88b927">&nbsp; </span>
    <table bgcolor="#f5f5f5" border="0" cellpadding="2" cellspacing="0" style="color: #88b927"
        width="140">
        <tr>
            <td align="right" width="22">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td width="150">
                <a href="member_myinfo.html"><span style="color: #88b927">我的个人信息</span></a></td>
        </tr>
        <tr style="color: #88b927; text-decoration: underline">
            <td align="right">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/RoleList.aspx">角色管理</asp:HyperLink></td>
        </tr>
        <tr style="color: #88b927; text-decoration: underline">
            <td align="right">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/UserInfo.aspx">用户管理</asp:HyperLink><a href="../../Admin/UserInfo.aspx"></a></td>
        </tr>
        <tr style="color: #88b927; text-decoration: underline">
            <td align="right">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td>
                认捐管理</td>
        </tr>
        <tr style="color: #88b927; text-decoration: underline">
            <td align="right">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td>
                社区活动管理</td>
        </tr>
        <tr style="color: #88b927; text-decoration: underline">
            <td align="right">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td>
                捐款管理</td>
        </tr>
        <tr style="color: #88b927; text-decoration: underline">
            <td align="right">
                <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
            <td>
                退出登录</td>
        </tr>
    </table>
</p>
<p>
    <img height="23" src="../Images/left_line.gif" style="color: #0000ff; text-decoration: underline"
        width="150" />
</p>
