﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webpet.Models;

namespace Webpet.data
{
    public class pet_image
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }
        public string ContentType { get; set; }

        //public virtual AnimalName Animal_Name { get; set; }
    }
}