using UnityEngine;
using UnityEngine.UI;

public class RadialTimer : MonoBehaviour 
{
    [SerializeField] private Image filledArea;
    [SerializeField] Transform objectToFollow; // set here progress bar's handle
    
    private void Awake()
    {
        EventManager.AddTimerChangeListener(SetTimer);
    }

    private void SetTimer(float givenValue)
    {
        filledArea.fillAmount = givenValue;
    }

    private void Update() 
    {
        transform.position = objectToFollow.position;    
    }
}