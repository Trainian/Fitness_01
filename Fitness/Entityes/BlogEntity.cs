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
        public string? BlogImages {get;set;}
        public string? BlogVideo {get;set;}
        public virtual BlogTagsEnum? BlogTags {get;set;}
        public virtual Comment? Comments {get;set;}
        public virtual BlogTitle? BlogTitles {get;set;}
    }
}