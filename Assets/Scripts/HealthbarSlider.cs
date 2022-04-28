using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarSlider : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Slider slider;
    public int sliderAmount;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Score_manager").GetComponent<ScoreManager>();
        slider = GetComponentInChildren<Slider>();
        slider.minValue = 0;
        slider.maxValue = 2;
        slider.value = 0;
        sliderAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = sliderAmount;
    }

    public void GainHealth(int amount)
    {
        sliderAmount += amount;
        if(sliderAmount == 2)
        {
            scoreManager.IncreaseScore();
            Destroy(gameObject, 0.1f);
        }
    }
}
