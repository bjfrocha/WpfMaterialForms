﻿using System;
using System.Globalization;
using System.Windows.Data;
using MaterialForms.Wpf.Resources;

namespace MaterialForms.Wpf.Validation
{
    public class GreaterThanValidator : ComparisonValidator
    {
        public GreaterThanValidator(BindingProxy argument, StringProxy errorMessage) : base(argument, errorMessage)
        {
        }

        public GreaterThanValidator(BindingProxy argument, StringProxy errorMessage, IValueConverter valueConverter) : base(argument, errorMessage, valueConverter)
        {
        }

        protected override bool ValidateValue(object value, CultureInfo cultureInfo)
        {
            var comparand = Argument.Value;
            if (comparand == null)
            {
                return true;
            }

            if (value == null)
            {
                return false;
            }

            if (value is IComparable c)
            {
                return c.CompareTo(comparand) > 0;
            }

            return false;
        }
    }
}
