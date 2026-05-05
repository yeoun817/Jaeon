using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int limitFPS = 30;

    private void Start()
    {
        Application.targetFrameRate = limitFPS;
    }
}
