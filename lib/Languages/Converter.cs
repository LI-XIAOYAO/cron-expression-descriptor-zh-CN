using CronExpressionDescriptor.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CronExpressionDescriptor.Languages
{
    static class Converter
    {
        /// <summary>
        /// To <see cref="Language"/> enum.
        /// </summary>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static Language To(this CultureInfo cultureInfo)
        {
            if (!Enum.TryParse(cultureInfo.Name.Replace("-", "_"), true, out Language language))
            {
                throw new CultureNotFoundException($" Cast {cultureInfo.Name} to enum Language Error .");
            }

            return language;
        }
    }
}
