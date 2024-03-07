﻿namespace CustomInspector.Resolvers
{
    internal class ErrorValueResolver<T> : ValueResolver<T>
    {
        private readonly string _expression;

        public ErrorValueResolver(CustomPropertyDefinition propertyDefinition, string expression)
        {
            _expression = expression;
        }

        public override bool TryGetErrorString(out string error)
        {
            error = $"Method '{_expression}' not exists or has wrong signature";
            return true;
        }

        public override T GetValue(CustomProperty property, T defaultValue = default)
        {
            return defaultValue;
        }
    }
}