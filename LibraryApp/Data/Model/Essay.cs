﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LibraryApp.Data.Model
{
    public class Essay
    {
        [Key]
        public int EssayId { get; set; }

        public string? Question { get; set; }
        public string? AnswerType { get; set; }

        public int ExamId { get; set; }

        [JsonIgnore]
        public Exam Exam { get; set; }

    }
}
