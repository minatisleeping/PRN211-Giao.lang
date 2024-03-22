using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{

    public class UserAccRepository
    {
        // lại phải nhờ vả DbContext
        private HoangNgocTrinhContext _context;

        //viết hàm trả về 1 acc theo email; k theo password vì mình
        //muốn chửi chi tiết từng case
        //? có thể == null nếu ko tìm thấy email trong đám user

        public UserAccount? GetAccount(string email)
        {
            // LINQ, delegate, Lambda
            //.where() trả về nhiều
            //.select() trả về nhiều
            //.FirstOrDefault trả về duy nhất 1 hoặc null
            _context = new();
            return _context.UserAccounts.FirstOrDefault(a => a.Email == email);
        }
    }
}
