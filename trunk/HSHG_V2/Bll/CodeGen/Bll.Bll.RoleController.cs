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
    /// Controller class for Role
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RoleController
    {
        // Preload our schema..
        Role thisSchemaLoad = new Role();
        private string userName = string.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}

					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}

				}

				return userName;
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public RoleCollection FetchAll()
        {
            RoleCollection coll = new RoleCollection();
            Query qry = new Query(Role.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RoleCollection FetchByID(object RoleId)
        {
            RoleCollection coll = new RoleCollection().Where("RoleId", RoleId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RoleCollection FetchByQuery(Query qry)
        {
            RoleCollection coll = new RoleCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object RoleId)
        {
            return (Role.Delete(RoleId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object RoleId)
        {
            return (Role.Destroy(RoleId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(Guid RoleId,string RoleName,string Comment)
	    {
		    Role item = new Role();
		    
            item.RoleId = RoleId;
            
            item.RoleName = RoleName;
            
            item.Comment = Comment;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(Guid RoleId,int Idx,string RoleName,string Comment)
	    {
		    Role item = new Role();
		    
				item.RoleId = RoleId;
				
				item.Idx = Idx;
				
				item.RoleName = RoleName;
				
				item.Comment = Comment;
				
		    item.MarkOld();
		    item.Save(UserName);
	    }

    }

}


