
using System.Linq.Expressions;
using System.Linq;

namespace System.Web.Mvc.Html
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString EnumDropDownListFor<TModel, TEnum>
            (this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TEnum>> enumAccessor)
        {
            var propertyInfo = enumAccessor.ToPropertyInfo();
            var enumType = propertyInfo.PropertyType;
            var enumValues = Enum.GetValues(enumType).Cast<Enum>();
            var selectItems = enumValues.Select(x => new SelectListItem
            {
                Text = x.GetDescription(),
                Value = x.ToString()
            });
            return htmlHelper.DropDownListFor(enumAccessor, selectItems);
        }
    }
}

