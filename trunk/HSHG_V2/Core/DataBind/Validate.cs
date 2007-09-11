/*
 *   Author: jiyang
 *	 DateTime: 2007年4月24日
 */

using System;
using System.Data;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using Hshg.Core.Utility;

namespace Hshg.Core.DataBind.Validate
{
    /// <summary>
    /// 数据校验相关异常
    /// </summary>
    [Serializable]
    public class ValidateException : Exception
    {
        public ValidateException(string message):base(message)
        {
        }
    }
    
    /// <summary>
    /// 数据校验辅助类
    /// </summary>
    public class ValidateHelper
    {
        // 是否需要校验
        private static bool NeedBind(ValidateInfo info)
        {

            return info.DataType == ValidationDataType.Date 
                || info.DataType == ValidationDataType.Integer
                || info.DataType == ValidationDataType.Double
                || info.Require == true 
                || !String.IsNullOrEmpty(info.Expression);
        }

		 // 是否为支持的控件类型
		 // 标准的校验控件只支持以下类型：
		 //    DropDownList 
		 //    FileUpload 
		 //    ListBox 
		 //    RadioButtonList 
		 //    TextBox 
        private static bool IsSupportControlType(Type type)
        {
            Type[] supportTypes = new Type[]{
                typeof(DropDownList),
                typeof(FileUpload), 
                typeof(ListBox),
                typeof(RadioButtonList),
                typeof(TextBox)};

            foreach (Type item in supportTypes)
            {
                if (type == item)
                {
                    return true;
                }
            }
            return false;
        }

		// 根据控件名，返回控件类型
        private static Type GetControlType(Control form, string name)
        {
            Control c = null;
            c = form.FindControl(name);
            if (c != null)
                return c.GetType();
            else
                return null;
        }
       
       	/// <summary>
		/// 绑定校验
		/// </summary>
        public static void Bind(Control form, Type bizzObjectType, string fieldName, string controlID, bool require, string expression)
        {
            if (bizzObjectType == null)
                throw new ArgumentException("bizzObjectType");
                
            ValidateInfo info = new ValidateInfo(controlID, require, expression,
                                  ValidateConvert.ValueTypeToValidationDataType(bizzObjectType, fieldName));
            if (NeedBind(info) && IsSupportControlType(GetControlType(form, info.ControlName)))
            {
                ValidatorFactory factory = new ValidatorFactory(info, form);
                ValidatorParser.Parse(info, factory);
            }
        }
    }

    /// <summary>
    /// 校验信息
    /// </summary>
    [Serializable]
    public class ValidateInfo
    {
        public string ControlName;
        public ValidationDataType DataType;
        public string ErrorMessage;
        public bool Require;
        public string Expression;

        public ValidateInfo()
        {
            this.Require = false;
            this.DataType = ValidationDataType.String;
        }

        public ValidateInfo(string controlName, bool require, string expression, ValidationDataType dataType)
        {
            this.ControlName = controlName;
            this.DataType = dataType;
            this.Require = require;
            this.Expression = expression;
        }
    }

    /// <summary>
    /// 范围类型校验器选项
    /// </summary>
    public struct RangeOption
    {
        public string Min;
        public string Max;
        public RangeOption(string min, string max)
        {
            this.Min = min;
            this.Max = max;
        }
    }

    /// <summary>
    /// 比较类型校验器选项
    /// </summary>
    public struct CompareOption
    {
        public ValidationCompareOperator Operator;
        public string ValueToCompare;

        public CompareOption(ValidationCompareOperator op, string valueToCompare)
        {
            this.Operator = op;
            this.ValueToCompare = valueToCompare;
        }
    }

    public class RegexValidateOption
    {
        protected  string regex;
        protected  string message;

        public virtual string Regex
        {
            get { return regex; }
			set { regex = value; }
        }

        public virtual string Message
        {
            get { return message; }
			set { message = value; }
        }
    }

    public class IntTypeRegexValidateOption : RegexValidateOption
    {
        public IntTypeRegexValidateOption()
        {
            // 允许正负号，数字为0或不以0开始的整数
            this.regex = @"^(?:\+|-)?(0|[1-9][0-9]*)$";
            this.message = "错误的整数类型";
        }
    }

