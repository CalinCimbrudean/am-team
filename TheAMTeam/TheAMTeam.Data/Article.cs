//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheAMTeam.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public System.DateTime PublishedDate { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public Nullable<int> Category { get; set; }
    
        public virtual Category Category1 { get; set; }
    }
}