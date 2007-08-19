<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="member_index.aspx.cs" Inherits="Member_member_index" Title="“智人慧心”助学网：因为爱，所以我们快乐！" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">


    <table style="width: 759px" align=center>
        <tr>
            <td style="width: 190px">
                <p>
                    欢迎您：<asp:Label ID="lblUserName" runat="server" Text="Label" Width="107px"></asp:Label><br />
                    上次登录时间：<asp:Label ID="lblLastLoginDate" runat="server" Text="Label" Width="84px"></asp:Label>
                    <img height="23" src="../Images/left_line.gif" width="180" /></p>
                <span class="text12titleGreen" contenteditable="true" style="color: #000000">我的控制面板</span>&nbsp;
                <table bgcolor="#f5f5f5" border="0" cellpadding="2" cellspacing="0" width="180">
                    <tr>
                        <td align="right" width="22">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td width="150">
                            <a href="member_myinfo.html">
                                我的个人信息</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <a href="member_mystudents.html">我资助的学生</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <a href="member_mypenpal.html">我的山区笔友</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <a href="member_myteacher.html">我的山区教师</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <a href="member_myevent.html">我参加的社区活动</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <a href="member_mydonatation.html">我的捐款记录</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <a href="member_mymessage.html">我的留言箱</a></td>
                    </tr>
                    <tr style="color: #0000ff; text-decoration: underline">
                        <td align="right">
                            <img height="9" src="../images/icon_dot_04.gif" width="10" /></td>
                        <td>
                            <asp:LinkButton ID="btnLoginOut" runat="server" OnClick="btnLoginOut_Click">退出登录</asp:LinkButton></td>
                    </tr>
                </table>
                <p>
                    <img height="23" src="../Images/left_line.gif" style="color: #0000ff; text-decoration: underline"
                        width="180" />
                </p>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 190px" >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td style="width: 190px">
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

