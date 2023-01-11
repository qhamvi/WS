using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Application.TopicService.Dtos;

namespace WS.Application.TopicService.Validator
{
    public class TopicCreateRequestValidator : AbstractValidator<TopicCreateRequest>
    {
        public TopicCreateRequestValidator()
        {
            RuleFor(v => v.NameTopic).NotEmpty().WithMessage("NameTopic not null");
            RuleFor(v => v.NameTopic).Length(10).WithMessage("NameTopic must be length equal 10");
        }
    }
}
