using TMPro;
using UnityEngine;
using IUnity;
using UnityEngine.UI;

public class TestSaves : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] Toggle useAutoSavesToggle;
    [SerializeField] string key = "NameSaver";

    void Start()
    {
        Load();
    }

    public void OnNameChanged()
    {
        if (useAutoSavesToggle.isOn) Save();
    }

    public void SetAutoSaves(bool value)
    {
        useAutoSavesToggle.isOn = value;

        if (useAutoSavesToggle.isOn) Save();
    }

    public void Save()
    {
        SaveManager.Save(key, GetSaveSnapshot());
    }

    public void Load()
    {
        var data = SaveManager.Load<TestSavesProfile>(key);

        nameInput.text = data.Name;
        useAutoSavesToggle.isOn = data.UseAutoSaves;
    }

    TestSavesProfile GetSaveSnapshot()
    {
        var data = new TestSavesProfile()
        {
            Name = nameInput.text,
            UseAutoSaves = useAutoSavesToggle.isOn
        };

        return data;
    }
}
