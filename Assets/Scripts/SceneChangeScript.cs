using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour, ISceneChangeScript
{
  public void SceneChange()
  {
     SceneManager.LoadScene("PlayScene");
  }
}
