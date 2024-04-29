﻿namespace BE_Healthcare.Models
{
    public class WorkingProcessModel
    {
        public int IdWorkingProcess { get; set; }
        public string Position { get; set; } = null!;
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Workplace { get; set; } = null!;

    }
}