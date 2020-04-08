﻿using System;

 namespace Infrastructure.Entities
{
    /// <summary>
    /// Describes the category selected by an insurance consumer 
    /// </summary>
    public class Category
    {
        public Guid Id { get; set; }
        public CategoryType Type { get; set; }
    }
}