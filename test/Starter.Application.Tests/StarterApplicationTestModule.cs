﻿using Starter.Domain;
using Volo.Abp.Modularity;

namespace Starter.Application;

[DependsOn(
    typeof(StarterApplicationModule),
    typeof(StarterDomainTestModule)
    )]
public class StarterApplicationTestModule : AbpModule
{
}
