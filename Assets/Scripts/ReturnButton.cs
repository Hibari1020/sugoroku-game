using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    [SerializeField]
    private Button _returnButton;

    // Start is called before the first frame update
    void Start()
    {
        _returnButton.onClick.AddListener(Return);
    }

    private void Return()
    {
       SceneManager.LoadScene("TitleScene");
    }
}
