using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace BlazorTypes.Pages
{
    public partial class Index
    {
        private MarkupString typenamesMarkup;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var type1 = typeof(ClassLibrary1.Struct1);

            var typenames = string.Empty;
            var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            foreach (MemberInfo m in type1.GetMembers(flags))
            {
                typenames += $"{m}<br>";
            }
            typenamesMarkup = new MarkupString($"<p>{typenames}</p>");
        }
    }
}
