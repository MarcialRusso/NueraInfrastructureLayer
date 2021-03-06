﻿﻿using System;

 namespace Infrastructure.Entities
{
    /// <summary>
    /// Represents a system user 
    /// </summary>
    public abstract class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}