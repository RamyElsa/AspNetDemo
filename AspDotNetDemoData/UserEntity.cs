using AspDotNetDemoCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetDemoData
{
    public class UserEntity : IDataHelper<User>
    {
        //  List<User> ListOfUser; // use this before database
        DBContext dB;
        private User user;
        public UserEntity()
        {
            // use this code Before DataBase use this code 
            /*
            ListOfUser = new List<User>();
            ListOfUser = new List<User>()
            {
                new User(){Id=1,FirstName="Kimo",LastName="Elsayed",Password="12345",
                    Email="Kimo@gmail.com",Bio=".Net Dev",PhoneNumber=1234567899},

                new User(){Id=2,FirstName="Ramy",LastName="Mohamed",Password="12345",
                    Email="Ramy@gmail.com",Bio=".Net Dev",PhoneNumber=9876543211},

                new User(){Id=3,FirstName="Panda",LastName="Ali",Password="12345",
                    Email="Panda@gmail.com",Bio=".Net Dev",PhoneNumber=6543298761},

                new User(){Id=4,FirstName="Mama",LastName="Samir",Password="12345",
                    Email="Mama@gmail.com",Bio=".Net Dev",PhoneNumber=2456881235},
            };
            */

            // use this code After DataBase  
            dB = new DBContext();

        }



        // Add Method
        public void Add(User table)
        {
          // ListOfUser.Add(user); // use in nom code
            dB.Users.Add(table);
            dB.SaveChanges();
        }


        // Delete Method
        public void Delete(int id)
        {
            user = Find(id);
           // ListOfUser.Remove(user); // use in nom code

            dB.Users.Remove(user); // use in database
            dB.SaveChanges(); // use in database
        }


        // Update Method 
        public void Edit(int id, User table)
        {
            // use this code Before DataBase use this code 
            /*
           user= Find(id);
            user = new User
            {
                Id=user.Id,
                FirstName= table.FirstName,
                LastName= table.LastName,
                Email= table.Email,
                Bio= table.Bio,
                Password= table.Password,
                PhoneNumber= table.PhoneNumber

            };
            var index = ListOfUser.FindIndex(x=>x.Id == id);
            ListOfUser[index] = user;
            */

            // use this code Before DataBase use this code 
            dB = new DBContext(); // use in database
            dB.Users.Update(table); // use in database
            dB.SaveChanges(); // use in database
        }

        // Find user by Id Method
        public User Find(int Id)
        {
            if(Id > 0)
            {
                // return ListOfUser.Where(x => x.Id == Id).First();

                // Use this in Database
                return dB.Users.Where(x => x.Id == Id).First();
            }
            else
            {
                return null;
            }
        }

        // Show Data Method
        public List<User> GetData()
        {
            //return ListOfUser;

            // Use this in Database
            return dB.Users.ToList();
        }

        // Search Method 
        public List<User> Search(string SearchItem)
        {
            /*
              return ListOfUser.Where(x=>x.Id.ToString()==SearchItem
            ||x.FirstName.Contains (SearchItem)
            ||x.LastName.Contains(SearchItem)
            || x.Email == SearchItem
            || x.Password.Contains(SearchItem)
            || x.Bio.Contains(SearchItem)
            || x.PhoneNumber.ToString() == SearchItem
            ).ToList();
             */


            // use this in database
            return dB.Users.Where(x=>x.Id.ToString()==SearchItem
            ||x.FirstName.Contains (SearchItem)
            ||x.LastName.Contains(SearchItem)
            || x.Email == SearchItem
            || x.Password.Contains(SearchItem)
            || x.Bio.Contains(SearchItem)
            || x.PhoneNumber.ToString() == SearchItem
            ).ToList();
        }
    }
}
