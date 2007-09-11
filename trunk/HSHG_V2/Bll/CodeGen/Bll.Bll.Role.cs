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

namespace Hshg.Bll.SystemManage
{
	/// <summary>
	/// Strongly-typed collection for the Role class.
	/// </summary>
	[Serializable]
	public partial class RoleCollection : ActiveList<Role, RoleCollection> 
	{	   
		public RoleCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the Role table.
	/// </summary>
	[Serializable]
	public partial class Role : ActiveRecord<Role>
	{
		#region .ctors and Default Settings
		
		public Role()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public Role(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

		public Role(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public Role(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Role", TableType.Table, DataService.GetInstance("Bll"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
				colvarRoleId.ColumnName = "RoleId";
				colvarRoleId.DataType = DbType.Guid;
				colvarRoleId.MaxLength = 0;
				colvarRoleId.AutoIncrement = false;
				colvarRoleId.IsNullable = false;
				colvarRoleId.IsPrimaryKey = true;
				colvarRoleId.IsForeignKey = false;
				colvarRoleId.IsReadOnly = false;
				colvarRoleId.DefaultSetting = @"";
				colvarRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleId);
				
				TableSchema.TableColumn colvarIdx = new TableSchema.TableColumn(schema);
				colvarIdx.ColumnName = "Idx";
				colvarIdx.DataType = DbType.Int32;
				colvarIdx.MaxLength = 0;
				colvarIdx.AutoIncrement = true;
				colvarIdx.IsNullable = false;
				colvarIdx.IsPrimaryKey = false;
				colvarIdx.IsForeignKey = false;
				colvarIdx.IsReadOnly = false;
				colvarIdx.DefaultSetting = @"";
				colvarIdx.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdx);
				
				TableSchema.TableColumn colvarRoleName = new TableSchema.TableColumn(schema);
				colvarRoleName.ColumnName = "RoleName";
				colvarRoleName.DataType = DbType.String;
				colvarRoleName.MaxLength = 200;
				colvarRoleName.AutoIncrement = false;
				colvarRoleName.IsNullable = false;
				colvarRoleName.IsPrimaryKey = false;
				colvarRoleName.IsForeignKey = false;
				colvarRoleName.IsReadOnly = false;
				colvarRoleName.DefaultSetting = @"";
				colvarRoleName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleName);
				
				TableSchema.TableColumn colvarComment = new TableSchema.TableColumn(schema);
				colvarComment.ColumnName = "Comment";
				colvarComment.DataType = DbType.String;
				colvarComment.MaxLength = 200;
				colvarComment.AutoIncrement = false;
				colvarComment.IsNullable = true;
				colvarComment.IsPrimaryKey = false;
				colvarComment.IsForeignKey = false;
				colvarComment.IsReadOnly = false;
				colvarComment.DefaultSetting = @"";
				colvarComment.ForeignKeyTableName = "";
				schema.Columns.Add(colvarComment);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Bll"].AddSchema("Role",schema);
			}

		}

		#endregion
		
		#region Props
		
		  
		[XmlAttribute("RoleId")]
		public Guid RoleId 
		{
			get { return GetColumnValue<Guid>("RoleId"); }

			set { SetColumnValue("RoleId", value); }

		}

		  
		[XmlAttribute("Idx")]
		public int Idx 
		{
			get { return GetColumnValue<int>("Idx"); }

			set { SetColumnValue("Idx", value); }

		}

		  
		[XmlAttribute("RoleName")]
		public string RoleName 
		{
			get { return GetColumnValue<string>("RoleName"); }

			set { SetColumnValue("RoleName", value); }

		}

		  
		[XmlAttribute("Comment")]
		public string Comment 
		{
			get { return GetColumnValue<string>("Comment"); }

			set { SetColumnValue("Comment", value); }

		}

		
		#endregion
		
		
		#region PrimaryKey Methods
		
		public Bll.SystemManage.UserInRoleCollection UserInRoleRecords()
		{
			return new Bll.SystemManage.UserInRoleCollection().Where(UserInRole.Columns.RoleId, RoleId).Load();
		}

		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		#region Many To Many Helpers
		
		 
		public Bll.SystemManage.UserCollection GetUserCollection() { return Role.GetUserCollection(this.RoleId); }

		public static Bll.SystemManage.UserCollection GetUserCollection(Guid varRoleId)
		{
			SubSonic.QueryCommand cmd = new SubSonic.QueryCommand(
				"SELECT * FROM User INNER JOIN UserInRole ON "+
				"User.UserId=UserInRole.UserId WHERE UserInRole.RoleId=@RoleId", Role.Schema.Provider.Name);
			
			cmd.AddParameter("@RoleId", varRoleId, DbType.Guid);
			IDataReader rdr = SubSonic.DataService.GetReader(cmd);
			UserCollection coll = new UserCollection();
			coll.LoadAndCloseReader(rdr);
			return coll;
		}

		
		public static void SaveUserMap(Guid varRoleId, UserCollection items)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE RoleId=@RoleId", Role.Schema.Provider.Name);
			cmdDel.AddParameter("@RoleId", varRoleId);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (User item in items)
			{
				UserInRole varUserInRole = new UserInRole();
				varUserInRole.SetColumnValue("RoleId", varRoleId);
				varUserInRole.SetColumnValue("UserId", item.GetPrimaryKeyValue());
				varUserInRole.Save();
			}

		}

		public static void SaveUserMap(Guid varRoleId, System.Web.UI.WebControls.ListItemCollection itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE RoleId=@RoleId", Role.Schema.Provider.Name);
			cmdDel.AddParameter("@RoleId", varRoleId);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList) 
			{
				if (l.Selected) 
				{
					UserInRole varUserInRole = new UserInRole();
					varUserInRole.SetColumnValue("RoleId", varRoleId);
					varUserInRole.SetColumnValue("UserId", l.Value);
					varUserInRole.Save();
				}

			}

		}

		public static void SaveUserMap(Guid varRoleId , Guid[] itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE RoleId=@RoleId", Role.Schema.Provider.Name);
			cmdDel.AddParameter("@RoleId", varRoleId);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (Guid item in itemList) 
			{
				UserInRole varUserInRole = new UserInRole();
				varUserInRole.SetColumnValue("RoleId", varRoleId);
				varUserInRole.SetColumnValue("UserId", item);
				varUserInRole.Save();
			}

		}

		
		public static void DeleteUserMap(Guid varRoleId) 
		{
			QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE RoleId=@RoleId", Role.Schema.Provider.Name);
			cmdDel.AddParameter("@RoleId", varRoleId);
			DataService.ExecuteQuery(cmdDel);
		}

		
		#endregion
		
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(Guid varRoleId,string varRoleName,string varComment)
		{
			Role item = new Role();
			
			item.RoleId = varRoleId;
			
			item.RoleName = varRoleName;
			
			item.Comment = varComment;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(Guid varRoleId,int varIdx,string varRoleName,string varComment)
		{
			Role item = new Role();
			
				item.RoleId = varRoleId;
				
				item.Idx = varIdx;
				
				item.RoleName = varRoleName;
				
				item.Comment = varComment;
				
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
			 public static string RoleId = @"RoleId";
			 public static string Idx = @"Idx";
			 public static string RoleName = @"RoleName";
			 public static string Comment = @"Comment";
						
		}

		#endregion
	}

}


