namespace SharelyTodoList.Contracts.ErrorDetail;

public class ErrorDetail
{
    public int StatusCode { get; set; }
    public string Message { get; set; }

    public ErrorDetail()
    {
        Message = string.Empty;
    }
}