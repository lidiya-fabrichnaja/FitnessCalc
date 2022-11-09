using System;
using System.Text.Json.Serialization;


namespace FitnessCalc.App.ViewModels
{
    public class BaseViewModel
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        /// <value></value>
        [JsonPropertyName("guid")]
        public Guid? ExtGuid { get; set; }
    }
}