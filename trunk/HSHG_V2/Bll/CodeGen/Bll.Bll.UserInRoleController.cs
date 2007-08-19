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
    /// Controller class for UserInRole
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class UserInRoleController
    {
        // Preload our schema..
        UserInRole thisSchemaLoad = new UserInRole();
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
        public UserInRoleCollection FetchAll()
        {
            UserInRoleCollection coll = new UserInRoleCollection();
            Query qry = new Query(UserInRole.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserInRoleCollection FetchByID(object UserId)
        {
            UserInRoleCollection coll = new UserInRoleCollection().Where("UserId", UserId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserInRoleCollection FetchByQuery(Query qry)
        {
            UserInRoleCollection coll = new UserInRoleCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object UserId)
        {
            return (UserInRole.Delete(UserId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object UserId)
        {
            return (UserInRole.Destroy(UserId) == 1);
        }

        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(Guid UserId,Guid RoleId)
        {
            Query qry = new Query(UserInRole.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("UserId", UserId).AND("RoleId", RoleId);
            qry.Execute();
            return (true);
        }
        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(Guid UserId,Guid RoleId)
	    {
		    UserInRole item = new UserInRole();
		    
            item.UserId = UserId;
            
            item.RoleId = RoleId;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(Guid UserId,Guid RoleId)
	    {
		    UserInRole item = new UserInRole();
		    
				item.UserId = UserId;
				
				item.RoleId = RoleId;
				
		    item.MarkOld();
		    item.Save(UserName);
	    }

    }

}


