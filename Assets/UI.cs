using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;

    private SaveData data = new SaveData();
    private void Start()
    {
        data = SaveLoad.Load();
        ResetText();
    }
    
    public void SaveInputText()
    {
        data.text = inputField.text;
        inputField.text = "";
        ResetText();
        SaveLoad.Save(data);

    }
    private void ResetText() => text.text = data.text;
}