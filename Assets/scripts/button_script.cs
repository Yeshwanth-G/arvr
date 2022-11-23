using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_script : MonoBehaviour
{
    public GameObject gameobject,gameobjectbeambag,gameobjectfan;
    public GameObject gameobject1,gameobjectdesktopdesk;
    public GameObject gameobjecttv,gameobjectseatingtable;
    public GameObject gameobjecttvdesk,gameobjectsofaset,gameobjectchandlier;
    public GameObject gameobjectdiningtable,gameobjectteapie,gameobjectbed;
    public string s,beambag,desktopdesk,sofaset,bed,chandlier,fan;
    public string s1,tv,tvdesk,diningtable,seatingtable,teapie;
    public void onClick_fridge()
    {
        if(gameobject.activeInHierarchy==true)
        {
            gameobject.SetActive(false);
        }else{
            gameobject.SetActive(true);
        }
    }
     public void onClick_chandlier()
    {
        if(gameobjectchandlier.activeInHierarchy==true)
        {
            gameobjectchandlier.SetActive(false);
        }else{
            gameobjectchandlier.SetActive(true);
        }
    }
    public void onClick_bookRack()
    {
        if(gameobject1.activeInHierarchy==true)
        {
            gameobject1.SetActive(false);
        }else{
            gameobject1.SetActive(true);
        }
    }
    public void onClick_tv()
    {
        if(gameobjecttv.activeInHierarchy==true)
        {
            gameobjecttv.SetActive(false);
        }else{
            gameobjecttv.SetActive(true);
        }
    }
    public void onClick_diningtable()
    {
        if(gameobjectdiningtable.activeInHierarchy==true)
        {
            gameobjectdiningtable.SetActive(false);
        }else{
            gameobjectdiningtable.SetActive(true);
        }
    }
     public void onClick_tvdesk()
    {
        if(gameobjecttvdesk.activeInHierarchy==true)
        {
            gameobjecttvdesk.SetActive(false);
        }else{
            gameobjecttvdesk.SetActive(true);
        }
    }
    public void onClick_seatingtable()
    {
        if(gameobjectseatingtable.activeInHierarchy==true)
        {
            gameobjectseatingtable.SetActive(false);
        }
        else{
            gameobjectseatingtable.SetActive(true);
        }
    }
    public void onClick_bed()
    {
        if(gameobjectbed.activeInHierarchy==true)
        {
            gameobjectbed.SetActive(false);
        }
        else{
            gameobjectbed.SetActive(true);
        }
    }
     public void onClick_teapie()
    {
        if(gameobjectteapie.activeInHierarchy==true)
        {
            gameobjectteapie.SetActive(false);
        }
        else{
            gameobjectteapie.SetActive(true);
        }
    }
    public void onclick_beambag()
    {
        if(gameobjectbeambag.activeInHierarchy==true)
        {
            gameobjectbeambag.SetActive(false);
        }
        else
        {
            gameobjectbeambag.SetActive(true);
        }
    }
    public void onclick_desktopdesk()
    {
        if(gameobjectdesktopdesk.activeInHierarchy==true)
        {
            gameobjectdesktopdesk.SetActive(false);
        }
        else
        {
            gameobjectdesktopdesk.SetActive(true);
        }
    }
    public void onclick_sofaset()
    {
        if(gameobjectsofaset.activeInHierarchy==true)
        {
            gameobjectsofaset.SetActive(false);
        }
        else
        {
            gameobjectsofaset.SetActive(true);
        }
    }
    public void onclick_fan()
    {
        if(gameobjectfan.activeInHierarchy==true)
        {
            gameobjectfan.SetActive(false);
        }
        else
        {
            gameobjectfan.SetActive(true);
        }
    }
    public void onclick_DesktopDesk()
    {
        Application.OpenURL(desktopdesk);
    }
    public void onclick_Bed()
    {
        Application.OpenURL(bed);
    }
    public void onclick_SofaSet()
    {
        Application.OpenURL(sofaset);
    }
    public void onclick_BeamBag()
    {
        Application.OpenURL(beambag);
    }
    public void onClick_SeatingTable()
    {
        Application.OpenURL(seatingtable);
    }
    public void onClick_Chandlier()
    {
        Application.OpenURL(chandlier);
    }
    public void onClick_Fan()
    {
        Application.OpenURL(fan);
    }
     public void onClick_TeaPie()
    {
        Application.OpenURL(teapie);
    }
    public void onclick_cube()
    {
        Application.OpenURL(s);
    }
    public void onclick_DiningTable()
    {
        Application.OpenURL(diningtable);
    }
    public void onclick_TVDesk()
    {
        Application.OpenURL(tvdesk);
    }
    public void onclick_TV()
    {
        Application.OpenURL(tv);
    }
    public void onclick_bookrack()
    {
        Application.OpenURL(s1);
    }
    public void rice_cooker()
    {
        Application.OpenURL("https://www.amazon.com/s?k=ricecookers&crid=1SLKI0KCCR8J1&sprefix=ricecooker%2Caps%2C347&ref=nb_sb_noss_2");
    }
}
