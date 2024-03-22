using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookManagementRepository
    {
        // các hàm CRUD  của table Member/Account
        // thằng repo bao giờ cũng chơi với CSDL
        // hàm trả về 1 acc nào đó theo username/email - duy nhất
        // do acc thì email/user là duy nhất
        public BookManagementMember? GetMainRole(string email)
        {
            BookManagement2023DbContext context = new();
            return context.BookManagementMembers.FirstOrDefault(a => a.Email == email); // lấy 1 thằng(cụ thể là admin)
        }
    }
}
