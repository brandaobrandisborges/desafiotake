using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Blip.Api.Template.Models;
using Blip.Api.Template.Models.Response;
using Blip.Api.Template.Models.Response.Repository;

using RestEase;

namespace Blip.Api.Template.Services
{
    public interface IRepositoriesServices {
        [Get("/users/takenet/repos")]
        [Header("User-Agent","brandaobrandisborges")]
        [AllowAnyStatusCode]
        Task<Response<IEnumerable<Repositories>>> GetRepositories(int per_page = Constants.LIMIT_API_GIT);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="per_page"></param>
        /// <returns></returns>
    }
}
