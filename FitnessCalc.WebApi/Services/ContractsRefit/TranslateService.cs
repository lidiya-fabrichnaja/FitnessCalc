using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Commons.Options;
using FitnessCalc.WebApi.Models;
using Microsoft.Extensions.Options;

namespace FitnessCalc.WebApi.Services.ContractsRefit
{
    public class TranslateService
    {
        readonly IYandexTranslate _apiTranslate;
        List<ApiKey> keys;

        public TranslateService(IYandexTranslate apiTranslate, IOptions<ApiSettings> apiSettings)
        {
            _apiTranslate = apiTranslate;
            keys = apiSettings.Value.ApiKeys;   
        }

        public async Task<object> GetTranslatedTextOnRu(string text)
        {
            string key = keys[0].Value;
            var response = await _apiTranslate.GetTranslateTextOnRu(key,text);
            if(response.code == 200)
                    return response.text;

            return String.Empty;
        }


    }
}