namespace Pandorax.Loqate.Models.Common;

public class ApiResponseBase<T>
{
    public List<T> Items { get; set; } = [];
}
