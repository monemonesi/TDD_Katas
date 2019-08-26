namespace TennisGame.Engine
{
    public interface IPlayPoint
    {
        int Point { get; }

        int AssignNextPoint();
    }
}