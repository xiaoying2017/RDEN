using System;
using System.Collections.Generic;

namespace mzxxzy.BLL.Account
{
    public class User
    {
        protected DAL.Account.User dal = new DAL.Account.User();

        public Model.user GetUserById(int id) => dal.GetUserById(id);

        public Model.user GetUserByName(string name) => dal.GetUserByName(name);

        public bool Login(string name, string pwd)
        {
            var usr = GetUserByName(name);
            if (usr == null) return false;
            if (usr.user_psw != pwd) return false;
            return true;
        }

        public List<Model.user> GetUserList(int pageIndex, int pageSize)
        {
            return dal.GetUserList(pageIndex, pageSize);
        }
    }
}
