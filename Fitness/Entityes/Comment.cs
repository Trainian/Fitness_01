using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Entityes
{
    public class Comment
    {
        public int Id {get;set;}
        public int BlogId {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        public string? Phone {get;set;}
        public string CommentText {get;set;}
        public bool Show {get;set;}
        public bool IsVerified {get;set;}
    }
}