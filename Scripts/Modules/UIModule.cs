using UnityEngine;
using UnityEngine.UI;

public class UIModule : GameManager
{
    [SerializeField] Button GenerateButton;
    [SerializeField] Button StartButton;
    [SerializeField] Button BackButton;
    [SerializeField] ActionModule actions;

    public void Init()
    {
        if (GenerateButton) {
            ButtonController genButCtrler = CreateButtonController(GenerateButton);
            genButCtrler.SubscribeButtonToAction(actions.GenerateNewCharacter);
        }
        if (StartButton)
        {
            ButtonController startButCtrler = CreateButtonController(StartButton);
            startButCtrler.SubscribeButtonToAction(actions.StartGame);
        }
        if (BackButton)
        {
            ButtonController backButCtrler = CreateButtonController(BackButton);
            backButCtrler.SubscribeButtonToAction(actions.BackToMainMenu);
        }
    }

    ButtonController CreateButtonController(Button _button)
    {
        ButtonController newController = new ButtonController(_button);
        return newController;
    }
    private void Awake()
    {
        Init();
    }
}
