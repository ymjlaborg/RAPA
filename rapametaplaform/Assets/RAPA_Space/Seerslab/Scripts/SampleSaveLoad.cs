using TMPro;
using UnityEngine;
using MirrorTown.UPDS;

public class SampleSaveLoad : MonoBehaviour
{
    private TMP_InputField _inpSave;
    private void Awake()
    {
        _inpSave = GetComponentInChildren<TMP_InputField>();
    }

    private void Start()
    {
        CustomUI.handler += OnClickSampleButton;
        CustomUI.handler += OnClickSample2Button;
    }
    public void OnClickSampleButton(string key)
    {
        if (key == "sample")
        {
            Debug.Log("CustomButtonTest : " + key);
            CustomUI.SetActiveUICanvas(false);
        }
    }

    public void OnClickSample2Button(string key)
    {
        if (key == "sample2")
        {
            Debug.Log("CustomButtonTest : " + key);
            CustomUI.SetActiveUICanvas(true);
        }
    }

    public void OnClickSaveButton()
    {
        if (string.IsNullOrEmpty(_inpSave.text))
            return;

        SaveLoadManager.Save(_inpSave.text);
        Debug.Log("저장 완료");
    }

    public void OnClickLoadButton()
    {
        Debug.Log("로드된 문자열 : " + SaveLoadManager.LoadString());
    }

}
