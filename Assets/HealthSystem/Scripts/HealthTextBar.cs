using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthTextBar : MonoBehaviour
{
    [SerializeField] private Health _health;

    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        UpdateText();
    }

    private void OnEnable()
    {
        _health.HealthChanged += UpdateText;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateText;
    }

    private void UpdateText()
    {
        _text.text = $"{_health.Current}/{_health.Max}";
    }
}