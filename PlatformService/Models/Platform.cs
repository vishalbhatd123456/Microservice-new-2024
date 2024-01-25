// this is an internal 

using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        //this can have a loads and loads of the code
        [Key]
        public int Id{get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Publisher{get;set;}
        [Required]
        public string Cost{get;set;}

        //platform will have different views from their context
        //the decorator/ attribute is used to provide declarative info to  program's elements
        
    }
}