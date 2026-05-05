using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int limitFPS = 60;

    private void Start()
    {
        Application.targetFrameRate = limitFPS;
    }
}
