using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : BaseManager
{

    // Now it is possible to use the protected variable from
    // the father (BaseManager)
    public override string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public override void Initialize()
    {
        _state = "Manager Inicializado";
        Debug.Log(_state);
    }

}
