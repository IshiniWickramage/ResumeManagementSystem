﻿using ResumeManagementSystem.Core.Enums;

namespace ResumeManagementSystem.Core.Dtos.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }
}
