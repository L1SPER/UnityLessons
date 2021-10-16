using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
   
    public void setCanvasActive()
    {
        pauseMenu.gameObject.SetActive(true);
    }
    public void setCanvasNotActive()
    {
        pauseMenu.gameObject.SetActive(false);
    }

}
