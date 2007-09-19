<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="Admin_UserInfo" Title="Untitled Page" %>

<%@ Register Assembly="Core" Namespace="Hshg.Core.DataBind" TagPrefix="cc1" %>

<%@ Register Src="../Controls/Admin/LeftSideControl.ascx" TagName="LeftSideControl"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">
    <div>
        &nbsp;</div>
    <table align="center" width="740">
        <tr>
            <td style="width: 121px; height: 16px">
                <uc1:LeftSideControl ID="LeftSideControl1" runat="server" />
            </td>
            <td style="height: 16px">
                <table border="0" cellpadding="4" cellspacing="1" style="width: 555px">
                    <tr>
                        <td class="tdLight" style="width: 90px">
                        </td>
                        <td class="tdLight" style="width: 332px">
                            <asp:Button ID="btnSave" runat="server" Height="22px" OnClick="btnSave_Click" Text="保存"
                                Width="74px" />&nbsp;<asp:Button ID="btnReturn" runat="server" Height="22px" OnClick="btnReturn_Click"
                                    Text="返回列表" /></td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            <nobr>
                                <span class="tdLight" style="font-size: 9pt"><span style="color: #cc0000">*</span>用户名<span
                                    style="color: #cc0000"></span></span></nobr></td>
                        <td class="tdLight" style="width: 332px">
                            <nobr>
                                <asp:TextBox ID="用户名" runat="server" Width="180px"></asp:TextBox>
                                &nbsp;&nbsp;
                            </nobr>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            <nobr>
                                <span style="font-size: 9pt">&nbsp;口令</span></nobr></td>
                        <td class="tdLight" style="width: 332px">
                            <asp:TextBox ID="口令" runat="server" Width="180px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            &nbsp;邮箱</td>
                        <td class="tdLight" style="width: 332px">
                            <asp:TextBox ID="邮箱" runat="server" Width="180px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            &nbsp;通过邮箱验证</td>
                        <td class="tdLight" style="width: 332px">
                            <asp:CheckBox ID="通过邮箱认证" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            &nbsp;是否锁定</td>
                        <td class="tdLight" style="width: 332px">
                            <asp:CheckBox ID="是否锁定" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            &nbsp;说明</td>
                        <td class="tdLight" style="width: 332px">
                            <asp:TextBox ID="说明" runat="server" Height="100px" TextMode="MultiLine" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" style="width: 90px">
                            所属角色</td>
                        <td class="tdLight" style="width: 332px">
                            <asp:CheckBoxList ID="chkRoleList" runat="server" Width="253px">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 121px; height: 16px">
            </td>
            <td style="height: 16px">
                <cc1:BindManager ID="BindManager1" runat="server" BizObjectType="Hshg.Bll.SystemManage.User"
                    EnableViewState="False">
                    <BindItems>
                        <cc1:BindItem ControlId="用户名" ControlProperty="" FieldName="UserName" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="口令" ControlProperty="" FieldName="Password" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="邮箱" ControlProperty="" FieldName="Email" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="说明" ControlProperty="" FieldName="Comment" Require="False"
                            Validate="" />
                    </BindItems>
                </cc1:BindManager>
                <cc1:BindManager ID="BindManager2" runat="server" BizObjectType="Hshg.Bll.SystemManage.User"
                    EnableViewState="False">
                    <BindItems>
                        <cc1:BindItem ControlId="用户名" ControlProperty="" FieldName="UserName" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="口令" ControlProperty="" FieldName="Password" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="邮箱" ControlProperty="" FieldName="Email" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="通过邮箱认证" ControlProperty="" FieldName="IsMailValidate" Require="False"
                            Validate="" />
                        <cc1:BindItem ControlId="是否锁定" ControlProperty="" FieldName="IsLocked" Require="False"
                            Validate="" />
                        <cc1:BindItem ControlId="说明" ControlProperty="" FieldName="Comment" Require="False"
                            Validate="" />
                    </BindItems>
                </cc1:BindManager>
            </td>
        </tr>
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
    <br />
    
</asp:Content>

