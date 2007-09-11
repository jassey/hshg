using System;
using System.ComponentModel;
using System.Collections;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace Hshg.Core.Utility
{
	public class TypeHelper
	{
		/// <summary>
		/// 检查是否是Nullable类型
		/// </summary>
		public static bool IsNullable(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			bool result = false;
			if (type.IsGenericType && !type.IsGenericTypeDefinition)
			{
				if (type.GetGenericTypeDefinition() == typeof(Nullable<>))
					result = true;
			}
			return result;
		}

		/// <summary>
		/// 获得nullable类型下实际所指的数据类型
		/// </summary>
		public static Type GetUnderlyingType(Type type)
		{
			return Nullable.GetUnderlyingType(type);
		}

		/// <summary>
		/// 检查对象类型是否含有指定名称的属性
		/// </summary>
		public static bool HasProperty(Type type, string name)
		{
			return type.GetProperty(name) != null;
		}
		
		/// <summary>
		/// 获得指定对象的属性名称列表
		/// </summary>
		public static List<string> GetObjectProperties(object obj)
		{
			return GetObjectProperties(obj.GetType());
		}

		/// <summary>
		/// 获得指定对象的属性名称列表
		/// </summary>
		public static List<string> GetObjectProperties(Type type)
		{
			List<string> result = new List<string>();

			foreach (PropertyInfo info in type.GetProperties())
			{
				result.Add(info.Name);
			}
			return result;
		}


	}
}

