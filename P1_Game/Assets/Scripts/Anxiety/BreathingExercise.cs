using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BreathingExercise : MonoBehaviour
{

    public static Image circleSlider;
    public static GameObject Player;
    public static int sliderDirection = 10;
    public static int increm = 0;

    void Start()
    {
        circleSlider = GameObject.Find("Breathing").GetComponent<Image>();
        circleSlider.fillAmount = 0f;
        Player = GameObject.FindWithTag("Player");


    }

    void Update()
    {
        if (sliderDirection < 10)
        {
            breathing();
        }

    }

    public static void breathing()
    {
        increm++;
        if (sliderDirection == 0)
        {
            Time.timeScale = 0f;
            waitingForCircle();
            sliderDirection = 1;
            Player.SetActive(false);
        }
        if (sliderDirection == 1 && circleSlider.fillAmount < 1f)
        {
            circleSlider.fillAmount += 0.008f;

        }
        if (increm == 180)
        {
            sliderDirection = 2;

        }
        if (sliderDirection == 2)
        {
            circleSlider.fillAmount -= 0.012f;

        }
        if (circleSlider.fillAmount < 0.001f)
        {
            sliderDirection = 10;
            increm = 0;
            Player.SetActive(true);
            Time.timeScale = 1f;


        }

    }



    public static IEnumerator waitingForCircle()
    {
        yield return new WaitForSeconds(3f);
    }
}
