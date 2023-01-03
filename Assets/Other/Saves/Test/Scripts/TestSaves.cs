using UnityEngine;
using TMPro;
using IUnity;

public class TestSaves : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] string key = "NameSaver";

    void Start()
    {
        Load();
    }

    public void OnNameChanged()
    {
        Save();
    }

    public void Save()
    {
        SaveManager.Save(key, GetSaveSnapshot());
    }

    public void Load()
    {
        var data = SaveManager.Load<TestSavesProfile>(key);

        nameInput.SetTextWithoutNotify(data.Name);
    }

    TestSavesProfile GetSaveSnapshot()
    {
        var data = new TestSavesProfile()
        {
            Name = nameInput.text,
        };

        return data;
    }
}
