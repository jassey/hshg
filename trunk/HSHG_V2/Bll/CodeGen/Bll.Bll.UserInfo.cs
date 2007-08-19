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
	/// Strongly-typed collection for the UserInfo class.
	/// </summary>
	[Serializable]
	public partial class UserInfoCollection : ActiveList<UserInfo, UserInfoCollection> 
	{	   
		public UserInfoCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the UserInfo table.
	/// </summary>
	[Serializable]
	public partial class UserInfo : ActiveRecord<UserInfo>
	{
		#region .ctors and Default Settings
		
		public UserInfo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public UserInfo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

		public UserInfo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public UserInfo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("UserInfo", TableType.Table, DataService.GetInstance("Bll"));
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
				
				TableSchema.TableColumn colvarTrueName = new TableSchema.TableColumn(schema);
				colvarTrueName.ColumnName = "TrueName";
				colvarTrueName.DataType = DbType.String;
				colvarTrueName.MaxLength = 50;
				colvarTrueName.AutoIncrement = false;
				colvarTrueName.IsNullable = true;
				colvarTrueName.IsPrimaryKey = false;
				colvarTrueName.IsForeignKey = false;
				colvarTrueName.IsReadOnly = false;
				colvarTrueName.DefaultSetting = @"";
				colvarTrueName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrueName);
				
				TableSchema.TableColumn colvarSex = new TableSchema.TableColumn(schema);
				colvarSex.ColumnName = "Sex";
				colvarSex.DataType = DbType.Boolean;
				colvarSex.MaxLength = 0;
				colvarSex.AutoIncrement = false;
				colvarSex.IsNullable = true;
				colvarSex.IsPrimaryKey = false;
				colvarSex.IsForeignKey = false;
				colvarSex.IsReadOnly = false;
				colvarSex.DefaultSetting = @"";
				colvarSex.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSex);
				
				TableSchema.TableColumn colvarPId = new TableSchema.TableColumn(schema);
				colvarPId.ColumnName = "PId";
				colvarPId.DataType = DbType.String;
				colvarPId.MaxLength = 50;
				colvarPId.AutoIncrement = false;
				colvarPId.IsNullable = true;
				colvarPId.IsPrimaryKey = false;
				colvarPId.IsForeignKey = false;
				colvarPId.IsReadOnly = false;
				colvarPId.DefaultSetting = @"";
				colvarPId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPId);
				
				TableSchema.TableColumn colvarBirthDate = new TableSchema.TableColumn(schema);
				colvarBirthDate.ColumnName = "BirthDate";
				colvarBirthDate.DataType = DbType.DateTime;
				colvarBirthDate.MaxLength = 0;
				colvarBirthDate.AutoIncrement = false;
				colvarBirthDate.IsNullable = true;
				colvarBirthDate.IsPrimaryKey = false;
				colvarBirthDate.IsForeignKey = false;
				colvarBirthDate.IsReadOnly = false;
				colvarBirthDate.DefaultSetting = @"";
				colvarBirthDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBirthDate);
				
				TableSchema.TableColumn colvarAreaCountry = new TableSchema.TableColumn(schema);
				colvarAreaCountry.ColumnName = "Area_Country";
				colvarAreaCountry.DataType = DbType.String;
				colvarAreaCountry.MaxLength = 50;
				colvarAreaCountry.AutoIncrement = false;
				colvarAreaCountry.IsNullable = true;
				colvarAreaCountry.IsPrimaryKey = false;
				colvarAreaCountry.IsForeignKey = false;
				colvarAreaCountry.IsReadOnly = false;
				colvarAreaCountry.DefaultSetting = @"";
				colvarAreaCountry.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAreaCountry);
				
				TableSchema.TableColumn colvarAreaProvince = new TableSchema.TableColumn(schema);
				colvarAreaProvince.ColumnName = "Area_Province";
				colvarAreaProvince.DataType = DbType.String;
				colvarAreaProvince.MaxLength = 50;
				colvarAreaProvince.AutoIncrement = false;
				colvarAreaProvince.IsNullable = true;
				colvarAreaProvince.IsPrimaryKey = false;
				colvarAreaProvince.IsForeignKey = false;
				colvarAreaProvince.IsReadOnly = false;
				colvarAreaProvince.DefaultSetting = @"";
				colvarAreaProvince.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAreaProvince);
				
				TableSchema.TableColumn colvarAreaCity = new TableSchema.TableColumn(schema);
				colvarAreaCity.ColumnName = "Area_City";
				colvarAreaCity.DataType = DbType.String;
				colvarAreaCity.MaxLength = 50;
				colvarAreaCity.AutoIncrement = false;
				colvarAreaCity.IsNullable = true;
				colvarAreaCity.IsPrimaryKey = false;
				colvarAreaCity.IsForeignKey = false;
				colvarAreaCity.IsReadOnly = false;
				colvarAreaCity.DefaultSetting = @"";
				colvarAreaCity.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAreaCity);
				
				TableSchema.TableColumn colvarAddress = new TableSchema.TableColumn(schema);
				colvarAddress.ColumnName = "Address";
				colvarAddress.DataType = DbType.String;
				colvarAddress.MaxLength = 200;
				colvarAddress.AutoIncrement = false;
				colvarAddress.IsNullable = true;
				colvarAddress.IsPrimaryKey = false;
				colvarAddress.IsForeignKey = false;
				colvarAddress.IsReadOnly = false;
				colvarAddress.DefaultSetting = @"";
				colvarAddress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAddress);
				
				TableSchema.TableColumn colvarPostCode = new TableSchema.TableColumn(schema);
				colvarPostCode.ColumnName = "PostCode";
				colvarPostCode.DataType = DbType.String;
				colvarPostCode.MaxLength = 20;
				colvarPostCode.AutoIncrement = false;
				colvarPostCode.IsNullable = true;
				colvarPostCode.IsPrimaryKey = false;
				colvarPostCode.IsForeignKey = false;
				colvarPostCode.IsReadOnly = false;
				colvarPostCode.DefaultSetting = @"";
				colvarPostCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPostCode);
				
				TableSchema.TableColumn colvarMobile = new TableSchema.TableColumn(schema);
				colvarMobile.ColumnName = "Mobile";
				colvarMobile.DataType = DbType.String;
				colvarMobile.MaxLength = 20;
				colvarMobile.AutoIncrement = false;
				colvarMobile.IsNullable = true;
				colvarMobile.IsPrimaryKey = false;
				colvarMobile.IsForeignKey = false;
				colvarMobile.IsReadOnly = false;
				colvarMobile.DefaultSetting = @"";
				colvarMobile.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMobile);
				
				TableSchema.TableColumn colvarUnit = new TableSchema.TableColumn(schema);
				colvarUnit.ColumnName = "Unit";
				colvarUnit.DataType = DbType.String;
				colvarUnit.MaxLength = 200;
				colvarUnit.AutoIncrement = false;
				colvarUnit.IsNullable = true;
				colvarUnit.IsPrimaryKey = false;
				colvarUnit.IsForeignKey = false;
				colvarUnit.IsReadOnly = false;
				colvarUnit.DefaultSetting = @"";
				colvarUnit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnit);
				
				TableSchema.TableColumn colvarUnitPhone = new TableSchema.TableColumn(schema);
				colvarUnitPhone.ColumnName = "UnitPhone";
				colvarUnitPhone.DataType = DbType.String;
				colvarUnitPhone.MaxLength = 20;
				colvarUnitPhone.AutoIncrement = false;
				colvarUnitPhone.IsNullable = true;
				colvarUnitPhone.IsPrimaryKey = false;
				colvarUnitPhone.IsForeignKey = false;
				colvarUnitPhone.IsReadOnly = false;
				colvarUnitPhone.DefaultSetting = @"";
				colvarUnitPhone.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitPhone);
				
				TableSchema.TableColumn colvarHomePhone = new TableSchema.TableColumn(schema);
				colvarHomePhone.ColumnName = "HomePhone";
				colvarHomePhone.DataType = DbType.String;
				colvarHomePhone.MaxLength = 20;
				colvarHomePhone.AutoIncrement = false;
				colvarHomePhone.IsNullable = true;
				colvarHomePhone.IsPrimaryKey = false;
				colvarHomePhone.IsForeignKey = false;
				colvarHomePhone.IsReadOnly = false;
				colvarHomePhone.DefaultSetting = @"";
				colvarHomePhone.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHomePhone);
				
				TableSchema.TableColumn colvarMsn = new TableSchema.TableColumn(schema);
				colvarMsn.ColumnName = "MSN";
				colvarMsn.DataType = DbType.String;
				colvarMsn.MaxLength = 50;
				colvarMsn.AutoIncrement = false;
				colvarMsn.IsNullable = true;
				colvarMsn.IsPrimaryKey = false;
				colvarMsn.IsForeignKey = false;
				colvarMsn.IsReadOnly = false;
				colvarMsn.DefaultSetting = @"";
				colvarMsn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMsn);
				
				TableSchema.TableColumn colvarQq = new TableSchema.TableColumn(schema);
				colvarQq.ColumnName = "QQ";
				colvarQq.DataType = DbType.String;
				colvarQq.MaxLength = 50;
				colvarQq.AutoIncrement = false;
				colvarQq.IsNullable = true;
				colvarQq.IsPrimaryKey = false;
				colvarQq.IsForeignKey = false;
				colvarQq.IsReadOnly = false;
				colvarQq.DefaultSetting = @"";
				colvarQq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQq);
				
				TableSchema.TableColumn colvarHomePage = new TableSchema.TableColumn(schema);
				colvarHomePage.ColumnName = "HomePage";
				colvarHomePage.DataType = DbType.String;
				colvarHomePage.MaxLength = 200;
				colvarHomePage.AutoIncrement = false;
				colvarHomePage.IsNullable = true;
				colvarHomePage.IsPrimaryKey = false;
				colvarHomePage.IsForeignKey = false;
				colvarHomePage.IsReadOnly = false;
				colvarHomePage.DefaultSetting = @"";
				colvarHomePage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHomePage);
				
				TableSchema.TableColumn colvarServiceForUs = new TableSchema.TableColumn(schema);
				colvarServiceForUs.ColumnName = "ServiceForUs";
				colvarServiceForUs.DataType = DbType.String;
				colvarServiceForUs.MaxLength = 500;
				colvarServiceForUs.AutoIncrement = false;
				colvarServiceForUs.IsNullable = true;
				colvarServiceForUs.IsPrimaryKey = false;
				colvarServiceForUs.IsForeignKey = false;
				colvarServiceForUs.IsReadOnly = false;
				colvarServiceForUs.DefaultSetting = @"";
				colvarServiceForUs.ForeignKeyTableName = "";
				schema.Columns.Add(colvarServiceForUs);
				
				TableSchema.TableColumn colvarComment = new TableSchema.TableColumn(schema);
				colvarComment.ColumnName = "Comment";
				colvarComment.DataType = DbType.String;
				colvarComment.MaxLength = 500;
				colvarComment.AutoIncrement = false;
				colvarComment.IsNullable = true;
				colvarComment.IsPrimaryKey = false;
				colvarComment.IsForeignKey = false;
				colvarComment.IsReadOnly = false;
				colvarComment.DefaultSetting = @"";
				colvarComment.ForeignKeyTableName = "";
				schema.Columns.Add(colvarComment);
				
				TableSchema.TableColumn colvarIsPublicPersonalInfo = new TableSchema.TableColumn(schema);
				colvarIsPublicPersonalInfo.ColumnName = "IsPublicPersonalInfo";
				colvarIsPublicPersonalInfo.DataType = DbType.Boolean;
				colvarIsPublicPersonalInfo.MaxLength = 0;
				colvarIsPublicPersonalInfo.AutoIncrement = false;
				colvarIsPublicPersonalInfo.IsNullable = true;
				colvarIsPublicPersonalInfo.IsPrimaryKey = false;
				colvarIsPublicPersonalInfo.IsForeignKey = false;
				colvarIsPublicPersonalInfo.IsReadOnly = false;
				colvarIsPublicPersonalInfo.DefaultSetting = @"";
				colvarIsPublicPersonalInfo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsPublicPersonalInfo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Bll"].AddSchema("UserInfo",schema);
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

		  
		[XmlAttribute("TrueName")]
		public string TrueName 
		{
			get { return GetColumnValue<string>("TrueName"); }

			set { SetColumnValue("TrueName", value); }

		}

		  
		[XmlAttribute("Sex")]
		public bool? Sex 
		{
			get { return GetColumnValue<bool?>("Sex"); }

			set { SetColumnValue("Sex", value); }

		}

		  
		[XmlAttribute("PId")]
		public string PId 
		{
			get { return GetColumnValue<string>("PId"); }

			set { SetColumnValue("PId", value); }

		}

		  
		[XmlAttribute("BirthDate")]
		public DateTime? BirthDate 
		{
			get { return GetColumnValue<DateTime?>("BirthDate"); }

			set { SetColumnValue("BirthDate", value); }

		}

		  
		[XmlAttribute("AreaCountry")]
		public string AreaCountry 
		{
			get { return GetColumnValue<string>("Area_Country"); }

			set { SetColumnValue("Area_Country", value); }

		}

		  
		[XmlAttribute("AreaProvince")]
		public string AreaProvince 
		{
			get { return GetColumnValue<string>("Area_Province"); }

			set { SetColumnValue("Area_Province", value); }

		}

		  
		[XmlAttribute("AreaCity")]
		public string AreaCity 
		{
			get { return GetColumnValue<string>("Area_City"); }

			set { SetColumnValue("Area_City", value); }

		}

		  
		[XmlAttribute("Address")]
		public string Address 
		{
			get { return GetColumnValue<string>("Address"); }

			set { SetColumnValue("Address", value); }

		}

		  
		[XmlAttribute("PostCode")]
		public string PostCode 
		{
			get { return GetColumnValue<string>("PostCode"); }

			set { SetColumnValue("PostCode", value); }

		}

		  
		[XmlAttribute("Mobile")]
		public string Mobile 
		{
			get { return GetColumnValue<string>("Mobile"); }

			set { SetColumnValue("Mobile", value); }

		}

		  
		[XmlAttribute("Unit")]
		public string Unit 
		{
			get { return GetColumnValue<string>("Unit"); }

			set { SetColumnValue("Unit", value); }

		}

		  
		[XmlAttribute("UnitPhone")]
		public string UnitPhone 
		{
			get { return GetColumnValue<string>("UnitPhone"); }

			set { SetColumnValue("UnitPhone", value); }

		}

		  
		[XmlAttribute("HomePhone")]
		public string HomePhone 
		{
			get { return GetColumnValue<string>("HomePhone"); }

			set { SetColumnValue("HomePhone", value); }

		}

		  
		[XmlAttribute("Msn")]
		public string Msn 
		{
			get { return GetColumnValue<string>("MSN"); }

			set { SetColumnValue("MSN", value); }

		}

		  
		[XmlAttribute("Qq")]
		public string Qq 
		{
			get { return GetColumnValue<string>("QQ"); }

			set { SetColumnValue("QQ", value); }

		}

		  
		[XmlAttribute("HomePage")]
		public string HomePage 
		{
			get { return GetColumnValue<string>("HomePage"); }

			set { SetColumnValue("HomePage", value); }

		}

		  
		[XmlAttribute("ServiceForUs")]
		public string ServiceForUs 
		{
			get { return GetColumnValue<string>("ServiceForUs"); }

			set { SetColumnValue("ServiceForUs", value); }

		}

		  
		[XmlAttribute("Comment")]
		public string Comment 
		{
			get { return GetColumnValue<string>("Comment"); }

			set { SetColumnValue("Comment", value); }

		}

		  
		[XmlAttribute("IsPublicPersonalInfo")]
		public bool? IsPublicPersonalInfo 
		{
			get { return GetColumnValue<bool?>("IsPublicPersonalInfo"); }

			set { SetColumnValue("IsPublicPersonalInfo", value); }

		}

		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a User ActiveRecord object related to this UserInfo
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
		public static void Insert(Guid varUserId,string varTrueName,bool? varSex,string varPId,DateTime? varBirthDate,string varAreaCountry,string varAreaProvince,string varAreaCity,string varAddress,string varPostCode,string varMobile,string varUnit,string varUnitPhone,string varHomePhone,string varMsn,string varQq,string varHomePage,string varServiceForUs,string varComment,bool? varIsPublicPersonalInfo)
		{
			UserInfo item = new UserInfo();
			
			item.UserId = varUserId;
			
			item.TrueName = varTrueName;
			
			item.Sex = varSex;
			
			item.PId = varPId;
			
			item.BirthDate = varBirthDate;
			
			item.AreaCountry = varAreaCountry;
			
			item.AreaProvince = varAreaProvince;
			
			item.AreaCity = varAreaCity;
			
			item.Address = varAddress;
			
			item.PostCode = varPostCode;
			
			item.Mobile = varMobile;
			
			item.Unit = varUnit;
			
			item.UnitPhone = varUnitPhone;
			
			item.HomePhone = varHomePhone;
			
			item.Msn = varMsn;
			
			item.Qq = varQq;
			
			item.HomePage = varHomePage;
			
			item.ServiceForUs = varServiceForUs;
			
			item.Comment = varComment;
			
			item.IsPublicPersonalInfo = varIsPublicPersonalInfo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(Guid varUserId,string varTrueName,bool? varSex,string varPId,DateTime? varBirthDate,string varAreaCountry,string varAreaProvince,string varAreaCity,string varAddress,string varPostCode,string varMobile,string varUnit,string varUnitPhone,string varHomePhone,string varMsn,string varQq,string varHomePage,string varServiceForUs,string varComment,bool? varIsPublicPersonalInfo)
		{
			UserInfo item = new UserInfo();
			
				item.UserId = varUserId;
				
				item.TrueName = varTrueName;
				
				item.Sex = varSex;
				
				item.PId = varPId;
				
				item.BirthDate = varBirthDate;
				
				item.AreaCountry = varAreaCountry;
				
				item.AreaProvince = varAreaProvince;
				
				item.AreaCity = varAreaCity;
				
				item.Address = varAddress;
				
				item.PostCode = varPostCode;
				
				item.Mobile = varMobile;
				
				item.Unit = varUnit;
				
				item.UnitPhone = varUnitPhone;
				
				item.HomePhone = varHomePhone;
				
				item.Msn = varMsn;
				
				item.Qq = varQq;
				
				item.HomePage = varHomePage;
				
				item.ServiceForUs = varServiceForUs;
				
				item.Comment = varComment;
				
				item.IsPublicPersonalInfo = varIsPublicPersonalInfo;
				
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
			 public static string TrueName = @"TrueName";
			 public static string Sex = @"Sex";
			 public static string PId = @"PId";
			 public static string BirthDate = @"BirthDate";
			 public static string AreaCountry = @"Area_Country";
			 public static string AreaProvince = @"Area_Province";
			 public static string AreaCity = @"Area_City";
			 public static string Address = @"Address";
			 public static string PostCode = @"PostCode";
			 public static string Mobile = @"Mobile";
			 public static string Unit = @"Unit";
			 public static string UnitPhone = @"UnitPhone";
			 public static string HomePhone = @"HomePhone";
			 public static string Msn = @"MSN";
			 public static string Qq = @"QQ";
			 public static string HomePage = @"HomePage";
			 public static string ServiceForUs = @"ServiceForUs";
			 public static string Comment = @"Comment";
			 public static string IsPublicPersonalInfo = @"IsPublicPersonalInfo";
						
		}

		#endregion
	}

}


