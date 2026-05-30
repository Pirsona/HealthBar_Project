using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Slider))]
public abstract class SliderView : HealthView
{
    private protected Slider Slider;

    private void Awake()
    {
        Slider = GetComponent<Slider>();
    }

    protected virtual void Start()
    {
        Slider.maxValue = Health.Max;
        Slider.value = Health.Current;
    }
}