using System.Text.Json.Serialization;

namespace Core6App.Core.DTOs
{
    public class NoContentDto
    {
        public List<String> Errors { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public static NoContentDto Success(int statusCode)
        {
            return new NoContentDto { StatusCode = statusCode};
        }
        public static NoContentDto Fail(int statusCode, List<string> errors)
        {
            return new NoContentDto { StatusCode = statusCode, Errors = errors };
        }
        public static NoContentDto Fail(int statusCode, string error)
        {
            return new NoContentDto { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
