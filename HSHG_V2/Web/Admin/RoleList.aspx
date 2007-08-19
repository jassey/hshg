
<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="RoleList.aspx.cs" Inherits="admin_RoleList"  %>

<%@ Register Src="LeftSideControl.ascx" TagName="LeftSideControl" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">

    <div>
        &nbsp;<br />
        <table align="center" style="width: 759px">
            <tr>
                <td rowspan="3" style="width: 158px">
                    &nbsp;<uc1:LeftSideControl id="LeftSideControl1" runat="server"></uc1:LeftSideControl></td>
                <td>
			&nbsp;<asp:Button ID="btnNew" runat="server" Text="新增" Width="73px" OnClick="btnNew_Click" Height="24px" CssClass="greenButton" />&nbsp;
		<asp:Button ID="btnDelete" runat="server" Text="删除选中" Height="24px" OnClick="btnDelete_Click" CssClass="greenButton" />&nbsp;<br />
                    <br />
		<asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" CellPadding="3"
			CellSpacing="1" DataSourceID="ObjectDataSource1" GridLines="None"
			Width="442px" DataKeyNames="RoleId">
			<Columns>
				<asp:TemplateField SortExpression="IsNew">
					<EditItemTemplate>
						<asp:CheckBox ID="CheckBox1" runat="server" />
					</EditItemTemplate>
					<ItemTemplate>
						<asp:CheckBox ID="chkSelect" runat="server" />
					</ItemTemplate>
					<HeaderTemplate>
						<asp:CheckBox ID="chkSelectAll" runat="server" OnCheckedChanged="chkSelectAll_CheckedChanged" AutoPostBack="True" />
					</HeaderTemplate>
					<ItemStyle Width="30px" HorizontalAlign="Center" />
					<HeaderStyle HorizontalAlign="Center" />
				</asp:TemplateField>
				<asp:HyperLinkField DataNavigateUrlFields="RoleId" DataNavigateUrlFormatString="RoleInfo.aspx?id={0}"
					DataTextField="RoleName" HeaderText="角色名">
					<ItemStyle Width="150px" />
				</asp:HyperLinkField>
				<asp:BoundField DataField="Comment" HeaderText="说明" SortExpression="Comment" />
			</Columns>
			<RowStyle BackColor="WhiteSmoke" />
			<HeaderStyle BackColor="WhiteSmoke" HorizontalAlign="Left" />
			<EmptyDataTemplate>
				<span style="color: #3333ff">&nbsp;内容为空</span>
			</EmptyDataTemplate>
		</asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;
		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete"
			InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="FetchAll"
			TypeName="Bll.SystemManage.RoleController" UpdateMethod="Update">
			<DeleteParameters>
				<asp:Parameter Name="RoleId" Type="Object" />
			</DeleteParameters>
			<UpdateParameters>
				<asp:Parameter Name="RoleName" Type="String" />
				<asp:Parameter Name="Comment" Type="String" />
				<asp:Parameter Name="original_RoleId" Type="Object" />
			</UpdateParameters>
			<InsertParameters>
				<asp:Parameter Name="RoleId" Type="Object" />
				<asp:Parameter Name="RoleName" Type="String" />
				<asp:Parameter Name="Comment" Type="String" />
			</InsertParameters>
		</asp:ObjectDataSource>
                </td>
            </tr>
        </table>
        &nbsp;<br />
		&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
