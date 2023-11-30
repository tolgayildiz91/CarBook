namespace CarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public RemoveBannerCommand(int bannerID)
        {
            BannerID = bannerID;
        }

        public int BannerID { get; set; }
    }
}
