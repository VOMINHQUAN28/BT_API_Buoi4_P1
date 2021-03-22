using System;
using System.Reflection;

namespace _5951071083_Vo_Minh_Quan.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}