using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlstate : MonoBehaviour

{
    public int player = 1;
    public bool p1_in = false;
    public bool p2_in = false; 
    public bool p3_in = false;
    public bool p4_in = false;
    public GameObject completeUI;
    public GameObject helpText;

    // Start is called before the first frame update
    void Start()
    { 
       
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(p1_in);
        if (p1_in && p2_in && p3_in && p4_in) 
        {
            helpText.SetActive(false);

            completeUI.SetActive(true);
        }
        if (Input.GetKey("1"))
        {
            player = 1;
        }
        if (Input.GetKey("2"))
        {
            player = 2;
        }
        if (Input.GetKey("3"))
        {
            player = 3;
        }
        if (Input.GetKey("4"))
        {
            player = 4;
        }
        Debug.Log(player.ToString());
    }
}
