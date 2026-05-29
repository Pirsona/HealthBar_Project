using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSmoothBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _speed;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Start()
    {
        _slider.maxValue = _health.Max;
        _slider.value = _health.Current;
    }

    private void Update()
    {
        SmoothUpdateBar();
    }

    private void SmoothUpdateBar()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health.Current, _speed * Time.deltaTime);
    }
}