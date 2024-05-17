﻿using RateLimiter.Rules;
using RateLimiter.RuleTemplates;
using RateLimiter.RuleTemplates.Params;

namespace RateLimiter.Rules.Constructors
{
    internal class RequestByTimeSpanRuleConstructor : IRuleConstructor
    {
        public IRule Construct(RuleTemplateParams templateParams)
        {
            if (templateParams is not RequestByTimeSpanRuleTemplateParams validParams)
            {
                throw new InvalidTemplateParamsException();

            }
            return new RequestByTimeSpanRule(validParams.RequestLimit, validParams.TimeSpan);
        }
    }
}