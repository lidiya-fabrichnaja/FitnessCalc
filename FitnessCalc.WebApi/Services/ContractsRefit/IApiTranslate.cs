using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.WebApi.Models;
using Refit;

namespace FitnessCalc.WebApi.Services.ContractsRefit
{
    public interface IApiTranslate
    {
        [Get("api/v1.5/tr.json/translate?key={apiKey}&text={text}&lang=en-ru")]
        Task<TranslateData> GetTranslateTextOnRu(string apiKey, string text);

        [Get("api/v1.5/tr.json/translate?key={apiKey}&text={text}&lang=ru-en")]
        Task<TranslateData> GetTranslateTextOnEn(string apiKey, string text);
    }
}