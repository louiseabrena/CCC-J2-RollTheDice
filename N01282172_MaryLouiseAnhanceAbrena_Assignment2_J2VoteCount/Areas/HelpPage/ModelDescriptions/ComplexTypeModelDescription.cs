using System.Collections.ObjectModel;

namespace N01282172_MaryLouiseAnhanceAbrena_Assignment2_J2VoteCount.Areas.HelpPage.ModelDescriptions
{
    public class ComplexTypeModelDescription : ModelDescription
    {
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        public Collection<ParameterDescription> Properties { get; private set; }
    }
}