using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : HealthView
{
    private Slider  _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Start()
    {
        _slider.maxValue = _health.Max;
        _slider.value = _health.Current;

        UpdateView();
    }

    protected override void UpdateView()
    {
        _slider.value = _health.Current;
    }
}