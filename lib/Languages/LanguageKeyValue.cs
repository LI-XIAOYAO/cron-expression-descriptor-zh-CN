using System.Collections.Generic;
using System.Reflection;

namespace CronExpressionDescriptor.Languages
{
    internal class LanguageKeyValue<T>
       where T : class
    {
        public static Dictionary<string, string> LanguageKeyValues { get; }

        static LanguageKeyValue()
        {
            LanguageKeyValues = new Dictionary<string, string>();

            var enumerator = typeof(T).GetRuntimeFields().GetEnumerator();
            while (enumerator.MoveNext())
            {
                LanguageKeyValues.Add(enumerator.Current.Name, enumerator.Current.GetValue(null).ToString());
            }
        }
    }
}
