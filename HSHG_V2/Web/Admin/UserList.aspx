<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="admin_UserList" Title="Untitled Page" %>

<%@ Register Src="LeftSideControl.ascx" TagName="LeftSideControl" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">
    <table width=740 align=center>
        <tr>
            <td style="width: 168px">
                <uc1:LeftSideControl ID="LeftSideControl1" runat="server" />
            </td>
            <td>
                <div>
                    <div style="width: 441px; height: 30px">
                        &nbsp;<asp:Button ID="btnNew" runat="server" CssClass="greenButton" Height="24px"
                             Text="新增" Width="73px" />&nbsp;
                        <asp:Button ID="btnDelete" runat="server" CssClass="greenButton" Height="24px" 
                            Text="删除选中" /></div>
                    <asp:GridView ID="gridMain" runat="server" AutoGenerateColumns="False" CellPadding="3"
                        CellSpacing="1" DataKeyNames="UserId" DataSourceID="ObjectDataSource1" GridLines="None"
                        Width="648px">
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="UserId" DataNavigateUrlFormatString="UserInfo.aspx?id={0}"
                                DataTextField="UserName" HeaderText="用户名" />
                            <asp:BoundField DataField="Email" HeaderText="邮件" SortExpression="Email" />
                            <asp:CheckBoxField DataField="IsMailValidate" HeaderText="邮件认证" SortExpression="IsMailValidate" />
                            <asp:CheckBoxField DataField="IsLocked" HeaderText="锁定" SortExpression="IsLocked" />
                            <asp:BoundField DataField="CreateDate" HeaderText="创建日期" SortExpression="CreateDate" />
                            <asp:BoundField DataField="LastLoginDate" HeaderText="上次登录日期" SortExpression="LastLoginDate" />
                        </Columns>
                        <RowStyle BackColor="WhiteSmoke" />
                        <EmptyDataTemplate>
                            <span style="color: #3333ff">&nbsp;内容为空</span>
                        </EmptyDataTemplate>
                        <HeaderStyle BackColor="WhiteSmoke" HorizontalAlign="Left" />
                    </asp:GridView>
                    <br />
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete"
                        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="FetchAll"
                        TypeName="Bll.SystemManage.UserController" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="UserId" Type="Object" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="UserId" Type="Object" />
                            <asp:Parameter Name="Idx" Type="Int32" />
                            <asp:Parameter Name="UserName" Type="String" />
                            <asp:Parameter Name="Password" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="EmailActiveCode" Type="String" />
                            <asp:Parameter Name="IsMailValidate" Type="Boolean" />
                            <asp:Parameter Name="IsLocked" Type="Boolean" />
                            <asp:Parameter Name="PasswordResetCode" Type="String" />
                            <asp:Parameter Name="CreateDate" Type="DateTime" />
                            <asp:Parameter Name="LastLoginDate" Type="DateTime" />
                            <asp:Parameter Name="LastPasswordChangedDate" Type="DateTime" />
                            <asp:Parameter Name="LastLockedDate" Type="DateTime" />
                            <asp:Parameter Name="Comment" Type="String" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="UserId" Type="Object" />
                            <asp:Parameter Name="UserName" Type="String" />
                            <asp:Parameter Name="Password" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="EmailActiveCode" Type="String" />
                            <asp:Parameter Name="IsMailValidate" Type="Boolean" />
                            <asp:Parameter Name="IsLocked" Type="Boolean" />
                            <asp:Parameter Name="PasswordResetCode" Type="String" />
                            <asp:Parameter Name="CreateDate" Type="DateTime" />
                            <asp:Parameter Name="LastLoginDate" Type="DateTime" />
                            <asp:Parameter Name="LastPasswordChangedDate" Type="DateTime" />
                            <asp:Parameter Name="LastLockedDate" Type="DateTime" />
                            <asp:Parameter Name="Comment" Type="String" />
                        </InsertParameters>
                    </asp:ObjectDataSource>
                    <br />
                    &nbsp;</div>
            </td>
        </tr>
    </table>
</asp:Content>

