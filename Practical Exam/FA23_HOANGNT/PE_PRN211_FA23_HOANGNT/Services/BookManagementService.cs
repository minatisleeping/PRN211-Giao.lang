using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementService
    {
        //class này sẽ chơi với cả 2 bên
        //UI thì nó đưa data cho UI render show ra
        //or nó lấy data từ UI (user input vào)

        
        

        public BookManagementMember CheckLogin(string email, string pass)
        {
            BookManagementRepository repo = new();
            BookManagementMember acc = repo.GetMainRole(email);

            return acc != null && acc.Password == pass ? acc : null;
        }
    }
}
