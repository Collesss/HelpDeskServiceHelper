namespace HelpDeskServiceHelper.HelpDeskHttpClient.Interfaces
{
    public interface IHelpDeskHttpClient
    {
        public Task GetCITypeDetails(string nameCIType, CancellationToken cancellationToken = default);
    }
}
