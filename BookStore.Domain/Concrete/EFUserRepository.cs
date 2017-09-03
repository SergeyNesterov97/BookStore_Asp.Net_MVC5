using System.Collections.Generic;
using BookStore.Domain.Entities;
using BookStore.Domain.Abstract;

namespace BookStore.Domain.Concrete
{
        public class EFUserRepository : IUserRepository
        {
            EFDbContext context = new EFDbContext();

            public IEnumerable<User> Users
            {
                get { return context.Users; }
            }

        public void SaveUser(User user)
        {
            if (user.UserId != 0)
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }


    }
}