    public class DoubleTypeRegexValidateOption : RegexValidateOption
    {
        public DoubleTypeRegexValidateOption()
        {
            // 允许正负号，整数或小数形式
            // 匹配: +12, -12, 0.12, 12.55 这样的形式
            this.regex = @"^(?:\+|-)?(0|[1-9][0-9]*)(?:\.\d+)?$"; 
            this.message = "错误的小数类型";
        }
    }

    /// <summary>
    /// 数据校验操作的辅助类
    /// </summary>
    sealed public class ValidateConvert
    {
        private ValidateConvert() {} 

        // 获取比较操作的中文说明
        public static string GetDescription(ValidationCompareOperator oper)
        {
            switch (oper)
            {
                case ValidationCompareOperator.DataTypeCheck:
                    return "日期类型检查";
                case ValidationCompareOperator.Equal:
                    return "等于";
                case ValidationCompareOperator.NotEqual:
                    return "不等于";
                case ValidationCompareOperator.GreaterThan:
                    return "大于";
                case ValidationCompareOperator.GreaterThanEqual:
                    return "大于等于";
                case ValidationCompareOperator.LessThan:
                    return "小于";
                case ValidationCompareOperator.LessThanEqual:
                    return "小于等于";
                default:
                    throw new ValidateException("错误的比较类型!");
            }
        }

        // 操作符与比较操作符类型之间的对应关系
        public static ValidationCompareOperator GetCompareOperatorByExpression(string expression)
        {
            switch (expression)
            {
                case "=":
                    return ValidationCompareOperator.Equal;
                case "<>":
                    return ValidationCompareOperator.NotEqual;
                case ">":
                    return ValidationCompareOperator.GreaterThan;
                case ">=":
                    return ValidationCompareOperator.GreaterThanEqual;
                case "<":
                    return ValidationCompareOperator.LessThan;
                case "<=":
                    return ValidationCompareOperator.LessThanEqual;
                default:
                    throw new ValidateException(string.Format("错误的操作符:{0}!", expression));
            }
        }

        // 表达式是否是允许的操作符类型
        public static bool IsAllowedCompareExpression(string expression)
        {
            switch (expression)
            {
                case "=":
                case "<>":
                case ">":
                case ">=":
                case "<":
                case "<=":
                    return true;
                default:
                    return false;
            }
        }

        // .net 默认数值类型到ValidationDataType类型的映射
        public static ValidationDataType ValueTypeToValidationDataType(Type obj, string propertyName)
        {
            if (obj == null)
                throw new ArgumentException("obj");
            PropertyInfo property = obj.GetProperty(propertyName);
            return ValueTypeToValidationDataType(property.PropertyType);
        }

        // .net 默认数值类型到ValidationDataType类型的映射
        public static ValidationDataType ValueTypeToValidationDataType(Type typeForMap)
        {
            Type type = typeForMap;

            if (TypeHelper.IsNullable(type))
            {
                type = TypeHelper.GetUnderlyingType(type);
            }

            Dictionary<Type, ValidationDataType> dic = new Dictionary<Type, ValidationDataType>();

            dic.Add(typeof(System.Boolean), ValidationDataType.Integer);
            dic.Add(typeof(System.Byte), ValidationDataType.Integer);
            dic.Add(typeof(System.SByte), ValidationDataType.Integer);
            dic.Add(typeof(System.Char), ValidationDataType.String);
            dic.Add(typeof(System.Decimal), ValidationDataType.Double);
            dic.Add(typeof(System.Double), ValidationDataType.Double);
            dic.Add(typeof(System.Single), ValidationDataType.Double);
            dic.Add(typeof(System.Int32), ValidationDataType.Integer);
            dic.Add(typeof(System.UInt32), ValidationDataType.Integer);
            dic.Add(typeof(System.Int64), ValidationDataType.Integer);
            dic.Add(typeof(System.UInt64), ValidationDataType.Integer);
            dic.Add(typeof(System.Int16), ValidationDataType.Integer);
            dic.Add(typeof(System.UInt16), ValidationDataType.Integer);
            dic.Add(typeof(System.String), ValidationDataType.String);
            dic.Add(typeof(System.DateTime), ValidationDataType.Date);

            if (dic.ContainsKey(type))
            {
                return dic[type];
            }
            else
            {
                throw new ValidateException("未定义的数据类型映射");
            }
        }
    }

