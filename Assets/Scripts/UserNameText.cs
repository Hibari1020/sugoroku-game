using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class UserNameText : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        var userNameText = GetComponent<TextMesh>();
        userNameText.text = UserLoginName.userName;

        Vector3 pos = transform.position - _player.transform.position;

        this.UpdateAsObservable()
            .Subscribe(_ => 
            {
                transform.position = pos + _player.transform.position;
            })
            .AddTo(this);
    }

}
