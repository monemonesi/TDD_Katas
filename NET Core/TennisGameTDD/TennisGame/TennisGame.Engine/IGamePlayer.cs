namespace TennisGame.Library
{
    public interface IGamePlayer
    {
        Players? GameWinner { get; }
        void PlayGame();
    }
}