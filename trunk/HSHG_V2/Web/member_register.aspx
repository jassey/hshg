<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="member_register.aspx.cs" Inherits="member_register" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">
    
    <table width="745" align="center">
    <tr>
    <td style="width: 158px"></td>
    <td>
        您的位置：首页 &gt; 新会员注册
    </td>
    </tr>
        <tr>
            <td style="width: 158px; height: 24px;">
            </td>
            <td style="height: 24px">
                <img align="absMiddle"  src="images/index_col_front_g.gif" width="18" />
                新会员注册</td>
        </tr>
        <tr>
            <td style="width: 158px">
            </td>
            <td style="text-align: center">
               <p align="center" class="articleTitle"> 会员注册条款</p></td>
        </tr>
        <tr>
            <td style="width: 158px; height: 16px">
            </td>
            <td style="height: 16px">
                很长很长一段文字，由Cherypie来负责完成。<br />
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
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 16px">
            </td>
            <td style="height: 16px; text-align: center">
                &nbsp;<asp:Button ID="btnApply" runat="server" CssClass="greenButton" OnClick="btnApply_Click"
                    Text="我已仔细阅读《会员注册条款》并且同意，请继续" Width="300px" /></td>
        </tr>
    
    </table>
    
</asp:Content>

