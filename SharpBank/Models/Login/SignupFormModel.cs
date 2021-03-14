using System;

namespace SharpBank.Models.Login
{
    public class SignupFormModel
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string cnp { get; set; }
        public string ci { get; set; }
    }
}
