﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NextToMe.Database.Entities
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeleteAt { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
