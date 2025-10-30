using UnityEngine;
using UnityEngine.UIElements;

public class ModelInspectorUI : MonoBehaviour
{
    private VisualElement _ui;
    private Button _parseButton;
    
    private void Awake()
    {
       _ui = GetComponent<UIDocument>().rootVisualElement;
    }

    private void OnEnable()
    {
        _parseButton = _ui.Q<Button>("ParseButton");
        _parseButton.clicked += OnParseButtonClicked;
    }

    private void OnParseButtonClicked()
    {
        Debug.Log("Parse Button Clicked");
    }
}
