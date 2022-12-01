using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    public Ball ball;

    public void PlayerScore()
    {
        _playerScore++;
        Debug.Log(_playerScore);
        this.ball.ResetPosition();
        
    }

    public void computerScore()
    {
        _computerScore++;
        Debug.Log(_computerScore);
        this.ball.ResetPosition();
        
    }
}
