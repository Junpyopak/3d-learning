using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cha //상속을 쓰려면 순수 가상클래스//abstract무조건 자식들이 구현해라
{
    protected int Hp;

    protected abstract void SetHp();
}

