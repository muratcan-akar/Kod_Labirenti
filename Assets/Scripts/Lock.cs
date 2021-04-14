using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    private Animator LockAnimator;
    private Key _Key;
    public float MyPositionVolueHorizontal, MyPositionVolueVertical;
    private UiManager Ui_Manager;
   




    private void Awake()
    {
        Ui_Manager = GameObject.FindGameObjectWithTag("UiManager").GetComponent<UiManager>();
        LockAnimator = this.gameObject.GetComponent<Animator>();
        _Key = GameObject.FindGameObjectWithTag("Anahtar").GetComponent<Key>();
    }

    //  Baslangicta kilidin X ve y degerlerini al 
    void Start()
    {
        MyPositionVolueHorizontal = this.gameObject.transform.localPosition.x;
        MyPositionVolueVertical = this.gameObject.transform.localPosition.y;

    }
    //oyuncu kilit üzerine tikladiginda
    private void OnMouseDown()
    {
        // Eger kilitdeki  degerler anahtardan gelen degerler ile ayni ise Oyunu bitir,animasyonlari oynat kazanma panalini ac.
        if (MyPositionVolueHorizontal == _Key.DeserdVolueHorizontal && MyPositionVolueVertical == _Key.DeserdVolueVertical)
        {
            Debug.Log(" OyunBitti");
           
            LockAnimator.SetBool("LockOpen", true);
            Ui_Manager.Invoke("OpenWinnerPanel", 1.8f);

        }
        else
        {
            Debug.Log("Yanlýs ýtem");
            

        }

    }

}