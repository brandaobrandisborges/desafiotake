using System.Threading.Tasks;

using Blip.Api.Template.Facades.Interface;
using Blip.Api.Template.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blip.Api.Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController : ControllerBase
    {
        private readonly IRepositoryFacade _repositoryFacade;

        public RepositoryController(IRepositoryFacade repositoryFacade)
        {
            _repositoryFacade = repositoryFacade;
        }
        /// <summary>
        /// get repositories from Takenet @ github
        /// </summary>
        /// <returns></returns>
        [HttpGet("repository-order")]
        public async Task<IActionResult> GetRepositoriesAsync()
        {

            var result = await _repositoryFacade.GetResultObjectAsync(new Models.Request.BaseRequest(), Constants.REPOSITORY);
            return Ok(result);
        }
    }
}
