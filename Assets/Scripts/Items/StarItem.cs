using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarItem : MonoBehaviour
{
    private Animator ItemAnimator;
    private Key _Key;
    public float MyPositionVolueHorizontal, MyPositionVolueVertical;
    private SpriteRenderer Sprite_Renderer;


    private void Awake()
    {
        Sprite_Renderer = this.gameObject.GetComponent<SpriteRenderer>();
        ItemAnimator = this.gameObject.GetComponentInChildren<Animator>();
        _Key = GameObject.FindGameObjectWithTag("Anahtar").GetComponent<Key>();
    }
    //  Baslangicta itemin X ve y degerlerini al 
    void Start()
    {
        MyPositionVolueHorizontal = this.gameObject.transform.localPosition.x;
        MyPositionVolueVertical = this.gameObject.transform.localPosition.y;
    }
   
    //oyuncu item Üzerine tikladiginda

    private void OnMouseDown()
    {
        // Eger itemdeki  degerler anahtardan gelen degerler ile ayni ise anahtar degerini yatayda arttýr sagdaki itemin degerine gitsin ve animasyonlarini oynat,  itemi soldur

        if (MyPositionVolueHorizontal == _Key.DeserdVolueHorizontal && MyPositionVolueVertical == _Key.DeserdVolueVertical)
        {
            Debug.Log("Dogru Item");
            _Key.DeserdVolueHorizontal = _Key.DeserdVolueHorizontal + 1.5f;
            ItemAnimator.SetBool("OpenHeart", true);
            Sprite_Renderer.color = new Color(255, 255, 255, .5f);


        }
        //Eger degil ise, yanlis bastigini gösteren animasyon calissin

        else
        {
            Debug.Log("Yanlýs ýtem");
            ItemAnimator.SetTrigger("BoomOpen");

        }

    }

}