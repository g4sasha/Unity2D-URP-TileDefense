using System.Threading.Tasks;
using UnityEngine;

public class FoodTimer
{
    private int _interval;

    public FoodTimer(int interval_ms)
    {
        _interval = interval_ms;
    }

    private async void StartCycle()
    {
        while (Application.isPlaying)
        {
            await Task.Delay(_interval);
        }
    }
}
