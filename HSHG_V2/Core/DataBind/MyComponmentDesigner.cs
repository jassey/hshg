using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.Design;
//using System.Windows.Forms;
using System.Web.UI.Design;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Collections;
using System.Web.UI;

namespace Hshg.Core.DataBind
{
	class MyComponmentDesigner : ControlDesigner
	{
		private DesignerVerbCollection _Verbs;

		public override DesignerVerbCollection Verbs
		{
			get
			{
				if (_Verbs == null)
				{
					_Verbs = new DesignerVerbCollection();
					_Verbs.Add(new DesignerVerb("添加页面控件到BindManager", new EventHandler(this.OnTest)));
				}
				return _Verbs;
			}
		}

		protected bool FilterControl(Control control)
		{
			if (
					control is Label ||
					control is TextBox ||
					control is CheckBox ||
					control is DropDownList ||
					control is RadioButtonList ||
					control is HiddenField
			   )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void OnTest(object sender, EventArgs e)
		{

			IContainer container = null;

			if ((this.Component != null) && (Component.Site != null))
			{
				container = Component.Site.Container;
			}

			if (container == null)
			{
				return;
			}

			ComponentCollection components = container.Components;
			ArrayList list = new ArrayList();
			foreach (IComponent item in components)
			{
				System.Web.UI.Control control = item as System.Web.UI.Control;
				if ((control != null) && 
					(control != this.Component) && 
					(control.ID != null) &&
					(control.ID.Length > 0) &&
					(FilterControl(control) == true)
					)
				{
					list.Add(control.ID);
				}
			}

			list.Sort(Comparer.Default);

			if (list.Count > 0)
			{
				BindManager mgr = this.Component as BindManager;
				mgr.AutoLoadFormItems(list);
				//System.Windows.Forms.MessageBox.Show("OK");
			}

		}
	}
}
