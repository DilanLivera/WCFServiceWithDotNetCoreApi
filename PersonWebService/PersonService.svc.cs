
using PersonWebService.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace PersonWebService
{
    public class PersonService : IPersonService
    {
        public Response GetPerson(Request request)
        {
            try
            {

                List<Person> personList = new List<Person>
                {
                    new Person
                    {
                        FirstName = "First",
                        LastName = "Last"
                    }
                };

                List<Person> foundPersonList = personList.FindAll(p => p.FirstName == request.FirstName);

                if (foundPersonList.Count > 0)
                {
                    return new Response
                    {
                        ResponseMessage = "Success",
                        PersonList = foundPersonList
                    };
                }
                else
                {
                    return new Response
                    {
                        ResponseMessage = "Error. Couldnt find the person for a given first name."
                    };
                }
            }
            catch (FaultException fex)
            {
                throw fex;
            }
        }
    }
}
