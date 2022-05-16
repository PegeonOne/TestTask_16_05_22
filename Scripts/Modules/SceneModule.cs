using UnityEngine.SceneManagement;

public class SceneModule : GameManager
{
    enum Levels { MainMenu, GameLevele}
    public void StartTheGame()
    {
        SceneManager.LoadSceneAsync((int)Levels.GameLevele);
    }
    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync((int)Levels.MainMenu);
    }
}
