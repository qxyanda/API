using Visitor.Actions;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public class Visitor
    {
        public void SignIn(Person person)
        {}
        public void SignUp(Person person)
        {
            Sign.SignUp(person);
        }

    }
}
