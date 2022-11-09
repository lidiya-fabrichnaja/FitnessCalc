using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FitnessCalc.WebApi.Models
{
    public class FoodData
    {
        [JsonPropertyName("totalHits")]
        public int TotalHits { get; set; }

        [JsonPropertyName("currentPage")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("pageList")]
        public List<int> PageList { get; set; }

        [JsonPropertyName("foodSearchCriteria")]
        public FoodSearchCriteria FoodSearchCriteria { get; set; }

        [JsonPropertyName("foods")]
        public List<Food> Foods { get; set; }

        [JsonPropertyName("aggregations")]
        public Aggregations Aggregations { get; set; }
        
    }

    public class FoodSearchCriteria
    {
        [JsonPropertyName("dataType")]
        public List<string> DataType { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("generalSearchInput")]
        public string GeneralSearchInput { get; set; }

        [JsonPropertyName("brandOwner")]
        public string BrandOwner { get; set; }

        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("sortBy")]
        public string SortBy { get; set; }

        [JsonPropertyName("sortOrder")]
        public string SortOrder { get; set; }

        [JsonPropertyName("numberOfResultsPerPage")]
        public int NumberOfResultsPerPage { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("requireAllWords")]
        public bool RequireAllWords { get; set; }

        [JsonPropertyName("foodTypes")]
        public List<string> FoodTypes { get; set; }
    }

    public class Food
    {
        [JsonPropertyName("fdcId")]
        public int FdcId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("lowercaseDescription")]
        public string LowercaseDescription { get; set; }

        [JsonPropertyName("dataType")]
        public string DataType { get; set; }

        [JsonPropertyName("gtinUpc")]
        public string GtinUpc { get; set; }

        [JsonPropertyName("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonPropertyName("brandOwner")]
        public string BrandOwner { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("ingredients")]
        public string Ingredients { get; set; }

        [JsonPropertyName("marketCountry")]
        public string MarketCountry { get; set; }

        [JsonPropertyName("foodCategory")]
        public string FoodCategory { get; set; }

        [JsonPropertyName("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonPropertyName("dataSource")]
        public string DataSource { get; set; }

        [JsonPropertyName("packageWeight")]
        public string PackageWeight { get; set; }

        [JsonPropertyName("servingSizeUnit")]
        public string ServingSizeUnit { get; set; }

        [JsonPropertyName("servingSize")]
        public double ServingSize { get; set; }

        [JsonPropertyName("householdServingFullText")]
        public string HouseholdServingFullText { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("tradeChannels")]
        public List<string> TradeChannels { get; set; }

        [JsonPropertyName("allHighlightFields")]
        public string AllHighlightFields { get; set; }

        [JsonPropertyName("score")]
        public double Score { get; set; }

        [JsonPropertyName("microbes")]
        public List<object> Microbes { get; set; }

        [JsonPropertyName("foodNutrients")]
        public List<FoodNutrient> FoodNutrients { get; set; }

        [JsonPropertyName("finalFoodInputFoods")]
        public List<object> FinalFoodInputFoods { get; set; }

        [JsonPropertyName("foodMeasures")]
        public List<object> FoodMeasures { get; set; }

        [JsonPropertyName("foodAttributes")]
        public List<object> FoodAttributes { get; set; }

        [JsonPropertyName("foodAttributeTypes")]
        public List<FoodAttributeType> FoodAttributeTypes { get; set; }

        [JsonPropertyName("foodVersionIds")]
        public List<object> FoodVersionIds { get; set; }
    }

    public class Aggregations
    {
        [JsonPropertyName("dataType")]
        public DataType DataType { get; set; }

        [JsonPropertyName("nutrients")]
        public Nutrients Nutrients { get; set; }
    }

    public class DataType
    {
        [JsonPropertyName("Branded")]
        public int Branded { get; set; }
    }
    public class Nutrients
    {
    }

    public class FoodAttribute
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class FoodAttributeType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("foodAttributes")]
        public List<FoodAttribute> FoodAttributes { get; set; }
    }

    public class FoodNutrient
    {
        [JsonPropertyName("nutrientId")]
        public int NutrientId { get; set; }

        [JsonPropertyName("nutrientName")]
        public string NutrientName { get; set; }

        [JsonPropertyName("nutrientNumber")]
        public string NutrientNumber { get; set; }

        [JsonPropertyName("unitName")]
        public string UnitName { get; set; }

        [JsonPropertyName("derivationCode")]
        public string DerivationCode { get; set; }

        [JsonPropertyName("derivationDescription")]
        public string DerivationDescription { get; set; }

        [JsonPropertyName("derivationId")]
        public int DerivationId { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("foodNutrientSourceId")]
        public int FoodNutrientSourceId { get; set; }

        [JsonPropertyName("foodNutrientSourceCode")]
        public string FoodNutrientSourceCode { get; set; }

        [JsonPropertyName("foodNutrientSourceDescription")]
        public string FoodNutrientSourceDescription { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("indentLevel")]
        public int IndentLevel { get; set; }

        [JsonPropertyName("foodNutrientId")]
        public int FoodNutrientId { get; set; }

        [JsonPropertyName("percentDailyValue")]
        public int PercentDailyValue { get; set; }
    }



  

}