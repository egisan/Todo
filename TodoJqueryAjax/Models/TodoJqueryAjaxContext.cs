using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoJqueryAjax.Models
{
    public class TodoJqueryAjaxContext : DbContext
    {
       
        public TodoJqueryAjaxContext() : base("name=TodoJqueryAjaxContext")
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
