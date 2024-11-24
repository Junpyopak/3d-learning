using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AIBase// : MonoBehaviour//유니티 에디터에서 메모리를 받아.
{
    protected Character Character;

    protected eAi AiState = eAi.eAI_CREATE;

    public void Init(Character _Character)
    {
        Character = _Character;
    }

    public void State()
    {
        switch (AiState)
        {
            case eAi.eAI_CREATE:
                Create();
                break;
            case eAi.eAI_SEARCH:
                Search();
                break;
            case eAi.eAI_MOVE:
                Move();
                break;
            case eAi.eAI_RESET:
                Reset();
                break;
        }
    }

    protected virtual void Create()
    {
        AiState = eAi.eAI_SEARCH;
    }
    protected virtual void Search()
    {
        AiState = eAi.eAI_MOVE;
    }
    protected virtual void Move()
    {
        AiState = eAi.eAI_SEARCH;
    }
    protected virtual void Reset()
    {
        AiState = eAi.eAI_SEARCH;
    }
}
