using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayScript 
{
    void DicePlayerAction();
    int RandomNumber {get; set; }
}
