<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="admin_RoleList" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户管理</title>
	<link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body bgcolor="white">
    <form id="form1" runat="server">
    <div>
		<div style="width: 441px; height: 30px">
			&nbsp;<asp:Button ID="btnNew" runat="server" Text="新增" Width="73px" OnClick="btnNew_Click" Height="24px" CssClass="greenButton" />&nbsp;
		<asp:Button ID="btnDelete" runat="server" Text="删除选中" Height="24px" OnClick="btnDelete_Click" CssClass="greenButton" /></div>
		<asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" CellPadding="3"
			CellSpacing="1" DataSourceID="ObjectDataSource1" Font-Size="Smaller" GridLines="None"
			Width="648px" Font-Names="Verdana,宋体" DataKeyNames="UserId">
			<Columns>
				<asp:HyperLinkField DataNavigateUrlFields="UserId" DataNavigateUrlFormatString="UserInfo.aspx?id={0}"
					DataTextField="UserName" HeaderText="用户名" />
				<asp:BoundField DataField="Email" HeaderText="邮件" SortExpression="Email" />
				<asp:CheckBoxField DataField="IsMailValidate" HeaderText="邮件认证" SortExpression="IsMailValidate" />
				<asp:CheckBoxField DataField="IsLocked" HeaderText="锁定" SortExpression="IsLocked" />
				<asp:BoundField DataField="CreateDate" HeaderText="创建日期" SortExpression="CreateDate" />
				<asp:BoundField DataField="LastLoginDate" HeaderText="上次登录日期" SortExpression="LastLoginDate" />
				<asp:BoundField DataField="Comment" HeaderText="说明" SortExpression="Comment" />
			</Columns>
			<RowStyle BackColor="WhiteSmoke" />
			<HeaderStyle BackColor="WhiteSmoke" HorizontalAlign="Left" />
			<EmptyDataTemplate>
				<span style="color: #3333ff">&nbsp;内容为空</span>
			</EmptyDataTemplate>
		</asp:GridView>
		<br />
		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="FetchAll"
			TypeName="Bll.Systemmanage.UserController">
		</asp:ObjectDataSource>
    <br />
		&nbsp;</div>
    </form>
</body>
</html>
