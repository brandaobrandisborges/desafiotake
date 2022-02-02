using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blip.Api.Template.Models;
using Blip.Api.Template.Models.Request;
using Blip.Api.Template.Models.Response;
using Blip.Api.Template.Models.Response.Repository;
using Blip.Api.Template.Services;

namespace Blip.Api.Template.Facades.Strategies.Repository
{
    public class RepositoryStrategy : StrategyFacade
    {
        private readonly IRepositoriesServices _service;

        public RepositoryStrategy(IRepositoriesServices service)
        {
            _service = service;
        }

        public override async Task<BaseResponse> SendResponseAsync(BaseRequest request)
        {
            using (var response = await _service.GetRepositories())
            {
                if (!response.ResponseMessage.IsSuccessStatusCode)
                {
                    return new BaseResponse();
                }
                var filter = new List<string>() { "C#" };
                return new RepositoryTakeResponse()
                {
                    Repositories = response.GetContent()
                                            .Where(language => language.Language as string == Constants.LANGUAGE_FILTER)
                                            .OrderBy(date => date.CreatedAt)
                                            .Take(5)

                };

            }
        }
    }
}
