using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

//自动添加中文注释
public class main : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI; //文本组件
    public TMP_InputField tmpInputField; //输入框组件

    void Start()
    {
        textMeshProUGUI.text = "Hello, World!"; //设置文本内容
        tmpInputField.text = "Enter text here"; //设置输入框内容
    }

    void Update() { }
}
