using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC4.Infraestructure
{
    public class ConventionMetaDataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            var metadata = base.CreateMetadata(attributes, 
                containerType, modelAccessor, modelType, propertyName);

            if (metadata.DisplayName == null) 
            {
                var nombre = metadata.PropertyName.ToSeparatedWords();
                metadata.DisplayName = nombre;
            }

            return metadata;
        }
    }

    public static class StringExtensions
    {
        public static string ToSeparatedWords(this string value)
        {
            if (value != null)
                return Regex.Replace(value, "([A-Z][a-z]?)", " $1").Trim();
            return value;
        }
    }
}