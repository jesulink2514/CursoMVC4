using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC4.Infraestructure
{
    public class ShouldBeTrueAttribute:ValidationAttribute, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            var valorbooleano = (bool)value;
            return valorbooleano;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            string errorMessage = ErrorMessageString;

            var shouldBeTrueRule = new ModelClientValidationRule();
            shouldBeTrueRule.ErrorMessage = errorMessage;
            shouldBeTrueRule.ValidationType = "shouldbetrue"; 
            yield return shouldBeTrueRule;
        }
    }
}