using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private float timerFloat;
    [Header("Level Select")]
    public int level = 0;

    [Header("Objects")]
    public Text timer;

    void Start()
    {
        
        LevelStateMachine(level);
        
    }
    private void Update()
    {
        timerFloat = Time.time;
        timer.text = "score: "; Mathf.Round(timerFloat).ToString();
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
