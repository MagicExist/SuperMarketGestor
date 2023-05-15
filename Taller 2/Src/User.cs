using System;

namespace ClassUser
{
    public class User
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public string Id { get; set; }

        public string Rol { get; set; }

        public string Branch { get; set; }

        public User(string __id,string __userName, string __password,string __rol,string __branch) 
        {
            Id = __id;
            UserName = __userName;
            Password = __password;
            Rol = __rol;
            Branch = __branch;
        }

        
    }

    

}
