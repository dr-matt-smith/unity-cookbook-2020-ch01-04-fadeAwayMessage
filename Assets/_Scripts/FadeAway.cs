using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CountdownTimer))]
public class FadeAway : MonoBehaviour
{
    private CountdownTimer countdownTimer;
    private Text textUI;

    void Awake()
    {
        textUI = GetComponent<Text>();
        countdownTimer = GetComponent<CountdownTimer>();
    }

    void Start()
    {
        countdownTimer.ResetTimer(5);
    }

    void Update()
    {
        float alphaRemaining =
        countdownTimer.GetProportionTimeRemaining();
        print(alphaRemaining);
        Color c = textUI.color;
        c.a = alphaRemaining;
        textUI.color = c;
    }
}