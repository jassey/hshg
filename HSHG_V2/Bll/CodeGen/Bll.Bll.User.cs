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
	/// Strongly-typed collection for the User class.
	/// </summary>
	[Serializable]
	public partial class UserCollection : ActiveList<User, UserCollection> 
	{	   
		public UserCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the User table.
	/// </summary>
	[Serializable]
	public partial class User : ActiveRecord<User>
	{
		#region .ctors and Default Settings
		
		public User()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public User(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

		public User(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public User(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("User", TableType.Table, DataService.GetInstance("Bll"));
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
				colvarUserId.IsForeignKey = false;
				colvarUserId.IsReadOnly = false;
				colvarUserId.DefaultSetting = @"";
				colvarUserId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserId);
				
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
				
				TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
				colvarUserName.ColumnName = "UserName";
				colvarUserName.DataType = DbType.String;
				colvarUserName.MaxLength = 100;
				colvarUserName.AutoIncrement = false;
				colvarUserName.IsNullable = false;
				colvarUserName.IsPrimaryKey = false;
				colvarUserName.IsForeignKey = false;
				colvarUserName.IsReadOnly = false;
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserName);
				
				TableSchema.TableColumn colvarPassword = new TableSchema.TableColumn(schema);
				colvarPassword.ColumnName = "Password";
				colvarPassword.DataType = DbType.String;
				colvarPassword.MaxLength = 200;
				colvarPassword.AutoIncrement = false;
				colvarPassword.IsNullable = false;
				colvarPassword.IsPrimaryKey = false;
				colvarPassword.IsForeignKey = false;
				colvarPassword.IsReadOnly = false;
				colvarPassword.DefaultSetting = @"";
				colvarPassword.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPassword);
				
				TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
				colvarEmail.ColumnName = "Email";
				colvarEmail.DataType = DbType.String;
				colvarEmail.MaxLength = 200;
				colvarEmail.AutoIncrement = false;
				colvarEmail.IsNullable = false;
				colvarEmail.IsPrimaryKey = false;
				colvarEmail.IsForeignKey = false;
				colvarEmail.IsReadOnly = false;
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmail);
				
				TableSchema.TableColumn colvarEmailActiveCode = new TableSchema.TableColumn(schema);
				colvarEmailActiveCode.ColumnName = "EmailActiveCode";
				colvarEmailActiveCode.DataType = DbType.String;
				colvarEmailActiveCode.MaxLength = 100;
				colvarEmailActiveCode.AutoIncrement = false;
				colvarEmailActiveCode.IsNullable = true;
				colvarEmailActiveCode.IsPrimaryKey = false;
				colvarEmailActiveCode.IsForeignKey = false;
				colvarEmailActiveCode.IsReadOnly = false;
				colvarEmailActiveCode.DefaultSetting = @"";
				colvarEmailActiveCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmailActiveCode);
				
				TableSchema.TableColumn colvarIsMailValidate = new TableSchema.TableColumn(schema);
				colvarIsMailValidate.ColumnName = "IsMailValidate";
				colvarIsMailValidate.DataType = DbType.Boolean;
				colvarIsMailValidate.MaxLength = 0;
				colvarIsMailValidate.AutoIncrement = false;
				colvarIsMailValidate.IsNullable = true;
				colvarIsMailValidate.IsPrimaryKey = false;
				colvarIsMailValidate.IsForeignKey = false;
				colvarIsMailValidate.IsReadOnly = false;
				
						colvarIsMailValidate.DefaultSetting = @"(0)";
				colvarIsMailValidate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMailValidate);
				
				TableSchema.TableColumn colvarIsLocked = new TableSchema.TableColumn(schema);
				colvarIsLocked.ColumnName = "IsLocked";
				colvarIsLocked.DataType = DbType.Boolean;
				colvarIsLocked.MaxLength = 0;
				colvarIsLocked.AutoIncrement = false;
				colvarIsLocked.IsNullable = true;
				colvarIsLocked.IsPrimaryKey = false;
				colvarIsLocked.IsForeignKey = false;
				colvarIsLocked.IsReadOnly = false;
				
						colvarIsLocked.DefaultSetting = @"(0)";
				colvarIsLocked.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsLocked);
				
				TableSchema.TableColumn colvarPasswordResetCode = new TableSchema.TableColumn(schema);
				colvarPasswordResetCode.ColumnName = "PasswordResetCode";
				colvarPasswordResetCode.DataType = DbType.String;
				colvarPasswordResetCode.MaxLength = 100;
				colvarPasswordResetCode.AutoIncrement = false;
				colvarPasswordResetCode.IsNullable = true;
				colvarPasswordResetCode.IsPrimaryKey = false;
				colvarPasswordResetCode.IsForeignKey = false;
				colvarPasswordResetCode.IsReadOnly = false;
				colvarPasswordResetCode.DefaultSetting = @"";
				colvarPasswordResetCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPasswordResetCode);
				
				TableSchema.TableColumn colvarCreateDate = new TableSchema.TableColumn(schema);
				colvarCreateDate.ColumnName = "CreateDate";
				colvarCreateDate.DataType = DbType.DateTime;
				colvarCreateDate.MaxLength = 0;
				colvarCreateDate.AutoIncrement = false;
				colvarCreateDate.IsNullable = true;
				colvarCreateDate.IsPrimaryKey = false;
				colvarCreateDate.IsForeignKey = false;
				colvarCreateDate.IsReadOnly = false;
				colvarCreateDate.DefaultSetting = @"";
				colvarCreateDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateDate);
				
				TableSchema.TableColumn colvarLastLoginDate = new TableSchema.TableColumn(schema);
				colvarLastLoginDate.ColumnName = "LastLoginDate";
				colvarLastLoginDate.DataType = DbType.DateTime;
				colvarLastLoginDate.MaxLength = 0;
				colvarLastLoginDate.AutoIncrement = false;
				colvarLastLoginDate.IsNullable = true;
				colvarLastLoginDate.IsPrimaryKey = false;
				colvarLastLoginDate.IsForeignKey = false;
				colvarLastLoginDate.IsReadOnly = false;
				colvarLastLoginDate.DefaultSetting = @"";
				colvarLastLoginDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLastLoginDate);
				
				TableSchema.TableColumn colvarLastPasswordChangedDate = new TableSchema.TableColumn(schema);
				colvarLastPasswordChangedDate.ColumnName = "LastPasswordChangedDate";
				colvarLastPasswordChangedDate.DataType = DbType.DateTime;
				colvarLastPasswordChangedDate.MaxLength = 0;
				colvarLastPasswordChangedDate.AutoIncrement = false;
				colvarLastPasswordChangedDate.IsNullable = true;
				colvarLastPasswordChangedDate.IsPrimaryKey = false;
				colvarLastPasswordChangedDate.IsForeignKey = false;
				colvarLastPasswordChangedDate.IsReadOnly = false;
				colvarLastPasswordChangedDate.DefaultSetting = @"";
				colvarLastPasswordChangedDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLastPasswordChangedDate);
				
				TableSchema.TableColumn colvarLastLockedDate = new TableSchema.TableColumn(schema);
				colvarLastLockedDate.ColumnName = "LastLockedDate";
				colvarLastLockedDate.DataType = DbType.DateTime;
				colvarLastLockedDate.MaxLength = 0;
				colvarLastLockedDate.AutoIncrement = false;
				colvarLastLockedDate.IsNullable = true;
				colvarLastLockedDate.IsPrimaryKey = false;
				colvarLastLockedDate.IsForeignKey = false;
				colvarLastLockedDate.IsReadOnly = false;
				colvarLastLockedDate.DefaultSetting = @"";
				colvarLastLockedDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLastLockedDate);
				
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
				DataService.Providers["Bll"].AddSchema("User",schema);
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

		  
		[XmlAttribute("Idx")]
		public int Idx 
		{
			get { return GetColumnValue<int>("Idx"); }

			set { SetColumnValue("Idx", value); }

		}

		  
		[XmlAttribute("UserName")]
		public string UserName 
		{
			get { return GetColumnValue<string>("UserName"); }

			set { SetColumnValue("UserName", value); }

		}

		  
		[XmlAttribute("Password")]
		public string Password 
		{
			get { return GetColumnValue<string>("Password"); }

			set { SetColumnValue("Password", value); }

		}

		  
		[XmlAttribute("Email")]
		public string Email 
		{
			get { return GetColumnValue<string>("Email"); }

			set { SetColumnValue("Email", value); }

		}

		  
		[XmlAttribute("EmailActiveCode")]
		public string EmailActiveCode 
		{
			get { return GetColumnValue<string>("EmailActiveCode"); }

			set { SetColumnValue("EmailActiveCode", value); }

		}

		  
		[XmlAttribute("IsMailValidate")]
		public bool? IsMailValidate 
		{
			get { return GetColumnValue<bool?>("IsMailValidate"); }

			set { SetColumnValue("IsMailValidate", value); }

		}

		  
		[XmlAttribute("IsLocked")]
		public bool? IsLocked 
		{
			get { return GetColumnValue<bool?>("IsLocked"); }

			set { SetColumnValue("IsLocked", value); }

		}

		  
		[XmlAttribute("PasswordResetCode")]
		public string PasswordResetCode 
		{
			get { return GetColumnValue<string>("PasswordResetCode"); }

			set { SetColumnValue("PasswordResetCode", value); }

		}

		  
		[XmlAttribute("CreateDate")]
		public DateTime? CreateDate 
		{
			get { return GetColumnValue<DateTime?>("CreateDate"); }

			set { SetColumnValue("CreateDate", value); }

		}

		  
		[XmlAttribute("LastLoginDate")]
		public DateTime? LastLoginDate 
		{
			get { return GetColumnValue<DateTime?>("LastLoginDate"); }

			set { SetColumnValue("LastLoginDate", value); }

		}

		  
		[XmlAttribute("LastPasswordChangedDate")]
		public DateTime? LastPasswordChangedDate 
		{
			get { return GetColumnValue<DateTime?>("LastPasswordChangedDate"); }

			set { SetColumnValue("LastPasswordChangedDate", value); }

		}

		  
		[XmlAttribute("LastLockedDate")]
		public DateTime? LastLockedDate 
		{
			get { return GetColumnValue<DateTime?>("LastLockedDate"); }

			set { SetColumnValue("LastLockedDate", value); }

		}

		  
		[XmlAttribute("Comment")]
		public string Comment 
		{
			get { return GetColumnValue<string>("Comment"); }

			set { SetColumnValue("Comment", value); }

		}

		
		#endregion
		
		
		#region PrimaryKey Methods
		
		public Bll.SystemManage.UserInfoCollection UserInfoRecords()
		{
			return new Bll.SystemManage.UserInfoCollection().Where(UserInfo.Columns.UserId, UserId).Load();
		}

		public Bll.SystemManage.UserInRoleCollection UserInRoleRecords()
		{
			return new Bll.SystemManage.UserInRoleCollection().Where(UserInRole.Columns.UserId, UserId).Load();
		}

		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		#region Many To Many Helpers
		
		 
		public Bll.SystemManage.RoleCollection GetRoleCollection() { return User.GetRoleCollection(this.UserId); }

		public static Bll.SystemManage.RoleCollection GetRoleCollection(Guid varUserId)
		{
			SubSonic.QueryCommand cmd = new SubSonic.QueryCommand(
				"SELECT * FROM Role INNER JOIN UserInRole ON "+
				"Role.RoleId=UserInRole.RoleId WHERE UserInRole.UserId=@UserId", User.Schema.Provider.Name);
			
			cmd.AddParameter("@UserId", varUserId, DbType.Guid);
			IDataReader rdr = SubSonic.DataService.GetReader(cmd);
			RoleCollection coll = new RoleCollection();
			coll.LoadAndCloseReader(rdr);
			return coll;
		}

		
		public static void SaveRoleMap(Guid varUserId, RoleCollection items)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE UserId=@UserId", User.Schema.Provider.Name);
			cmdDel.AddParameter("@UserId", varUserId);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (Role item in items)
			{
				UserInRole varUserInRole = new UserInRole();
				varUserInRole.SetColumnValue("UserId", varUserId);
				varUserInRole.SetColumnValue("RoleId", item.GetPrimaryKeyValue());
				varUserInRole.Save();
			}

		}

		public static void SaveRoleMap(Guid varUserId, System.Web.UI.WebControls.ListItemCollection itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE UserId=@UserId", User.Schema.Provider.Name);
			cmdDel.AddParameter("@UserId", varUserId);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList) 
			{
				if (l.Selected) 
				{
					UserInRole varUserInRole = new UserInRole();
					varUserInRole.SetColumnValue("UserId", varUserId);
					varUserInRole.SetColumnValue("RoleId", l.Value);
					varUserInRole.Save();
				}
			}

		}

		public static void SaveRoleMap(Guid varUserId , Guid[] itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE UserId=@UserId", User.Schema.Provider.Name);
			cmdDel.AddParameter("@UserId", varUserId.ToString());
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (Guid item in itemList) 
			{
				UserInRole varUserInRole = new UserInRole();
				varUserInRole.SetColumnValue("UserId", varUserId);
				varUserInRole.SetColumnValue("RoleId", item);
				varUserInRole.Save();
			}

		}

		
		public static void DeleteRoleMap(Guid varUserId) 
		{
			QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE UserId=@UserId", User.Schema.Provider.Name);
			cmdDel.AddParameter("@UserId", varUserId);
			DataService.ExecuteQuery(cmdDel);
		}

		
		#endregion
		
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(Guid varUserId,string varUserName,string varPassword,string varEmail,string varEmailActiveCode,bool? varIsMailValidate,bool? varIsLocked,string varPasswordResetCode,DateTime? varCreateDate,DateTime? varLastLoginDate,DateTime? varLastPasswordChangedDate,DateTime? varLastLockedDate,string varComment)
		{
			User item = new User();
			
			item.UserId = varUserId;
			
			item.UserName = varUserName;
			
			item.Password = varPassword;
			
			item.Email = varEmail;
			
			item.EmailActiveCode = varEmailActiveCode;
			
			item.IsMailValidate = varIsMailValidate;
			
			item.IsLocked = varIsLocked;
			
			item.PasswordResetCode = varPasswordResetCode;
			
			item.CreateDate = varCreateDate;
			
			item.LastLoginDate = varLastLoginDate;
			
			item.LastPasswordChangedDate = varLastPasswordChangedDate;
			
			item.LastLockedDate = varLastLockedDate;
			
			item.Comment = varComment;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(Guid varUserId,int varIdx,string varUserName,string varPassword,string varEmail,string varEmailActiveCode,bool? varIsMailValidate,bool? varIsLocked,string varPasswordResetCode,DateTime? varCreateDate,DateTime? varLastLoginDate,DateTime? varLastPasswordChangedDate,DateTime? varLastLockedDate,string varComment)
		{
			User item = new User();
			
				item.UserId = varUserId;
				
				item.Idx = varIdx;
				
				item.UserName = varUserName;
				
				item.Password = varPassword;
				
				item.Email = varEmail;
				
				item.EmailActiveCode = varEmailActiveCode;
				
				item.IsMailValidate = varIsMailValidate;
				
				item.IsLocked = varIsLocked;
				
				item.PasswordResetCode = varPasswordResetCode;
				
				item.CreateDate = varCreateDate;
				
				item.LastLoginDate = varLastLoginDate;
				
				item.LastPasswordChangedDate = varLastPasswordChangedDate;
				
				item.LastLockedDate = varLastLockedDate;
				
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
			 public static string UserId = @"UserId";
			 public static string Idx = @"Idx";
			 public static string UserName = @"UserName";
			 public static string Password = @"Password";
			 public static string Email = @"Email";
			 public static string EmailActiveCode = @"EmailActiveCode";
			 public static string IsMailValidate = @"IsMailValidate";
			 public static string IsLocked = @"IsLocked";
			 public static string PasswordResetCode = @"PasswordResetCode";
			 public static string CreateDate = @"CreateDate";
			 public static string LastLoginDate = @"LastLoginDate";
			 public static string LastPasswordChangedDate = @"LastPasswordChangedDate";
			 public static string LastLockedDate = @"LastLockedDate";
			 public static string Comment = @"Comment";
						
		}

		#endregion
	}

}


