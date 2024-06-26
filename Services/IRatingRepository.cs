﻿using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface IRatingRepository
    {
        Task<ApiResponse> CreateRating(Guid IdUser, CreateRatingModel model);
        ApiResponse GetRatingByIdDoctor(GetRatingCriteriaModel model);
    }
}
