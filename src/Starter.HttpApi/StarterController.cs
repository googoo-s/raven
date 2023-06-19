using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Starter.HttpApi;

public abstract class StarterController : AbpControllerBase
{
    protected StarterController()
    {
    }
}