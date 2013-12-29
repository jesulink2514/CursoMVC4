using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC4.Infraestructure
{
    public class ShouldBeTrueAttribute : ValidationAttribute,IClientValidatable
    {
        public ShouldBeTrueAttribute()
            : base()
        {
            ErrorMessage = "'{0}' should be 'True'";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var result = ValidationResult.Success;

            var boolvalue = (bool)value;

            if (!boolvalue)
                result = new ValidationResult(String.Format(ErrorMessage, validationContext.DisplayName));
            

            return result;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = ErrorMessage;
            rule.ValidationType = "shouldbetrue";
            yield return rule;
        }
    }
}