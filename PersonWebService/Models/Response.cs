
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace PersonWebService.Models
{
    [MessageContract(WrapperName = "GetPersonResponse")]
    public class Response
    {
        [MessageBodyMember]
        [Required]
        public string ResponseMessage { get; set; }

        [MessageBodyMember]
        public List<Person> PersonList { get; set; }

    }
}