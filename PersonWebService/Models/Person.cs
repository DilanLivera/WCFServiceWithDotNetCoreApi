
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace PersonWebService.Models
{
    [MessageContract]
    public class Person
    {
        [MessageBodyMember]
        [StringLength(50)]
        public string FirstName { get; set; }

        [MessageBodyMember]
        [StringLength(50)]
        public string LastName { get; set; }

    }
}