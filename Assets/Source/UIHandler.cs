using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text _food;

    private void OnEnable()
    {
        EventBus.OnFoodChanged += UpdateFoodText;
    }

    private void OnDisable()
    {
        EventBus.OnFoodChanged -= UpdateFoodText;
    }

    private void UpdateFoodText(int value)
    {
        _food.text = value.ToString();
    }
}
