using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public GameObject Pausemenu;

    public void PauseMenu()
    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }

        Pausemenu.SetActive(true);
    }


    public void resumemenu()
    {
        if (Time.timeScale == 0f    )
        {
            Time.timeScale = 1f;
        }

        Pausemenu.SetActive(false);
    }
}
