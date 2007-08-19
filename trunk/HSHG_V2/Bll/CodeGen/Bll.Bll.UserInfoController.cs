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
    /// Controller class for UserInfo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class UserInfoController
    {
        // Preload our schema..
        UserInfo thisSchemaLoad = new UserInfo();
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
        public UserInfoCollection FetchAll()
        {
            UserInfoCollection coll = new UserInfoCollection();
            Query qry = new Query(UserInfo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserInfoCollection FetchByID(object UserId)
        {
            UserInfoCollection coll = new UserInfoCollection().Where("UserId", UserId).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserInfoCollection FetchByQuery(Query qry)
        {
            UserInfoCollection coll = new UserInfoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object UserId)
        {
            return (UserInfo.Delete(UserId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object UserId)
        {
            return (UserInfo.Destroy(UserId) == 1);
        }

        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(Guid UserId,string TrueName,bool? Sex,string PId,DateTime? BirthDate,string AreaCountry,string AreaProvince,string AreaCity,string Address,string PostCode,string Mobile,string Unit,string UnitPhone,string HomePhone,string Msn,string Qq,string HomePage,string ServiceForUs,string Comment,bool? IsPublicPersonalInfo)
	    {
		    UserInfo item = new UserInfo();
		    
            item.UserId = UserId;
            
            item.TrueName = TrueName;
            
            item.Sex = Sex;
            
            item.PId = PId;
            
            item.BirthDate = BirthDate;
            
            item.AreaCountry = AreaCountry;
            
            item.AreaProvince = AreaProvince;
            
            item.AreaCity = AreaCity;
            
            item.Address = Address;
            
            item.PostCode = PostCode;
            
            item.Mobile = Mobile;
            
            item.Unit = Unit;
            
            item.UnitPhone = UnitPhone;
            
            item.HomePhone = HomePhone;
            
            item.Msn = Msn;
            
            item.Qq = Qq;
            
            item.HomePage = HomePage;
            
            item.ServiceForUs = ServiceForUs;
            
            item.Comment = Comment;
            
            item.IsPublicPersonalInfo = IsPublicPersonalInfo;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(Guid UserId,string TrueName,bool? Sex,string PId,DateTime? BirthDate,string AreaCountry,string AreaProvince,string AreaCity,string Address,string PostCode,string Mobile,string Unit,string UnitPhone,string HomePhone,string Msn,string Qq,string HomePage,string ServiceForUs,string Comment,bool? IsPublicPersonalInfo)
	    {
		    UserInfo item = new UserInfo();
		    
				item.UserId = UserId;
				
				item.TrueName = TrueName;
				
				item.Sex = Sex;
				
				item.PId = PId;
				
				item.BirthDate = BirthDate;
				
				item.AreaCountry = AreaCountry;
				
				item.AreaProvince = AreaProvince;
				
				item.AreaCity = AreaCity;
				
				item.Address = Address;
				
				item.PostCode = PostCode;
				
				item.Mobile = Mobile;
				
				item.Unit = Unit;
				
				item.UnitPhone = UnitPhone;
				
				item.HomePhone = HomePhone;
				
				item.Msn = Msn;
				
				item.Qq = Qq;
				
				item.HomePage = HomePage;
				
				item.ServiceForUs = ServiceForUs;
				
				item.Comment = Comment;
				
				item.IsPublicPersonalInfo = IsPublicPersonalInfo;
				
		    item.MarkOld();
		    item.Save(UserName);
	    }

    }

}


