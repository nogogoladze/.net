using System;

    public class User
    {
        public int id {get; set;}
        public String firstName {get; set;}

        public String lastName {get; set;}

        public String mail {get; set;}

        public String password {get; set;}

        public override String ToString()
        {
        return                  
        "id" +  ",\t" + "firstName" + ",\t" + "lastName" +  ",\t" + "password" +  ",\t" + "mail" + "\n"+
        id +  ",\t" + firstName + ",\t" + lastName+  ",\t" + password +  ",\t" + mail + "\n";

        }
    }