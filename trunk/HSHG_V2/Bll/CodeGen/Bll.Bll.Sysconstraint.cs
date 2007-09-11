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

namespace Hshg.Bll.SystemManage{
    /// <summary>
    /// Strongly-typed collection for the Sysconstraint class.
    /// </summary>
    [Serializable]
    public partial class SysconstraintCollection : ReadOnlyList<Sysconstraint, SysconstraintCollection>
    {        
        public SysconstraintCollection() {}

    }

    /// <summary>
    /// This is  Read-only wrapper class for the sysconstraints view.
    /// </summary>
    [Serializable]
    public partial class Sysconstraint : ReadOnlyRecord<Sysconstraint> 
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }

	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }

                return BaseSchema;
            }

        }

    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("sysconstraints", TableType.View, DataService.GetInstance("Bll"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = "dbo";
                //columns
                
                TableSchema.TableColumn colvarConstid = new TableSchema.TableColumn(schema);
                colvarConstid.ColumnName = "constid";
                colvarConstid.DataType = DbType.Int32;
                colvarConstid.MaxLength = 0;
                colvarConstid.AutoIncrement = false;
                colvarConstid.IsNullable = true;
                colvarConstid.IsPrimaryKey = false;
                colvarConstid.IsForeignKey = false;
                colvarConstid.IsReadOnly = false;
                
                schema.Columns.Add(colvarConstid);
                
                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "id";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = true;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                
                schema.Columns.Add(colvarId);
                
                TableSchema.TableColumn colvarColid = new TableSchema.TableColumn(schema);
                colvarColid.ColumnName = "colid";
                colvarColid.DataType = DbType.Int16;
                colvarColid.MaxLength = 0;
                colvarColid.AutoIncrement = false;
                colvarColid.IsNullable = true;
                colvarColid.IsPrimaryKey = false;
                colvarColid.IsForeignKey = false;
                colvarColid.IsReadOnly = false;
                
                schema.Columns.Add(colvarColid);
                
                TableSchema.TableColumn colvarSpare1 = new TableSchema.TableColumn(schema);
                colvarSpare1.ColumnName = "spare1";
                colvarSpare1.DataType = DbType.Byte;
                colvarSpare1.MaxLength = 0;
                colvarSpare1.AutoIncrement = false;
                colvarSpare1.IsNullable = true;
                colvarSpare1.IsPrimaryKey = false;
                colvarSpare1.IsForeignKey = false;
                colvarSpare1.IsReadOnly = false;
                
                schema.Columns.Add(colvarSpare1);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Int32;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                TableSchema.TableColumn colvarActions = new TableSchema.TableColumn(schema);
                colvarActions.ColumnName = "actions";
                colvarActions.DataType = DbType.Int32;
                colvarActions.MaxLength = 0;
                colvarActions.AutoIncrement = false;
                colvarActions.IsNullable = true;
                colvarActions.IsPrimaryKey = false;
                colvarActions.IsForeignKey = false;
                colvarActions.IsReadOnly = false;
                
                schema.Columns.Add(colvarActions);
                
                TableSchema.TableColumn colvarErrorX = new TableSchema.TableColumn(schema);
                colvarErrorX.ColumnName = "error";
                colvarErrorX.DataType = DbType.Int32;
                colvarErrorX.MaxLength = 0;
                colvarErrorX.AutoIncrement = false;
                colvarErrorX.IsNullable = true;
                colvarErrorX.IsPrimaryKey = false;
                colvarErrorX.IsForeignKey = false;
                colvarErrorX.IsReadOnly = false;
                
                schema.Columns.Add(colvarErrorX);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Bll"].AddSchema("sysconstraints",schema);
            }

        }

        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }

	    #endregion
	    
	    #region .ctors
	    public Sysconstraint()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }

        public Sysconstraint(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}

			MarkNew();
	    }

	    
	    public Sysconstraint(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }

    	 
	    public Sysconstraint(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }

        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Constid")]
        public int? Constid 
	    {
		    get
		    {
			    return GetColumnValue<int?>("constid");
		    }

            set 
		    {
			    SetColumnValue("constid", value);
            }

        }

	      
        [XmlAttribute("Id")]
        public int? Id 
	    {
		    get
		    {
			    return GetColumnValue<int?>("id");
		    }

            set 
		    {
			    SetColumnValue("id", value);
            }

        }

	      
        [XmlAttribute("Colid")]
        public short? Colid 
	    {
		    get
		    {
			    return GetColumnValue<short?>("colid");
		    }

            set 
		    {
			    SetColumnValue("colid", value);
            }

        }

	      
        [XmlAttribute("Spare1")]
        public byte? Spare1 
	    {
		    get
		    {
			    return GetColumnValue<byte?>("spare1");
		    }

            set 
		    {
			    SetColumnValue("spare1", value);
            }

        }

	      
        [XmlAttribute("Status")]
        public int? Status 
	    {
		    get
		    {
			    return GetColumnValue<int?>("status");
		    }

            set 
		    {
			    SetColumnValue("status", value);
            }

        }

	      
        [XmlAttribute("Actions")]
        public int? Actions 
	    {
		    get
		    {
			    return GetColumnValue<int?>("actions");
		    }

            set 
		    {
			    SetColumnValue("actions", value);
            }

        }

	      
        [XmlAttribute("ErrorX")]
        public int? ErrorX 
	    {
		    get
		    {
			    return GetColumnValue<int?>("error");
		    }

            set 
		    {
			    SetColumnValue("error", value);
            }

        }

	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Constid = @"constid";
            
            public static string Id = @"id";
            
            public static string Colid = @"colid";
            
            public static string Spare1 = @"spare1";
            
            public static string Status = @"status";
            
            public static string Actions = @"actions";
            
            public static string ErrorX = @"error";
            
	    }

	    #endregion
    }

}


