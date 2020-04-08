﻿using System;

 namespace Infrastructure.Entities
{
    // TODO - all item should have a client, must be implemented with authentication
    /// <summary>
    /// Describes the household item the insurance customer
    /// wants to insure. 
    /// </summary>    
    public class HouseholdItem
    {
        public Guid Id { get; set; }
        
        /// <summary>
        /// Represents the name of the item
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Represents the item category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Represents the item cost of replacement
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Represent the item date added
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}