    public interface IValidatorFactory
    {
        CompareValidator CreateCompareValidator(Validate.CompareOption option);
        CompareValidator CreateCompareValidator(System.Web.UI.WebControls.ValidationCompareOperator oper, string valueToCompare);
        CompareValidator CreateDateTypeCheckValidator();
        RangeValidator CreateRangeValidator(string min, string max);
        RangeValidator CreateRangeValidator(Validate.RangeOption option);
        RegularExpressionValidator CreateRegularExpressionValidator(Validate.RegexValidateOption option);
        RequiredFieldValidator CreateRequiredFieldValidator();
    }

    /// <summary>
    /// 校验器创建工厂
    /// </summary>
    public class ValidatorFactory : IValidatorFactory 
    {
        private Control form;

		private string controlName;
		private ValidationDataType dataType;

        private readonly string space = " ";

        public ValidatorFactory(ValidateInfo info, Control form)
        {
			this.controlName = info.ControlName;
			this.dataType = info.DataType;

            this.form = form;
        }

		public ValidatorFactory(Control form, string controlName, ValidationDataType dataType)
        {
			this.form = form;
			this.controlName = controlName;
			this.dataType = dataType;
        }

        // 设置默认属性, 并绑定到UI控件
        private void BindToControl(BaseValidator vd)
        {
            Control c = form.FindControl(this.controlName);
			int index = form.Controls.IndexOf(c);
			int nobrPosition = index;
            int addPosition =  index + 2; // 插入到要绑定控件的后面, 这儿加2是因为前面已经插入了NoBr控制

			// rem: vd.ErrorMessage = info.ErrorMessage;    // 这儿根据校验类型生成错误信息,忽略配置里的错误信息
            vd.ControlToValidate = c.ID;                    // 绑定到控件
            vd.ID = "ID_" + Guid.NewGuid().ToString("N");   // 要处理唯一ID的问题, 这儿简单的使用GUID来创建
            vd.EnableClientScript = true;                   // 使用客户端校验
            vd.Display = ValidatorDisplay.Dynamic;          // 不占用显示空间
            vd.EnableViewState = false;                     // 默认不使用ViewState

            if (vd is BaseCompareValidator)
            {
                // 如果是比较类型的校验器,设置对应的数据类型
                (vd as BaseCompareValidator).Type = this.dataType;
            }

			this.form.Controls.AddAt(nobrPosition, CreateNoBrControl());
			this.form.Controls.AddAt(addPosition, vd);
        }

		private Literal CreateNoBrControl()
		{
			Literal result = new Literal();
			result.Text = "<nobr>";
			return result;
		}

        // 必填
        public RequiredFieldValidator CreateRequiredFieldValidator()
        {
            RequiredFieldValidator vd = new RequiredFieldValidator();
            BindToControl(vd);

            vd.ErrorMessage = space + "不能为空";
            return vd;
        }
        
        // 日期类型
        public CompareValidator CreateDateTypeCheckValidator()
        {
            CompareValidator vd = new CompareValidator();
            BindToControl(vd);

            vd.ErrorMessage = space + "错误的日期格式";
            vd.Operator = ValidationCompareOperator.DataTypeCheck;
            return vd;
        }

        // 范围类型
        public RangeValidator CreateRangeValidator(RangeOption option)
        {
            return CreateRangeValidator(option.Min, option.Max);
        }

        // 范围类型
        public RangeValidator CreateRangeValidator(string min, string max)
        {
            RangeValidator vd = new RangeValidator();
            BindToControl(vd);

            vd.MinimumValue = min;
            vd.MaximumValue = max;

            vd.ErrorMessage = space + string.Format("输入值要在{0}和{1}之间", min, max);
            return vd;
        }

        // 比较类型
        public CompareValidator CreateCompareValidator(CompareOption option)
        {
            return CreateCompareValidator(option.Operator, option.ValueToCompare);
        }

        // 比较类型
        public CompareValidator CreateCompareValidator(ValidationCompareOperator oper, string valueToCompare)
        {
            CompareValidator vd = new CompareValidator();
            BindToControl(vd);

            vd.ValueToCompare = valueToCompare;
            vd.Operator = oper;

            vd.ErrorMessage = space + string.Format("输入值要{0}{1}", ValidateConvert.GetDescription(oper), valueToCompare);
            return vd;
        }

