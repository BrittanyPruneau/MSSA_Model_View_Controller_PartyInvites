using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class FakeDb
    {
        // Fields

        private static GuestResponse[] responses = new GuestResponse[10];
        private static int responseCount = 0;

        // Constructors 

        // Methods 
        
        public static void AddResponse(GuestResponse response)
        {
            responses[responseCount] = response;
            responseCount++;
        }
        public static int GetResponseCount()
        {
            return responseCount; 
        }

        public static int GetAttendanceCount()
        {
            int result = 0; 
            for (int i=0; i< responses.Length; ++i)
            {
                if(responses[i] != null && responses[i].WillAttend == true) 
                {
                result++;
                }
          }
            return result; 
    }
        public static GuestResponse[] GetResponses()
        {
            return responses; 
        }

    }
}















