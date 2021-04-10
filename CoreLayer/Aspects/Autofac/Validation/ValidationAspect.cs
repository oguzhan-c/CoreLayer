using System;
using System.Linq;
using Castle.DynamicProxy;
using CoreLayer.CrossCuttingConcerns.Validation.FluentValidation;
using CoreLayer.Utilities.Interceptors;
using FluentValidation;

namespace CoreLayer.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception("Bu Bir Doğrulama Sınıfı Değildir!");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            if (!(_validatorType.BaseType is null))
            {
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
                foreach (var entity in entities)
                {
                    ValidationTool.Validate(validator, entity);
                }
            }
        }
    }
}
