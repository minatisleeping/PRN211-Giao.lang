using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccService
    {
        private UserAccRepository _repo = new();

        public UserAccount CheckLogin(string email, string password)
        {
            // hàm này trả về acc tử tế nếu đúng cả user và pass
            //Account(Admin, xxx, 1);
            //Account(Staff, xxx, 2);
            //Account(Member, xxx, 3);

            // hàm trả null khi sai cả user và pass - k có email trong system
            //              đúng user sai pass
            // Account(__, __, -1)
            UserAccount acc = _repo.GetAccount(email);
            // acc có thể null vì k tìm tháy email or != vì tìm thấy email

            if (acc == null) return null; // k có email

            if (acc.Password == password) return acc;

            // k đúng pass
            return new UserAccount() { Role = -1 }; // tạo fake acc role 0
        }
    }
}
