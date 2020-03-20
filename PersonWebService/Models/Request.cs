
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace PersonWebService.Models
{
    [MessageContract(WrapperName = "GetPerson")]
    public class Request
    {
        [MessageBodyMember]
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
    }
}