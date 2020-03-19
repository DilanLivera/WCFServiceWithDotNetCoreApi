using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PersonService.Models
{
    [MessageContract]
    public class Person
    {
        [MessageBodyMember]
        public string FirstName { get; set; }

        [MessageBodyMember]
        public string LastName { get; set; }

    }
}