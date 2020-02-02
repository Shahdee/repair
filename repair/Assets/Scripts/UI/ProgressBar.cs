using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour 
{
    private Slider progrBar;

    private void Awake() 
    {
        progrBar = GetComponent<Slider>();  
        EventManager.AddPlayerScoreChangeListener(UpdateProgressBar);
        UpdateProgressBar(0.5f);
    }

    private void UpdateProgressBar(float givenValue)
    {
        progrBar.value = givenValue;
    }

}   