﻿using Cobit_19.Data.Models;

namespace Cobit_19.Shared.Dtos
{
    public class DesignFactorDto
    {
        public int ID { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public virtual ICollection<QuestionDto> Questions { get; set; } = default!;
    }
}
