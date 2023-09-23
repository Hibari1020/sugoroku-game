using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameSetScript : MonoBehaviour, INameSetScript
{
    [SerializeField]
    private InputField _inputField;

    public void NameSet()
    {
       string _text = _inputField.text;
       UserLoginName.userName = _text;
    }

}
