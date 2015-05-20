using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DiExample
{
    public class IOCContainer
    {
        private readonly Dictionary<Type, Type> _dependencyMap = new Dictionary<Type, Type>();


        public void Register<Tfrom, TTo>()
        {
            _dependencyMap.Add(typeof(Tfrom), typeof(TTo));
        }

        private Type LookUpDependency(Type type)
        {
            return _dependencyMap[type];
        }

        private IEnumerable<object> ResolveParameters(IEnumerable<ParameterInfo> parameters)
        {
            return parameters.Select(p => Resolve(p.ParameterType)).ToList();
        }
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        public object Resolve(Type type)
        {
            Type resolveType = LookUpDependency(type);

            ConstructorInfo constructor = resolveType.GetConstructors().First();

            ParameterInfo[] parameters = constructor.GetParameters();

            if (!parameters.Any())
            {
                return Activator.CreateInstance(resolveType);
            }
            else
            {
                return constructor.Invoke(ResolveParameters(parameters).ToArray());
            }


        }
    }
}
