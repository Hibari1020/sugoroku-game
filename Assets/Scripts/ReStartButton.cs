using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReStartButton : MonoBehaviour
{
    [SerializeField]
    private Button _restartButton;

    // Start is called before the first frame update
    void Start()
    {
      _restartButton.onClick.AddListener(ReStart);    
    }

    private void ReStart()
    {
        SceneManager.LoadScene("PlayScene");
    }

}
