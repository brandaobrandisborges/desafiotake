using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Blip.Api.Template.Models.Request;
using Blip.Api.Template.Models.Response;

namespace Blip.Api.Template.Facades.Strategies
{
    public abstract class StrategyFacade
    {
        public abstract Task<BaseResponse> SendResponseAsync(BaseRequest request);
    }
}
