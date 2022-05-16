using UnityEngine;

public abstract class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
}
