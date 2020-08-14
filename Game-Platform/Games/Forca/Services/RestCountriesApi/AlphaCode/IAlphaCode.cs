﻿using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game_Platform.Games.Forca.Services.RestCountriesApi.AlphaCode
{
    public interface IAlphaCode
    {
        [Get("/rest/v2")]
        Task<List<AlphaCodeResponse>> GetAsyncAlphaCode();
    }
}
