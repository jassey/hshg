using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.Design;
using System.ComponentModel.Design;

using System.Collections.ObjectModel;

using System.Collections;
using System.Drawing.Design;
using System.Reflection;

using Spring.DataBinding;
using Hshg.Core.DataBind.Validate;

namespace Hshg.Core.DataBind
{
	[ParseChildren(true, "BindItems")]
	[PersistChildren(false)]
	[Designer(typeof(MyComponmentDesigner))]
	public class BindManager : Control 
	{
		private bool _IsDesignModel = (HttpContext.Current == null);

		private string _BizObjectType;
		private List<BindItem> _BindItems;
		public static IList BizObjectProperties = new List<string>();


		[PersistenceMode(PersistenceMode.InnerProperty)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] 
		public List<BindItem> BindItems
		{
			get
			{
				if (this._IsDesignModel)
				{
					LoadBizObjectProperties();
				}

				if (this._BindItems == null)
				{
					_BindItems = new List<BindItem>();
				}
				return this._BindItems;
			}
		}

		public string BizObjectType
		{
			get { return _BizObjectType; }
			set
			{
				_BizObjectType = value;

				if (string.IsNullOrEmpty(value))
				{
					BindManager.BizObjectProperties.Clear();
				}
			}
		}

		public void AutoLoadFormItems(ICollection ControlList)
		{
			foreach (object s in ControlList)
			{
				bool exists = false;
				foreach (BindItem item in this.BindItems)
				{
					if (item.ControlId == (string)s)
					{
						exists = true;
						break;
					}
				}

				if (!exists)
				{
					BindItem bind = new BindItem();
					bind.ControlId = (string)s;
					this.BindItems.Add(bind);
				}
			}
		}

		private void LoadBizObjectProperties()
		{
			if (string.IsNullOrEmpty(_BizObjectType))
			{
				BindManager.BizObjectProperties.Clear();
				return;
			}

			Type type = Type.GetType(_BizObjectType);
			if (type != null)
			{
				BindManager.BizObjectProperties.Clear();
				PropertyInfo[] infos = type.GetProperties();
				foreach (PropertyInfo item in infos)
				{
					BindManager.BizObjectProperties.Add(item.Name);
				}
			}
		}

		private Control GetDefaultContainer()
		{
			Control result;
			if (this.Page.Master != null)
			{
				result = this.Page.Form.FindControl("DefaultPlaceHolder");
			}
			else
			{
				result = this.Page.Form;
			}
			return result;
		}

		private BaseBindingManager CreateBindingManager()
		{
			BaseBindingManager mgr = new BaseBindingManager();
			foreach (BindItem item in this.BindItems)
			{
				Control container = GetDefaultContainer();

				Control control = container.FindControl(item.ControlId);
				if (control == null)
				{
					continue;
				}

				string dest;
				if (!string.IsNullOrEmpty(item.ControlProperty))
				{
					dest = item.ControlId + "." + item.ControlProperty;
				}
				else
				{
					dest = GetControlValueExpression(control);
				}

				mgr.AddBinding(item.FieldName, dest, null);
			}
			return mgr;
		}

		public void LoadValidate(Type bizObjectType)
		{
			Control container = GetDefaultContainer();

			foreach (BindItem item in this.BindItems)
			{
				Control control = container.FindControl(item.ControlId);
				if (control == null)
				{
					continue;
				}
				ValidateHelper.Bind(container, bizObjectType, item.FieldName, item.ControlId, item.Require, item.Validate);
			}
		}

		public void BizObjectToPage(object bizObject)
		{
			CreateBindingManager().BindSourceToTarget(bizObject, this.Page, null);
		}

		public void PageToBizObject(object bizObject)
		{
			CreateBindingManager().BindTargetToSource(bizObject, this.Page, null);
		}

		/// <summary>
		/// 获得控件的数据属性字符串
		/// </summary>
		private string GetControlValueExpression(Control control)
		{
			string exp = "";

			if (control is Label) exp = "Text";
			if (control is TextBox) exp = "Text";
			if (control is CheckBox) exp = "Checked";
			if (control is DropDownList) exp = "SelectedValue";
			if (control is RadioButtonList) exp = "SelectedValue";
			if (control is HiddenField) exp = "Value";

			if (exp.Length == 0)
				throw new Exception("未映射的控件类型!");
			else
				return control.ID + "." + exp;
		}
	}

	public class BindItem
	{
		string _FieldName = "";
		string _ControlProperty = "";
		bool _Require;
		string _Validate = "";

		string _ControlId = "";

		[IDReferenceProperty, TypeConverter(typeof(ControlIDConverter))]
		public string ControlId
		{
			get { return _ControlId; }
			set { _ControlId = value; }
		}

		[TypeConverter(typeof(BizObjctPropertyConverter))]
		public string FieldName
		{
			get { return _FieldName; }
			set { _FieldName = value; }
		}

		public string ControlProperty
		{
			get { return _ControlProperty; }
			set { _ControlProperty = value; }
		}

		public bool Require
		{
			get { return _Require; }
			set { _Require = value; }
		}

		public string Validate
		{
			get { return _Validate; }
			set { _Validate = value; }
		}

		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this.ControlId))
			{
				string result = ControlId;
				if (string.IsNullOrEmpty(this.FieldName))
				{
					result += "*";
				}
				return result;
			}
			else
			{
				return base.ToString();
			}
		}
	}

	public class BizObjctPropertyConverter : StringConverter
	{

		// 返回此对象是否支持可以从列表中选取的标准值集
		public override bool GetStandardValuesSupported(
						   ITypeDescriptorContext context)
		{
			return true;
		}

		// 返回下拉框集合类
		public override StandardValuesCollection
					  GetStandardValues(ITypeDescriptorContext context)
		{
			return new StandardValuesCollection(BindManager.BizObjectProperties);
		}

		// 标准值的集合是否为独占列表
		// 默认为flase,为true则表示无法修改列表值
		public override bool GetStandardValuesExclusive(
							ITypeDescriptorContext context)
		{
			return false;
		}
	}

}