        // 正则表达式类型
        public RegularExpressionValidator CreateRegularExpressionValidator(RegexValidateOption option)
        {
            RegularExpressionValidator vd = new RegularExpressionValidator();
            BindToControl(vd);

            vd.ValidationExpression = option.Regex;
            vd.ErrorMessage = space + option.Message;
            return vd;
        }
    }

    /// <summary>
    /// 表达式解析
    /// </summary>
    public class ValidatorParser
    {
        // 根据校验配置信息创建校验器
        public static void Parse(ValidateInfo info, IValidatorFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException("factory");

            if (info.Require == true)
            {
                factory.CreateRequiredFieldValidator();
            }

            if (info.DataType == ValidationDataType.Date)
            {
                factory.CreateDateTypeCheckValidator();
            }

            if (info.DataType == ValidationDataType.Integer)
                factory.CreateRegularExpressionValidator(GetIntTypeOption());

            if (info.DataType == ValidationDataType.Double)
                factory.CreateRegularExpressionValidator(GetDoubleTypeOption());

            string exp = info.Expression;
            if (IsRangeExpression(exp))
            {
                factory.CreateRangeValidator(GetRangeOption(exp));
            }

            if (IsCompareExpression(exp))
            {
                factory.CreateCompareValidator(GetCompareOption(exp));
            }
        }

        private static IntTypeRegexValidateOption GetIntTypeOption()
        {
            return new IntTypeRegexValidateOption(); 
        }

        private static DoubleTypeRegexValidateOption GetDoubleTypeOption()
        {
            return new DoubleTypeRegexValidateOption(); 
        }

        // 是否是range类型的表达式
        private static bool IsRangeExpression(string expression)
        {
            string exp = expression;
            exp = Format(exp);

            if (exp.IndexOf("range") != -1)
            {
                exp = exp.Replace("range", "");
                
                // 匹配整数和小数
                if (Regex.IsMatch(exp, @"^\d*\.?\d+,\d*\.?\d+$"))
                    return true;

                return false;
            }
            else
            {
                return false;
            }
        }

        // 是否是比较类型的表达式
        private static bool IsCompareExpression(string expression)
        {
            string exp = expression;
            exp = Format(exp);

            // 如果增加新的表达式类型,这儿要调整!
            if (!IsRangeExpression(expression))
            {
                exp = RemoveOperateChars(exp);
                return exp.Length > 0;
            }
            else
            {
                return false;
            }
        }

        // 格式化校验表达式
        private static string Format(string expression)
        {
            string exp = expression;
            exp = exp.Trim();
            exp = exp.ToLower();
            exp = exp.Replace(" ", "");
            exp = exp.Replace("(", "");
            exp = exp.Replace(")", "");
            return exp;
        }

        // 删除表达式中的><=操作符
        private static string RemoveOperateChars(string expression)
        {
            string exp = expression;
            exp = exp.Replace("<", "");
            exp = exp.Replace(">", "");
            exp = exp.Replace("=", "");
            return exp;
        }

        // 从表达式中提取:min, max 信息: range(1, 100) => min=1, max = 100
        private static RangeOption GetRangeOption(string expression)
        {
            string exp;
            string min, max;

            exp = expression;
            exp = Format(exp);
            exp = exp.Replace("range", "");

            string[] a = exp.Split(',');
            if (a.Length == 2)
            {
                min = a[0];
                max = a[1];
                return new RangeOption(min, max);
            }
            else
            {
                throw new ValidateException(string.Format("错误的表达式格式:{0}!", expression));
            }
        }

        // 从表达式中提取: 操作符,和比较值: >100 => 操作符: >, 比较值: 100
        private static CompareOption GetCompareOption(string expression)
        {
            string op;
            string exp;
            string value;
            exp = Format(expression);

            op = "";

            //>, < 操作符
            if (ValidateConvert.IsAllowedCompareExpression(exp.Substring(0, 1)))
            {
                op = exp.Substring(0, 1);
            }

            // >=, <>, <= 操作符
            if (ValidateConvert.IsAllowedCompareExpression(exp.Substring(0, 2)))
            {
                op = exp.Substring(0, 2);
            }

            if (op.Length >= 1)
            {
                value = RemoveOperateChars(exp);
                return new CompareOption(ValidateConvert.GetCompareOperatorByExpression(op), value);
            }
            else
            {
                throw new ValidateException(String.Format("错误的表达式格式:{0}", expression));
            }
        }
    }
}