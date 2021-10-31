using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    [Header("Level Select")]
    public int level = 0;

    void Start()
    {
        LevelStateMachine(level);
        
    }

    void LevelStateMachine(int level_value)
    {

        switch (level)
        {
            case 0:
                //do code
                break;
        }
        level = level_value;
    }

}
