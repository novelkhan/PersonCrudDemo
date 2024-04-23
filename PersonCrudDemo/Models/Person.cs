using System.ComponentModel.DataAnnotations;

namespace PersonCrudDemo.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public string City { get; set; }
    }
}
