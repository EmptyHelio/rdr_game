using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartridgeSystem : MonoBehaviour
{
    public int cartridge;
    public int numberOfLives;

    public Image[] lives;

    public Sprite fullCartridge;
    public Sprite emptyCartridge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((cartridge > numberOfLives))
        {
            cartridge = numberOfLives;
        }


        for (int i = 0; i < lives.Length; i++)
        {
            if (i < cartridge)
            {
                lives[i].sprite = fullCartridge;
            }
            else
            {
                lives[i].sprite = emptyCartridge;
            }
            
            
            
            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
             
        }
        
    }


}
