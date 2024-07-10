namespace CashFlow.Exception.ExceptionsBase;

public class ErrorOnValidationException: CashFlowException
{
    public List<string> Errors { get; set; }

    public ErrorOnValidationException(List<string> errorMessagess)
    {
        Errors = errorMessagess;
    }
}
