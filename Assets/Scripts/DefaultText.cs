using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DefaultText : MonoBehaviour
{
    public TextMeshPro text;
    // Start is called before the first frame update
    
    void Start()
    {

        text.text = MainManager.userName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
