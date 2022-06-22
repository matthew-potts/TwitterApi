using System;
using CoreTweet;
using Authorisation;

namespace TwitterAPI
{
    public class Program
    {
        public static void Main()
        {
            var details = GetAuthorised();
            var session = OAuth.Authorize(details.customer_key, details.customer_secret);

            Console.ReadLine();
        }

        public static Authorisation.Authorisation GetAuthorised()
        {
            return new Authorisation.Authorisation
            {
                customer_key = "58CjOPVH8fq2KanmdaPwCgWoy",
                customer_secret = "rzNrqz7mZLBzguvGIej0OWqgCc1VTP14yeuxUT5kkHE15R9pJO"
            };
        }

    }
}