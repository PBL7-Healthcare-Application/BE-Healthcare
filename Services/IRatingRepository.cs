﻿using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IRatingRepository
    {
        ApiResponse CreateRating(Guid IdUser, RatingModel model);
    }
}
