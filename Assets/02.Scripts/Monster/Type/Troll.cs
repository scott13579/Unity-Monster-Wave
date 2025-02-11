using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : Monster
{
    protected override void Init()
    {
        base.Init();
        
        hp = 10f;
        speed = 1f;
        isMove = true;
    }
}
