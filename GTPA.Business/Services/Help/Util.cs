using System.Reflection;

namespace GTPA.Business.Services.Help
{
    public static class Util
    {
        public static string DelimitarPropiedadesObjeto(object obj, string delimitador)
        {
            var properties = obj.GetType().GetProperties()
                .ToList()
                .Where(p => !p.GetCustomAttributes(false).Any(a => a.GetType().Name.Equals("NotMappedAttribute")))  //no considerar lo mapeado
                .ToList();

            var valores = properties.Select(p => p.GetValue(obj)?.ToString() ?? string.Empty);
            return string.Join(delimitador, valores);
        }

        public static List<string> DelimitarListaPropiedadesObjeto<T>(IEnumerable<T> objs, string delimitador)
        {
            Type type = typeof(T);
            var properties = type.GetProperties()
                .ToList()
                .Where(p => !p.GetCustomAttributes(false).Any(a => a.GetType().Name.Equals("NotMappedAttribute")))
                .ToList();

            var resultados = objs.Select(obj =>
            {
                var valores = properties.Select(p => p.GetValue(obj)?.ToString() ?? string.Empty);
                return string.Join(delimitador, valores);
            }).ToList();

            return resultados;
        }
    }
}
