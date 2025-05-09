using System.ComponentModel.DataAnnotations;

namespace inventoryApi.Domain.Entities
{
    public class Users
    {
        [Key]
        public string UserId {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
    }
}