using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobGoblin : Monster
{
    protected override void Init()
    {
        base.Init();
        
        hp = 5f;
        speed = 3f;
        isMove = true;
    }
}
