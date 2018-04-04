using System;
using System.Reflection;

namespace SassSQueMgmtDotNetMvcAngular4Sql.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}