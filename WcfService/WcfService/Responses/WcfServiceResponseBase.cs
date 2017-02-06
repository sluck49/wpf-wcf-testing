namespace WcfService.Responses
{
    public abstract class WcfServiceResponseBase
    {
        public bool IsSuccess { get; set; }
        public string FailureReason { get; set; }
    }
}