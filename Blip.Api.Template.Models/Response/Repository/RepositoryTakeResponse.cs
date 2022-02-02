using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Blip.Api.Template.Models.Response.Repository
{
    public class RepositoryTakeResponse : BaseResponse {

        public IEnumerable<Repositories> Repositories { get; set; }


    }
}
