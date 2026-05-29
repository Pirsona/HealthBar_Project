using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Slider  _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Start()
    {
        _slider.maxValue = _health.Max;
        _slider.value = _health.Current;

        UpdateBar();
    }

    private void OnEnable()
    {
        _health.HealthChanged += UpdateBar;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateBar;
    }

    private void UpdateBar()
    {
        _slider.value = _health.Current;
    }
}