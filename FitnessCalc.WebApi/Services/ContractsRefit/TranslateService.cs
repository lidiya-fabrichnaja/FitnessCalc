using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.Commons.Options;
using Microsoft.Extensions.Options;

namespace FitnessCalc.WebApi.Services.ContractsRefit
{
    public class TranslateService
    {
        readonly IApiTranslate _apiTranslate;
        List<ApiKey> keys;

        public TranslateService(IApiTranslate apiTranslate, IOptions<ApiSettings> apiSettings)
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
            
        }


    }
}