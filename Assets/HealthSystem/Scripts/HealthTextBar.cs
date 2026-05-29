using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthTextBar : HealthView
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        UpdateView();
    }

    protected override void UpdateView()
    {
        _text.text = $"{_health.Current}/{_health.Max}";
    }
}