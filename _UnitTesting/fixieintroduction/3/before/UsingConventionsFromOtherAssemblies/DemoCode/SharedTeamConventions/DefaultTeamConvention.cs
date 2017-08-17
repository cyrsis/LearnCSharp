using Fixie;

namespace SharedTeamConventions
{
    public class DefaultTeamConvention : Convention
    {
        public DefaultTeamConvention()
        {
            Classes.NameEndsWith("Checks");

            Methods.Where(method => method.IsPublic || method.IsAsync());           
        }
    }         
}
