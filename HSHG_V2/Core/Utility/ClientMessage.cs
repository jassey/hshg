using System;

namespace Core.Utility
{
	/// <summary>
	/// ClientScript 的摘要说明。
	/// </summary>
	public class ClientMessage
	{
		private ClientMessage()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static string ShowJavaScriptBlock(string text)
		{
			return "<script language=\"javascript\">" + text + "</script>";
		}
		public static string ShowMsgBox(string msg)
		{
            // 允许消息中的转义和格式化字符
            msg = msg.Replace("\n", "\\n");
            msg = msg.Replace("\t", "\\t");
			return ShowJavaScriptBlock("alert(\"" + msg + "\");");
		}

        public static string ShowMsgBox(string msg, bool IsParentPageReload)
        {
            string script = "alert(\"" + msg + "\");";
            if (IsParentPageReload)
            {
                script += "window.top.opener.window.location.reload();";
            }
            return ShowJavaScriptBlock(script);
        }

		public static string ShowMsgBoxAndBack(string msg)
		{
			return ShowJavaScriptBlock("alert(\"" + msg + "\");window.history.back();");
		}

		public static string ShowMsgBoxAndClose(string msg)
		{
			return ShowJavaScriptBlock("alert(\"" + msg + "\");top.window.close();");
		}

        public static string ShowMsgBoxAndClose(string msg, bool IsParentPageReload)
        {
            string script = "alert(\"" + msg + "\");";
            if (IsParentPageReload)
            {
                script += "window.top.opener.window.location.reload();";
            }
            script += "top.window.close();";
            return ShowJavaScriptBlock(script);
        }

		public static string ShowMsgBoxAndGotoUrl(string msg, string url)
		{
			return ShowJavaScriptBlock("alert(\"" + msg + "\");window.location = \"" + url + "\";");
		}

        public static string ShowConfirm(string msg, string trueDoStatement, string falseDoStatement)
        {
            return ShowConfirm(msg, trueDoStatement, falseDoStatement, true);
        }
        public static string ShowConfirm(string msg)
        {
            return String.Format("return confirm(\"{0}\");", msg);
        }
        public static string ShowConfirm(string msg, string trueDoStatement, string falseDoStatement, bool isShowScriptTag)
        {
            string script = "if (confirm(\"{0}\")){{{1}}} else{{{2}}}";
            if (isShowScriptTag)
                return ShowJavaScriptBlock(String.Format(script, msg, trueDoStatement, falseDoStatement));
            return String.Format(script, msg, trueDoStatement, falseDoStatement);
        }   
		public static string GotoUrl(string url)
		{
			return GotoUrl("window", url);
		}

		public static string GotoUrl(string windowHandler, string url)
		{
			return ShowJavaScriptBlock(windowHandler + ".location = \"" + url + "\";");
		}
		public static string FilterHTMLTag(string text)
		{
			string newText = text.Replace("<", "&lt;");
			newText = newText.Replace(">", "&gt;");
			return newText;
		}

		public static string ReloadDocument(string windownHandle)
		{
			string text = windownHandle + ".location = " + windownHandle + ".location.href;";
			return ShowJavaScriptBlock(text);
		}
	}
}
