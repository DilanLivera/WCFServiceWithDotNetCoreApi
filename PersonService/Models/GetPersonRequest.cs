using System.ServiceModel;

namespace PersonService.Models
{
    [MessageContract]
    public class GetPersonRequest
    {
        [MessageBodyMember]
        public string FirstName { get; set; }
    }
}