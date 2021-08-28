using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlNawras.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Proj { get; set; }
        public string Location { get; set; }
        public string Facts { get; set; }
        public string Client { get; set; }
        public string CompletionPeriod { get; set; }
        public string Systems { get; set; }
        public string Img { get; set; }
        [NotMapped]
        public IFormFile FileName { get; set; }
    }
}
