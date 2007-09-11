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
    /// Strongly-typed collection for the Syssegment class.
    /// </summary>
    [Serializable]
    public partial class SyssegmentCollection : ReadOnlyList<Syssegment, SyssegmentCollection>
    {        
        public SyssegmentCollection() {}

    }

    /// <summary>
    /// This is  Read-only wrapper class for the syssegments view.
    /// </summary>
    [Serializable]
    public partial class Syssegment : ReadOnlyRecord<Syssegment> 
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
                TableSchema.Table schema = new TableSchema.Table("syssegments", TableType.View, DataService.GetInstance("Bll"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = "dbo";
                //columns
                
                TableSchema.TableColumn colvarSegment = new TableSchema.TableColumn(schema);
                colvarSegment.ColumnName = "segment";
                colvarSegment.DataType = DbType.Int32;
                colvarSegment.MaxLength = 0;
                colvarSegment.AutoIncrement = false;
                colvarSegment.IsNullable = false;
                colvarSegment.IsPrimaryKey = false;
                colvarSegment.IsForeignKey = false;
                colvarSegment.IsReadOnly = false;
                
                schema.Columns.Add(colvarSegment);
                
                TableSchema.TableColumn colvarName = new TableSchema.TableColumn(schema);
                colvarName.ColumnName = "name";
                colvarName.DataType = DbType.String;
                colvarName.MaxLength = 10;
                colvarName.AutoIncrement = false;
                colvarName.IsNullable = false;
                colvarName.IsPrimaryKey = false;
                colvarName.IsForeignKey = false;
                colvarName.IsReadOnly = false;
                
                schema.Columns.Add(colvarName);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "status";
                colvarStatus.DataType = DbType.Int32;
                colvarStatus.MaxLength = 0;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = false;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Bll"].AddSchema("syssegments",schema);
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
	    public Syssegment()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }

        public Syssegment(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}

			MarkNew();
	    }

	    
	    public Syssegment(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }

    	 
	    public Syssegment(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }

        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Segment")]
        public int Segment 
	    {
		    get
		    {
			    return GetColumnValue<int>("segment");
		    }

            set 
		    {
			    SetColumnValue("segment", value);
            }

        }

	      
        [XmlAttribute("Name")]
        public string Name 
	    {
		    get
		    {
			    return GetColumnValue<string>("name");
		    }

            set 
		    {
			    SetColumnValue("name", value);
            }

        }

	      
        [XmlAttribute("Status")]
        public int Status 
	    {
		    get
		    {
			    return GetColumnValue<int>("status");
		    }

            set 
		    {
			    SetColumnValue("status", value);
            }

        }

	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Segment = @"segment";
            
            public static string Name = @"name";
            
            public static string Status = @"status";
            
	    }

	    #endregion
    }

}


