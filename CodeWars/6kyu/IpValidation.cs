using System.Text.RegularExpressions;

namespace Solution
{
    class Kata
    {
        public static bool is_valid_IP(string IpAddres)
        {
            string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            //Regular Expression object    
            Regex check = new Regex(Pattern);

            //check to make sure an ip address was provided    
            if (string.IsNullOrEmpty(IpAddres))
                //returns false if IP is not provided    
                return false;
            else
                //Matching the pattern    
                return check.IsMatch(IpAddres, 0);
        }
    }
}