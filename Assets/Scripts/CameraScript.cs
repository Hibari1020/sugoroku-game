using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = _mainCamera.transform.position - _player.transform.position;

        this.UpdateAsObservable()
            .Subscribe(_ =>
            {
                _mainCamera.transform.position = pos + _player.transform.position;
            })
            .AddTo(this);
    }


}
