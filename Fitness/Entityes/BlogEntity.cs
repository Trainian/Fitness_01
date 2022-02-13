using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Fitness.Entityes
{
    public class BlogEntity
    {
        public int Id {get;set;}
        public string BlogName {get;set;}
        public string CreaterName {get;set;}
        
        [DataType(DataType.Date)]
        public DateTime DateCreate {get;set;}
        public string BlogText {get;set;}
        public List<string>? BlogImages {get;set;}
        public List<BlogTagsEnum>? BlogTags {get;set;}
        public List<Comment>? Comments {get;set;}
        public List<BlogTitle>? BlogTitles {get;set;}
    }
}