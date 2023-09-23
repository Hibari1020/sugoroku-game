using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ICubeAction
{
  Dictionary<Vector3, Action> CubeActionPairs {get; set; }
  void GetAction(Vector3 pos);
}
