﻿using System;
using System.Collections.Generic;

namespace YelpMe.Domain.Models;

public partial class Template 
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public bool HtmlMode { get; set; }
}
