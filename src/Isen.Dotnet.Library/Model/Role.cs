using System.Text;

namespace Isen.Dotnet.Library.Model
{
    public class Role : BaseEntity
    {
        public string Name { get;set; }
        public override string ToString() => Name;

        public MyCollection<PersonRole>PersonRoles{get;set;}


        public string getPersons() {
            var personsString = new StringBuilder();
            personsString.Append($"{PersonRoles[0]?.Person?.FirstName} {PersonRoles[0]?.Person?.LastName}");
            for(var i=1; i<PersonRoles?.Count; i+=1)
            {
                personsString.Append(", ");
                personsString.Append($"{PersonRoles[i]?.Person?.FirstName} {PersonRoles[i]?.Person?.LastName}");
            }
            return personsString.ToString();
        }

    }
}