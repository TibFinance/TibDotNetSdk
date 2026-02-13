using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Tib.Api.Financial
{
  public class RequiredMutually : ValidationAttribute
  {
    private readonly string[] _properties1;
    private readonly string _propertie2;
    private const string _DefaultErrorMessage = "Must define the fields BankNumber and InstitutionNumber, or the RoutingNumber, but not both.";
    private const string _DefaultErrorMessage2 = "This(these) field(s) is/are required: {0}.";

    public RequiredMutually()
    {
      string properties1 = "BankNumber;InstitutionNumber";

      _properties1 = properties1.Split(';');

      _propertie2 = "_routingNumber";
      ErrorMessage = _DefaultErrorMessage;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      PropertyInfo propertyName = null;
      int count1 = 0, count2=0;
      foreach (string property in _properties1)
      {
        propertyName = validationContext.ObjectType.GetProperty(property);
        if (propertyName == null)
        {
          continue;
        }
        var propertyValue = propertyName.GetValue(validationContext.ObjectInstance);
        if (propertyValue != null)
        {
          count1++;
        }
      }

      propertyName = validationContext.ObjectType.GetProperty(_propertie2);
      if (propertyName != null)
      {
        var propertyValue = propertyName.GetValue(validationContext.ObjectInstance);
        if (propertyValue != null)
        {
          count2++;
        }
      }

      if((count1 != 0 && count2 != 0) || (count1 == 0 && count2 == 0))
      {
        return new ValidationResult(string.Format(_DefaultErrorMessage));
      }

      if(count1 != 0 && count1 != _properties1.Length)
      {
        return new ValidationResult(string.Format(_DefaultErrorMessage2, string.Join("|", _properties1)));
      }

      return ValidationResult.Success;
    }
  }
}
