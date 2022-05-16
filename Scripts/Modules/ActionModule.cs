using UnityEngine;
using UnityEngine.Events;

public class ActionModule : GameManager
{
    public UnityAction GenerateNewCharacter;
    public UnityAction StartGame;
    public UnityAction BackToMainMenu;
    [SerializeField] GameLogicModule gameLogic;

    public void Init()
    {
        GenerateNewCharacter += gameLogic.GenerateNewCharacter;
        StartGame += gameLogic.StartGame;
        BackToMainMenu += gameLogic.BackToMainMenu;
    }
    private void Awake()
    {
        Init();
    }
}
