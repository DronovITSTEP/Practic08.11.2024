﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Practic08._11._2024
{
    internal class ArithmeticConverter : IValueConverter
    {
        private const string ArithmeticParseExpression = "([+\\-*//]{1,1})\\s{0,}(-?[\\d\\.]+)";
        private Regex arithmeticRegex = new Regex(ArithmeticParseExpression);

        public object Convert(object value, Type targetType, object parameter, 
            System.Globalization.CultureInfo culture)
        {
            if (value is double && parameter != null)
            {
                string param = parameter.ToString();
                if (param.Length > 0)
                {
                    Match match = arithmeticRegex.Match(param);
                    if (match != null && match.Groups.Count == 3)
                    {
                        string operation = match.Groups[1].Value.Trim();
                        string numericValue = match.Groups[2].Value;

                        double number = 0;
                        if (double.TryParse(numericValue, out number))
                        {
                            double valueAsDouble = (double)value;
                            double returnValue = 0;

                            switch (operation)
                            {
                                case "+":
                                    returnValue = valueAsDouble + number;
                                    break;
                                case "-":
                                    returnValue = valueAsDouble - number;
                                    break;
                                case "*":
                                    returnValue = valueAsDouble * number;
                                    break;
                                case "/":
                                    returnValue = valueAsDouble / number;
                                    break;
                            }
                            return returnValue;
                        }
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new Exception("Error");
        }
    }
}
