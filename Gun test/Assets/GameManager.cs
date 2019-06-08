using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Score score;

    public void ExtraPoint()
    {
        score.score += 1;
    }

}
