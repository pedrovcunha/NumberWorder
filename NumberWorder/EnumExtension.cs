using System;
using System.ComponentModel;
using System.Reflection;

namespace NumberWorder
{
    public static class EnumExtension
    {
        public static string GetDescrition(this System.Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute description = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return description.Description;
        }
    }
}
