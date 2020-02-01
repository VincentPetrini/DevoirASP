namespace Isen.Dotnet.Library.Model
{
    public class Role : BaseEntity
    {
        public string Name { get;set; }

        public MyCollection<PersonRole>PersonRoles{get;set;}
    }
}