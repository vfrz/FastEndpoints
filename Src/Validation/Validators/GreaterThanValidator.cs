#region License
// Copyright (c) .NET Foundation and contributors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/FluentValidation/FluentValidation
#endregion

namespace FastEndpoints.Validation.Validators
{
    using System;
    using System.Reflection;

    public class GreaterThanValidator<T, TProperty> : AbstractComparisonValidator<T, TProperty> where TProperty : IComparable<TProperty>, IComparable
    {

        public override string Name => "GreaterThanValidator";

        public GreaterThanValidator(TProperty value) : base(value)
        {
        }

        public GreaterThanValidator(Func<T, TProperty> valueToCompareFunc, MemberInfo member, string memberDisplayName)
            : base(valueToCompareFunc, member, memberDisplayName)
        {
        }

        public GreaterThanValidator(Func<T, (bool HasValue, TProperty Value)> valueToCompareFunc, MemberInfo member, string memberDisplayName)
            : base(valueToCompareFunc, member, memberDisplayName)
        {
        }

        public override bool IsValid(TProperty value, TProperty valueToCompare)
        {
            if (valueToCompare == null)
                return false;

            return value.CompareTo(valueToCompare) > 0;
        }

        public override Comparison Comparison => Validators.Comparison.GreaterThan;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return Localized(errorCode, Name);
        }
    }
}
