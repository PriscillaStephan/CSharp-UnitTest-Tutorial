using System;
using System.Collections.Generic;
using System.Text;

namespace PSTestingCourse.FIndamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {

            //before refactoring 
            if (user.IsAdmin)
                return true;

            if (MadeBy == user)
                return true;

            return false;

            //after refactoring
            //return (user.IsAdmin || MadeBy == user);
        }
    
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
