using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatements : MonoBehaviour
{
        //this is about an octopus
    int octoage = 800;

    float octogpa = 3.6f;

    int octolegs = 8;

    public string octohappy = ("happy");

    bool octoevil = true;

    // Start is called before the first frame update
    void Start()
    {
        if (octoage >= 400)
        {
            Debug.Log ("how old is he?");
        }
        //gpa time
        if (octogpa <= 3.6)
        {
            Debug.Log ("Good job octo!");
        }
        else 
        {
            Debug.Log ("Octo boy is struggling ");
        }
        // how many legs does an octopus have?
        if (octolegs > 8)
        {
            Debug.Log ("octo boy what happened to your legs?");
        }
        else 
        {
            Debug.Log("good. you still have your legs");
        }
        //thats right! 8 :)
        if (octohappy == "sad")
        {
            Debug.Log("are you okay octo?");
        }
        else if (octohappy == "happy") 
        {
         Debug.Log (":)");
        } 
        // we're almost there :D
        if (octoevil == true)
        {
            Debug.Log("how dare you");
        }
        else
        {
            Debug.Log("is he really though?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
