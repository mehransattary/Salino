using Salino.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SalinoMvc5.SalinoUtilities
{
    public class Authentication : RoleProvider
    {
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (SalinoContext db = new SalinoContext())
            {



                var result = (from u in db.users
                              join r in db.roles
                              on u.RoleId equals r.Id
                              where u.Mobile == username
                              select r.RoleName).ToArray();
                //Array result = db.users
                //   .Join(db.roles,
                //        u => u.RoleId,
                //        r => r.Id,
                //        (u, r) => new { u, r })
                //   .Where(x => x.u.Roles.RoleName == username)

                //   .Select(x => new { x.r.RoleName }).ToArray();
                return result;

            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}