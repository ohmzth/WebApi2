using System.ComponentModel.DataAnnotations;

namespace WebApi2.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string score { get; set; }
        public DateTime Created { get; set; }



    }
    
}
