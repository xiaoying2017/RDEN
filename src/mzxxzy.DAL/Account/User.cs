using System;
using System.Collections.Generic;
using System.Linq;

namespace mzxxzy.DAL.Account
{
    public class User
    {
        protected Model.RDENEntities db = new Model.RDENEntities();

        public Model.user GetUserById(int id)
        {
            if (id == default(int)) return null;
            return db.Set<Model.user>().FirstOrDefault(o => o.user_id == id);
        }

        public Model.user GetUserByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            return db.Set<Model.user>().FirstOrDefault(o => o.user_name == name);
        }

        public List<Model.user> GetUserList(int pageIndex, int pageSize = 10)
        {
            if (pageIndex <= 0) pageIndex = 1;
            var query = db.Set<Model.user>().Select(o => o);
            return query.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();
        }
    }
}
