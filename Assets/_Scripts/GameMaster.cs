using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public void TakaisinAlkuun()
    {
        SceneManager.LoadScene("Level01");

    }

    public void LopetetaanPeli()
    {
        Application.Quit();
    }
}
