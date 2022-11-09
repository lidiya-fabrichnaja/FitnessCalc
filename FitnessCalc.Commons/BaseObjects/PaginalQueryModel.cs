using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using FluentValidation;

namespace FitnessCalc.Commons.BaseObjects
{
    public class PaginalQueryModel 
    {
        [JsonPropertyName("page")]
        public int Page { get; set; } = 1 ;

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10 ;

    }

    public class PaginalQueryValidator : AbstractValidator<PaginalQueryModel>
    {
        public PaginalQueryValidator()
        {
            RuleFor(x => x.Page)
            .GreaterThan(0)
            .WithMessage("Page должен быть > 0");

            RuleFor(x => x.PageSize)
            .GreaterThan(0)
            .WithMessage("Pagesize должен быть > 0")
            .LessThanOrEqualTo(200)
            .WithMessage("Pagesize должен быть < 200");
        }
    }
}