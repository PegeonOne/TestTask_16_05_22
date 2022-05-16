using UnityEngine;

public class GameLogicModule : GameManager
{
    [SerializeField] ObjectPool Pool;
    [SerializeField] Transform PlaceHolder;
    [SerializeField] SceneModule SceneModule;
    private GameObject selectedCharacter;
    Save save = new Save();
    private int randomID;

    private void Start()
    {
        save = SaveSystem.LoadID();
        if(save == null)
        {
            save = new Save();
            SaveSystem.SaveID(save);
        }
        else
        {
            LoadGameObjectFromSave(save.SavedID);
        }
    }

    public void GenerateNewCharacter()
    {
        if (selectedCharacter)
        {
            Pool.BackObjToPool(randomID, selectedCharacter);
            selectedCharacter = null;
        }
        randomID = Random.Range(0, 16);
        save.SavedID = randomID;
        selectedCharacter = Pool.GetObjectFromPool(randomID, PlaceHolder);
    }
    void LoadGameObjectFromSave(int _ID)
    {
        randomID = _ID;
        selectedCharacter = Pool.GetObjectFromPool(randomID, PlaceHolder);
    }
    public void StartGame()
    {
        SaveSystem.SaveID(save);
        SceneModule.StartTheGame();
    }
    public void BackToMainMenu()
    {
        SceneModule.BackToMenu();
    }
}
