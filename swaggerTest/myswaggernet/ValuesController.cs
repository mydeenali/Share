using System.Collections.Generic;
using System.Web.Http;

namespace OwinSelfhostSample.V1
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// To retrieve the values of elevator languages
        ///  </summary>
        /// <url>api/V1/webui/ElevatorLanguage</url>
        /// <response code="200" errorcode="200">Ok</response>
        /// <response code="500" errorcode="401">Internal server error</response>
        /// <response code="401" errorcode="5003">Authentication Failure</response>
        /// <remarks>
        ///     This API should be invoked as api/V1/webui/ElevatorLanguage
        /// </remarks>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Summary shahul
        /// </summary>
        /// <param name="id">input shahul</param>
        /// <returns>shahul</returns>
        /// <remarks>
        ///     This API should be invoked as api/V1/webui/ElevatorLanguage
        /// </remarks>
        /// <response code="200" errorcode="200">Ok</response>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }


        /// <summary>
        /// Get request to ping the SiPass server for maintaining the session. This method will retrieve Session Token from the 
        /// http request header and pass it to AuthenticationWrapper to validate the token in SiPass server.
        /// Returns a new runtime object with status property as "true" if session exist else return status as "false"
        /// </summary>
        /// <responseCodes>
        /// <url>/api/Authentication</url>
        /// <response code="200" errorcode="200">Ok</response>
        /// <response code="500" errorcode="401">Internal server error</response>
        /// <response code="500" errorcode="508">login validation failed due to not right time</response>
        /// <response code="500" errorcode="509">login validation failed due to expired operator account</response>
        /// </responseCodes>
        /// <remarks>
        ///      This API should be invoked as /api/Authentication
        /// </remarks>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}