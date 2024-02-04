using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserManager
    {

        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            { 
                Console.WriteLine(user.FirstName + " added to the system.");
            }
            else
            {
                Console.WriteLine(user.FirstName + " can not added to the system.");
            }
        }

        public void Remove(User user)
        {
            Console.WriteLine(user.FirstName + " removed from the system.");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " updated.");
        }
    }
}
