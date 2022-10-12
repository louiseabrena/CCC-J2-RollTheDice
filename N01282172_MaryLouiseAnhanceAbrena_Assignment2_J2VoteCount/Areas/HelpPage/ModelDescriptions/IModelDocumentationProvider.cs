using System;
using System.Reflection;

namespace N01282172_MaryLouiseAnhanceAbrena_Assignment2_J2VoteCount.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}