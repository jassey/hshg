using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;

namespace Bll.SystemManage
{
	/// <summary>
	/// Strongly-typed collection for the UserInRole class.
	/// </summary>
	[Serializable]
	public partial class UserInRoleCollection : ActiveList<UserInRole, UserInRoleCollection> 
	{	   
		public UserInRoleCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the UserInRole table.
	/// </summary>
	[Serializable]
	public partial class UserInRole : ActiveRecord<UserInRole>
	{
		#region .ctors and Default Settings
		
		public UserInRole()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public UserInRole(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

		public UserInRole(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public UserInRole(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}

		
		protected static void SetSQLProps() { GetTableSchema(); }

		
		#endregion
		
		#region Schema and Query Accessor
		public static Query CreateQuery() { return new Query(Schema); }

		
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}

		}

		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("UserInRole", TableType.Table, DataService.GetInstance("Bll"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarUserId = new TableSchema.TableColumn(schema);
				colvarUserId.ColumnName = "UserId";
				colvarUserId.DataType = DbType.Guid;
				colvarUserId.MaxLength = 0;
				colvarUserId.AutoIncrement = false;
				colvarUserId.IsNullable = false;
				colvarUserId.IsPrimaryKey = true;
				colvarUserId.IsForeignKey = true;
				colvarUserId.IsReadOnly = false;
				colvarUserId.DefaultSetting = @"";
				
					colvarUserId.ForeignKeyTableName = "User";
				schema.Columns.Add(colvarUserId);
				
				TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
				colvarRoleId.ColumnName = "RoleId";
				colvarRoleId.DataType = DbType.Guid;
				colvarRoleId.MaxLength = 0;
				colvarRoleId.AutoIncrement = false;
				colvarRoleId.IsNullable = false;
				colvarRoleId.IsPrimaryKey = true;
				colvarRoleId.IsForeignKey = true;
				colvarRoleId.IsReadOnly = false;
				colvarRoleId.DefaultSetting = @"";
				
					colvarRoleId.ForeignKeyTableName = "Role";
				schema.Columns.Add(colvarRoleId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Bll"].AddSchema("UserInRole",schema);
			}

		}

		#endregion
		
		#region Props
		
		  
		[XmlAttribute("UserId")]
		public Guid UserId 
		{
			get { return GetColumnValue<Guid>("UserId"); }

			set { SetColumnValue("UserId", value); }

		}

		  
		[XmlAttribute("RoleId")]
		public Guid RoleId 
		{
			get { return GetColumnValue<Guid>("RoleId"); }

			set { SetColumnValue("RoleId", value); }

		}

		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Role ActiveRecord object related to this UserInRole
		/// 
		/// </summary>
		public Bll.SystemManage.Role Role
		{
			get { return Bll.SystemManage.Role.FetchByID(this.RoleId); }

			set { SetColumnValue("RoleId", value.RoleId); }

		}

		
		
		/// <summary>
		/// Returns a User ActiveRecord object related to this UserInRole
		/// 
		/// </summary>
		public Bll.SystemManage.User User
		{
			get { return Bll.SystemManage.User.FetchByID(this.UserId); }

			set { SetColumnValue("UserId", value.UserId); }

		}

		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(Guid varUserId,Guid varRoleId)
		{
			UserInRole item = new UserInRole();
			
			item.UserId = varUserId;
			
			item.RoleId = varRoleId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(Guid varUserId,Guid varRoleId)
		{
			UserInRole item = new UserInRole();
			
				item.UserId = varUserId;
				
				item.RoleId = varRoleId;
				
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string UserId = @"UserId";
			 public static string RoleId = @"RoleId";
						
		}

		#endregion
	}

}


