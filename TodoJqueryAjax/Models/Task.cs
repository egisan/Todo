﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoJqueryAjax.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}