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
    /// Controller class for User
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class UserController
    {
        // Preload our schema..
        User thisSchemaLoad = new User();
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
        public UserCollection FetchAll()
        {
            UserCollection coll = new UserCollection();
            Query qry = new Query(User.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserCollection FetchByID(object UserId)
        {
            UserCollection coll = new UserCollection().Where("UserId", UserId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserCollection FetchByQuery(Query qry)
        {
            UserCollection coll = new UserCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object UserId)
        {
            return (User.Delete(UserId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object UserId)
        {
            return (User.Destroy(UserId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(Guid UserId,string UserName,string Password,string Email,string EmailActiveCode,bool? IsMailValidate,bool? IsLocked,string PasswordResetCode,DateTime? CreateDate,DateTime? LastLoginDate,DateTime? LastPasswordChangedDate,DateTime? LastLockedDate,string Comment)
	    {
		    User item = new User();
		    
            item.UserId = UserId;
            
            item.UserName = UserName;
            
            item.Password = Password;
            
            item.Email = Email;
            
            item.EmailActiveCode = EmailActiveCode;
            
            item.IsMailValidate = IsMailValidate;
            
            item.IsLocked = IsLocked;
            
            item.PasswordResetCode = PasswordResetCode;
            
            item.CreateDate = CreateDate;
            
            item.LastLoginDate = LastLoginDate;
            
            item.LastPasswordChangedDate = LastPasswordChangedDate;
            
            item.LastLockedDate = LastLockedDate;
            
            item.Comment = Comment;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(Guid UserId,int Idx,string UserName,string Password,string Email,string EmailActiveCode,bool? IsMailValidate,bool? IsLocked,string PasswordResetCode,DateTime? CreateDate,DateTime? LastLoginDate,DateTime? LastPasswordChangedDate,DateTime? LastLockedDate,string Comment)
	    {
		    User item = new User();
		    
				item.UserId = UserId;
				
				item.Idx = Idx;
				
				item.UserName = UserName;
				
				item.Password = Password;
				
				item.Email = Email;
				
				item.EmailActiveCode = EmailActiveCode;
				
				item.IsMailValidate = IsMailValidate;
				
				item.IsLocked = IsLocked;
				
				item.PasswordResetCode = PasswordResetCode;
				
				item.CreateDate = CreateDate;
				
				item.LastLoginDate = LastLoginDate;
				
				item.LastPasswordChangedDate = LastPasswordChangedDate;
				
				item.LastLockedDate = LastLockedDate;
				
				item.Comment = Comment;
				
		    item.MarkOld();
		    item.Save(UserName);
	    }

    }

}


