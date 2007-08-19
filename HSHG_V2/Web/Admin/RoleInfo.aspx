
    
    <%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="RoleInfo.aspx.cs" Inherits="admin_RoleInfo" Title="Untitled Page" %>

<%@ Register Src="LeftSideControl.ascx" TagName="LeftSideControl" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">


    
    
    <div>
        &nbsp;</div>
		<table align=center width=740px>
		<tr><td style="width: 121px; height: 16px">
            <uc1:LeftSideControl ID="LeftSideControl1" runat="server" />
        </td>
		<td style="height: 16px">
		<table style="width: 422px" border="0" cellpadding="4" cellspacing="1">
            <tr>
                <td class="tdLight" style="width: 53px">
                </td>
                <td class="tdLight" style="width: 332px">
                    <asp:Button ID="btnSave" runat="server"  Text="保存" Width="74px" OnClick="btnSave_Click" CssClass="greenButton" Height="22px" />&nbsp;<asp:Button
				ID="btnReturn" runat="server" Text="返回列表" OnClick="btnReturn_Click" CssClass="greenButton" Height="22px" /></td>
            </tr>
			<tr>
				<td style="width: 53px" class="tdLight"><nobr>
					<span style="font-size: 9pt" class="tdLight"><span style="color: #cc0000">*</span>角色名<span
						style="color: #cc0000"></span></span></td>
				<td style="width: 332px" class="tdLight"><nobr>
					<asp:TextBox ID="角色名" runat="server" Width="197px"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="角色名"
						ErrorMessage="不能为空"></asp:RequiredFieldValidator><asp:Label ID="lblInfo" runat="server" Text="Label" Width="141px" ForeColor="Red" Visible="False" Font-Size="9pt"></asp:Label></td>
			</tr>
			<tr>
				<td style="width: 53px" class="tdLight"><nobr>
					<span style="font-size: 9pt">&nbsp;说明</span></td>
				<td style="width: 332px" class="tdLight">
					<asp:TextBox ID="说明" runat="server" Height="100px" Width="275px"></asp:TextBox></td>
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