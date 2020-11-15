using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{

    public int x = 2;
    public int y = 3;


    // Start is called before the first frame update
    void Start()
    {

        addTwoNumbers();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void addTwoNumbers()
    {

        Debug.Log(x + y);

    }

}
