using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_EDMS_Software.Models
{
    public class EDMSDataLayerAccess
    {
        EDMSDATABASEContext db = new EDMSDATABASEContext();
        public IEnumerable<TblUser> GetAllUsers()
        {
            try
            {
                return db.TblUser.ToList();
            }
            catch
            {
                throw;
            }
        }
        public int AddUser(TblUser user)
        {
            try
            {
                db.TblUser.Add(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        public int UpdateUser(TblUser user)
        {
            try
            {
                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
            

        }
        public Guid GetUser (Guid UserID)
        {
            try
            {
                TblUser user = db.TblUser.Find(UserID);
                return UserID;
            }
            catch
            {
                throw;

            }


        }

        public Guid DeleteUser(Guid UserID)
        {
            try
            {
                TblUser user = db.TblUser.Find(UserID);
                db.TblUser.Remove(user);
                db.SaveChanges();
                return UserID;
            }
            catch
            {
                throw;
            }
        }
        
    }


}
