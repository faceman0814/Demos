using System.ComponentModel.DataAnnotations;

namespace FaceMan.EFTest
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
