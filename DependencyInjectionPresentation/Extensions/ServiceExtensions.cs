using System;

namespace DependencyInjectionPresentation
{
    public static class ServiceExtensions
    {
        public static T Get<T>(this IServiceProvider serviceProvider)
        {
            return (T) serviceProvider.GetService(typeof(T));
        }
    }
}
