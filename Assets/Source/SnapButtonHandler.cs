using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SnapButtonHandler : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private ButtonActions _buttonAction;
    
    [SerializeField, ShowIf("_buttonAction", ButtonActions.SwitchScene)] private string _sceneName;
    [SerializeField, ShowIf("_buttonAction", ButtonActions.InvokeAction)] private UnityEvent _event;

    public void OnPointerDown(PointerEventData eventData)
    {
        switch (_buttonAction)
        {
            case ButtonActions.SwitchScene:
                SceneSwitcher.Switch(_sceneName);
                break;
            case ButtonActions.QuitGame:
                Application.Quit();
                break;
            case ButtonActions.InvokeAction:
                _event?.Invoke();
                break;
            default:
                break;
        }
    }

    private enum ButtonActions
    {
        SwitchScene,
        QuitGame,
        InvokeAction
    }
}