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
		/// ����Ƿ���Nullable����
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
		/// ���nullable������ʵ����ָ����������
		/// </summary>
		public static Type GetUnderlyingType(Type type)
		{
			return Nullable.GetUnderlyingType(type);
		}

		/// <summary>
		/// �����������Ƿ���ָ�����Ƶ�����
		/// </summary>
		public static bool HasProperty(Type type, string name)
		{
			return type.GetProperty(name) != null;
		}
		
		/// <summary>
		/// ���ָ����������������б�
		/// </summary>
		public static List<string> GetObjectProperties(object obj)
		{
			return GetObjectProperties(obj.GetType());
		}

		/// <summary>
		/// ���ָ����������������б�
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

