﻿using Sixeyed.Core.Serialization;

namespace Sixeyed.Core.Extensions
{
    /// <summary>
    /// Extensions to <see cref="ISerializer"/>
    /// </summary>
    public static class ISerializerExtensions
    {
        public static T Deserialize<T>(this ISerializer serializer, object serializedValue) where T : class
        {
            return serializer.Deserialize(typeof(T), serializedValue) as T;
        }
    }
}
