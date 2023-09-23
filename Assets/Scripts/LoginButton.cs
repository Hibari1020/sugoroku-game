using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LoginButton : MonoBehaviour
{
    [SerializeField]
    private Button _loginButton;

    [Inject]
    private INameSetScript _inameSet;

    [Inject]
    private ISceneChangeScript _isceneChange;

    // Start is called before the first frame update
    void Start()
    {
        _loginButton.onClick.AddListener(Login);
    }

    void Login()
    {
        _inameSet.NameSet();
        _isceneChange.SceneChange();
    }

}
