<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Member_RegisterInfo.aspx.cs" Inherits="member_registerinfo" Title="Untitled Page" %>

<%@ Register Assembly="Core" Namespace="Core.DataBind" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="DefaultPlaceHolder" Runat="Server">

<table width="745" align="center">
    <tr>
    <td style="width: 158px"></td>
    <td class="tdLight">
        您的位置：首页 &gt; 新会员注册
    </td>
    </tr>
        <tr>
            <td style="width: 158px; height: 24px;">
            </td>
            <td style="height: 24px" class="tdLight">
                <img align="absMiddle"  src="images/index_col_front_g.gif" width="18" />
                新会员注册<br />
            </td>
        </tr>
    <tr>
        <td style="width: 158px">
        </td>
        <td style="text-align: center">
            <p class="text12grey" style="text-align: left">一段介绍性文字：我们也会安排捐助人之间的交流活动，以及捐助人与小孩子之间的互动。我们的目标是想让我们彼此更加了解，更加默契，让关爱在我们身边，我们的山区更加绽放光彩。</p>
        </td>
    </tr>
        <tr>
            <td style="width: 158px">
            </td>
            <td style="text-align: center">
               <p align="center" class="articleTitle"> 
                   <br />
                   会员注册信息填写<br />
               </p></td>
        </tr>
        <tr>
            <td style="width: 158px; height: 16px">
            </td>
            <td style="height: 16px">
                <table bgcolor="#ffffff" border="0" cellpadding="4" cellspacing="1" width="560">
                    <tr>
                        <td class="tdLight" valign="top" width="81">
                            <b><span class="text12pink" style="color: #ec008c">*</span> 用户名</b></td>
                        <td class="tdLight" width="460">
                            <label>
                           
                                <class name="textfield4" />
                                <asp:TextBox ID="用户名" runat="server"></asp:TextBox><br />
                                由4-20个以字母开头的字母或数字(a-z，0-9，A-Z)或中文组成</label></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            <b><span class="text12pink" style="color: #ec008c">*</span> 密码</b></td>
                        <td class="tdLight">
                            <asp:TextBox ID="密码" runat="server" TextMode="Password"></asp:TextBox><br />
                            为了现好地保护层您的密码，密码长度必须超过6个字符<br />
                            区分大小写。 请不要使用任何类似 '*'、' ' 或 HTML 字符</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            <b><span class="text12pink" style="color: #ec008c">*</span> 密码确认</b></td>
                        <td class="tdLight">
                            <asp:TextBox ID="密码确认" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="密码"
                                ControlToValidate="密码确认" Display="Dynamic" ErrorMessage="两次输入的密码必须相同"></asp:CompareValidator><br />
                            请再输入一次密码</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            <b><span class="text12pink" style="color: #ec008c">*</span> 电子邮件</b></td>
                        <td class="tdLight">
                            <asp:TextBox ID="电子邮件" runat="server" Width="250px"></asp:TextBox><br />
                            我们会向您的邮箱发送注册激活信息</td>
                    </tr>
                    <tr>
                        <td class="tdLightDash" valign="top">
                            &nbsp;</td>
                        <td class="tdLightDash">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            &nbsp;</td>
                        <td class="tdLight">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            姓名</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                            请您填写真实的信息，以便参加助学活动的联络</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            性别</td>
                        <td class="tdLight">
                            <input name="radiobutton" type="radio" value="radiobutton" />
                            女生
                            <input name="radiobutton" type="radio" value="radiobutton" />
                            男生</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            身份证号</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox6" runat="server" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            出生日期</td>
                        <td class="tdLight">
                            <select name="select4">
                                <option selected="selected">2006</option>
                                <option>2007</option>
                            </select>
                            年
                            <select name="select5">
                                <option selected="selected">1</option>
                                <option>2</option>
                                <option>3</option>
                            </select>
                            月
                            <select name="select6">
                                <option selected="selected">1</option>
                                <option>23</option>
                            </select>
                            日</td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            所在地区</td>
                        <td class="tdLight">
                            <label>
                                <select name="select3">
                                    <option selected="selected">请选择您所在的地国家</option>
                                    <option>中国</option>
                                    <option>美国</option>
                                    <option>英国</option>
                                </select>
                            </label>
                            <select name="select4">
                                <option selected="selected">请选择省份</option>
                                <option>江西</option>
                                <option>四川</option>
                                <option>陕西</option>
                            </select>
                            <select name="select5">
                                <option selected="selected">请选择城市</option>
                                <option>扬州</option>
                                <option>南京</option>
                                <option>苏州</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            详细地址</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox7" runat="server" Width="367px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            邮编</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            手机</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            所在单位</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox1" runat="server" Width="367px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            单位电话</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            家庭电话</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            MSN</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            主页</td>
                        <td class="tdLight">
                            <asp:TextBox ID="TextBox13" runat="server" Width="367px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            能够为网站提供志愿服务</td>
                        <td class="tdLight">
                            <label>
                                <asp:TextBox ID="TextBox14" runat="server" Height="70px" TextMode="MultiLine" Width="367px"></asp:TextBox></label></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            其他说明</td>
                        <td class="tdLight">
                            <textarea class="textbox" name="textarea" rows="4" style="width: 370px"></textarea></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            公开资料</td>
                        <td class="tdLight">
                            <label>
                                <input name="radiobutton" type="radio" value="radiobutton" />
                                是
                            </label>
                            <label>
                                <input name="radiobutton" type="radio" value="radiobutton" />
                                否<br />
                                如果您选择公开资料，其他会员则可以查看您的所有个人信息</label></td>
                    </tr>
                    <tr>
                        <td class="tdLight" valign="top">
                            验证码</td>
                        <td class="tdLight">
                            <a href="#">
                                <img align="absMiddle" border="0" height="18" src="images/login_certcode.gif" width="63" /></a>
                            <input class="textbox" name="textfield222" size="7" style="width: 51px" /></td>
                    </tr>
                </table>
                <p>
                    注：带有<span class="text12pink">*</span> 的信息必须填写</p>
                <p align="center">
                    <label>
                        <asp:Button ID="btnOk" runat="server"  class="greenButton"  Text="填写好了，请继续 -->" OnClick="btnOk_Click"/>
                      
                    </label>
                    <label>
                        <input class="greenButton" name="Submit6" type="submit" value="清除重写" />
                    </label>
                </p>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 16px">
            </td>
            <td style="height: 16px; text-align: center">
                <cc1:BindManager ID="mgrUser" runat="server" BizObjectType="Model.User">
                    <BindItems>
                        <cc1:BindItem ControlId="用户名" ControlProperty="" FieldName="UserName" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="密码" ControlProperty="" FieldName="Password" Require="True"
                            Validate="" />
                        <cc1:BindItem ControlId="电子邮件" ControlProperty="" FieldName="Email" Require="True"
                            Validate="" />
                    </BindItems>
                </cc1:BindManager>
                &nbsp;</td>
        </tr>
    
    </table>

</asp:Content>

