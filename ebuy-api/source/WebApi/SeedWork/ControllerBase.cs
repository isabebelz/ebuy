using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ebuy.WebApi.SeedWork
{
    [Authorize]
    [Route("api/v1/[controller]")]
    public abstract class ControllerBase : Controller
    {
        private readonly IMediator _mediator;

        protected ControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
