<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="Controls_LoginControl" %>

    <link href="~/Css/elfself.css" rel="stylesheet" type="text/css" />

<table bgcolor="#b5de62" border="0" cellpadding="0" cellspacing="0" class="text1218"
	width="180">
        <tr>
          <td colspan="3"><img src="~/images/login_title.gif" width="180" height="32" /></td>
        </tr>
        <tr>
          <td width="8">&nbsp;</td>
          <td width="38">用户名</td>
          <td width="134"><label>
            <input name="textfield" type="text" class="textbox" size="18"  style="width:120px" />
          </label></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>密码</td>
          <td><input name="textfield2" type="password" class="textbox" size="18" style="width:120px" /></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>验证码</td>
          <td><a href="#"><img src="images/login_certcode.gif" width="63" height="18" border="0" align="absmiddle" /></a> 
            <input name="textfield22" type="text" class="textbox" size="7" style="width:51px" /></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td><label>
</label></td>
          <td><input name="Submit" type="submit" class="greenButton" value="登录" style="width:50px" />
            <input name="Submit2" type="reset" class="greenButton" value="重填" style="width:50px" /></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td><a href="member_register.html" class="linknav">新用户注册</a> | <a href="member_forgetps.html" class="linknav">忘记密码</a> </td>
        </tr>
</table>
