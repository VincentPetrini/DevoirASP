namespace Isen.Dotnet.Library.Model
{
    public class PersonRole : BaseEntity
    {
        public Person Person { get;set; }
        public int PersonId {get;set;}
        public Role Role {get;set;}
        public int RoleId {get;set;}
    }
}