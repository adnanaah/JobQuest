using Microsoft.AspNetCore.Mvc;
namespace SeminarskiRad_JobQuest.Helper;
    
[ApiController]
public abstract class MyBaseEndpoint<TRequest, TResponse> : ControllerBase
{
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}

