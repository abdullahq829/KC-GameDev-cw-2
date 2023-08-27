using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroname = "chainsawman";
    int heropower = 200000;

    string villainname = "gundevil";
    int villainpower = 150000;
    float playerspeed = 1.6f;

    // Start is called before the first frame update
    void Start()
    {
        if (heropower >= villainpower)
        {
            print("heropower stronger than villainpower");
        }
        else if (heropower < villainpower)
        {
            print("villainpower stronger than heropower");
        }
        else
        {
            print("heropower = villainpower");
               
        }


        print(playerspeed);
        SetSpeed(2.5f);
              
              
         
    }
    void SetSpeed(float speed)
    {
        float playerspeed = 2.5f;
        playerspeed = speed;
        
    }
    


    // Update is called once per frame
    void Update()
    {

    }
}
