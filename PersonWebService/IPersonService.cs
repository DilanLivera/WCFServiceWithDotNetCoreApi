
using PersonWebService.Models;
using System.ServiceModel;

namespace PersonWebService
{
    /*
        If you remove XmlSerializerFormat(Style = OperationFormatStyle.Rpc, Use = OperationFormatUse.Encoded then everything works fine.
        The weirdest thing is the exception thrown for this says The operation 'GetPerson' could not be loaded because it specifies \"rpc-style\" in \"literal\" mode, 
        but uses message contract types or the System.ServiceModel.Channels.Message. :(
     */
    [ServiceContract(Name = "IPersonService"), XmlSerializerFormat(Style = OperationFormatStyle.Rpc, Use = OperationFormatUse.Encoded)] 
    public interface IPersonService
    {
        [OperationContract]
        Response GetPerson(Request reques);
    }
}
