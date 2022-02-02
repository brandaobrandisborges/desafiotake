using System.Collections.Generic;
using System.Threading.Tasks;

using Blip.Api.Template.Facades.Interface;
using Blip.Api.Template.Facades.Strategies;
using Blip.Api.Template.Facades.Strategies.Repository;
using Blip.Api.Template.Models;
using Blip.Api.Template.Models.Request;
using Blip.Api.Template.Models.Response;
using Blip.Api.Template.Services;

namespace Blip.Api.Template.Facades
{
    public class RepositoryFacade : IRepositoryFacade
    {
        private readonly IRepositoriesServices _service;
        private readonly Dictionary<string, StrategyFacade> _strategies;

        public RepositoryFacade(IRepositoriesServices service)
        {
            _strategies = new Dictionary<string, StrategyFacade>();
            _service = service;

            InitiallizeStrategies();
        }

        private void InitiallizeStrategies()
        {
            _strategies.Add(Constants.REPOSITORY, new RepositoryStrategy(_service));
        }

        public async Task<BaseResponse> GetResultObjectAsync(BaseRequest request, string typeStrategy)
        {
            var strategy = _strategies[typeStrategy];
            return await strategy.SendResponseAsync(request);
            
        }
    }
}
