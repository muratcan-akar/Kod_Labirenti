using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject WinnerPanel;
  //baslangicta Kazanma ekranini kapat
    void Start()
    {
        WinnerPanel.SetActive(false);
    }
    
    // kazanma ekranini ac

    public void OpenWinnerPanel()
    {
        WinnerPanel.SetActive(true);
    }
    //Oyunu yeniden baslat
    public void RestratButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
