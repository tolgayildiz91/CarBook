namespace CarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int aboutID)
        {
            AboutID = aboutID;
        }

        public int AboutID { get; set; }
    }
}
