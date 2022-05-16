using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController
{
    private Button LogicButton;

    public ButtonController(Button _logicButton)
    {
        LogicButton = _logicButton;
    }
    public void SubscribeButtonToAction(UnityAction _action)
    {
        LogicButton.onClick.AddListener(_action);
    }
    public void UnsubscribeButtonAction()
    {
        LogicButton.onClick.RemoveAllListeners();
    }
}
