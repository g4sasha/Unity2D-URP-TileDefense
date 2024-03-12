using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    [SerializeField] private int _food;

    public int Food
    {
        get => _food;
        set 
        {
            _food = value;
            EventBus.OnFoodChanged.Invoke(value);
        }
    }
}
