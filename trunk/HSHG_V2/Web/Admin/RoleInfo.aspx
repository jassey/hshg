﻿
    
    <%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="RoleInfo.aspx.cs" Inherits="admin_RoleInfo" Title="Untitled Page" %>

<%@ Register Src="../Controls/Admin/LeftSideControl.ascx" TagName="LeftSideControl"
    TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">
    
    <div>
        &nbsp;</div>
		<table align=center width=740px>
		<tr><td style="width: 121px; height: 16px">
            &nbsp;<uc1:LeftSideControl ID="LeftSideControl1" runat="server" />
        </td>
		<td style="height: 16px">
		<table style="width: 422px" border="0" cellpadding="4" cellspacing="1">
            <tr>
                <td class="tdLight" style="width: 53px">
                </td>
                <td class="tdLight" style="width: 332px">
                    <asp:Button ID="btnSave" runat="server"  Text="保存" Width="74px" OnClick="btnSave_Click" Height="22px" />&nbsp;<asp:Button
				ID="btnReturn" runat="server" Text="返回列表" OnClick="btnReturn_Click" Height="22px" /></td>
            </tr>
			<tr>
				<td style="width: 53px" class="tdLight"><nobr>
					<span style="font-size: 9pt" class="tdLight"><span style="color: #cc0000">*</span>角色名<span
						style="color: #cc0000"></span></span></td>
				<td style="width: 332px" class="tdLight"><nobr>
					<asp:TextBox ID="角色名" runat="server" Width="197px"></asp:TextBox>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="角色名"
                        ErrorMessage="角色名已存在" Display="Dynamic" OnServerValidate="Validator_RoleName_ServerValidate"></asp:CustomValidator>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="角色名"
						ErrorMessage="不能为空" Display="Dynamic"></asp:RequiredFieldValidator>&nbsp;
                    </td>
			</tr>
			<tr>
				<td style="width: 53px" class="tdLight"><nobr>
					<span style="font-size: 9pt">&nbsp;说明</span></td>
				<td style="width: 332px" class="tdLight">
					<asp:TextBox ID="说明" runat="server" Height="100px" Width="275px" TextMode="MultiLine"></asp:TextBox></td>
			</tr>
		</table>
		</td></tr>
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