using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;
using CoreLayer.Aspects.Autofac.Performance;

namespace CoreLayer.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {

            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            classAttributes.Add(new PerformanceAspect(5)); // tüm metotlara bakar ve eğer 5 sn yi geçiyorsa bize bildirir

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
