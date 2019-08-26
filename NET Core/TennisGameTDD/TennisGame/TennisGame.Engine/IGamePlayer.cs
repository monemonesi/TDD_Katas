namespace TennisGame.Library
{
    public interface IGamePlayer
    {
        int PlayerOneScore { get; set; }
        int PlayerTwoScore { get; set; }
        Players? GameWinner { get; }
        void PlayGame();
    }
}
