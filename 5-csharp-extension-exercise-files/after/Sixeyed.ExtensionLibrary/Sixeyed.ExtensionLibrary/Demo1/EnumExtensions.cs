using System.ComponentModel;
using System.Linq;

namespace System
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum enumValue)
        {
            return Enum.GetName(enumValue.GetType(), enumValue);
        }

        public static string GetDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.GetName());
            var descriptionAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute == null ? enumValue.GetName() : descriptionAttribute.Description;
        }
    }
}
