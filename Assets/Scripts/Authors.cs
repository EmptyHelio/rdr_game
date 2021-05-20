using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Authors : MonoBehaviour
{
    public Text authors;

    public void Created()
    {
        authors.text = "Creared by Shalaiev Nikolai";
    }
}
