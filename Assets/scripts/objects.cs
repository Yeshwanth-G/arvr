using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
    public GameObject dashboard;
    public void stove()
    {
        Application.OpenURL("https://www.amazon.com/s?k=stove&crid=23YNU7O2K8KC8&sprefix=sto%2Caps%2C434&ref=nb_sb_noss_2");
    }
    public void grinder()
    {
        Application.OpenURL("https://www.amazon.com/s?k=grinder&crid=227LL2AYDO9P4&sprefix=grinder%2Caps%2C627&ref=nb_sb_noss_1");
    }
    public void coffee()
    {
       Application.OpenURL("https://www.amazon.com/s?k=coffee+machine&crid=1UZQHN5WVMFS6&sprefix=coffee+machi%2Caps%2C429&ref=nb_sb_noss_2");
    }
    public void knives()
    {
        Application.OpenURL("https://www.amazon.com/s?k=knifes+set&crid=2WIQ69L7NMHS2&sprefix=knifes+set%2Caps%2C382&ref=nb_sb_noss_2");
    }
    public void shelf_decoratives()
    {
        Application.OpenURL("https://www.amazon.com/s?k=shelf+decoratives+items&crid=CBGOBGNPD1HF&sprefix=self+decorative+items%2Caps%2C427&ref=nb_sb_noss_1");
    }
    public void dishes()
    {
        Application.OpenURL("https://www.amazon.com/s?k=dishes&crid=11C9WLJ0B15MO&sprefix=dishes%2Caps%2C377&ref=nb_sb_noss_1");
    }
    public void kitchen_racks()
    {
        Application.OpenURL("https://www.ikea.com/in/en/search/products/?q=kitchen%20setup");
    }
    public void shirts()
    {
        Application.OpenURL("https://www.amazon.com/s?k=shirts&crid=U1C1042E72P5&sprefix=shirts%2Caps%2C279&ref=nb_sb_noss_1");
    }
    public void tshirts()
    {
        Application.OpenURL("https://www.amazon.com/s?k=tshirts&crid=1EX7MW4TGX6OL&sprefix=tshirts%2Caps%2C277&ref=nb_sb_noss_2");
    }
    public void books()
    {
        Application.OpenURL("https://www.amazon.com/s?k=books&i=stripbooks-intl-ship&crid=26JGBRMTU6UYM&sprefix=books%2Cstripbooks-intl-ship%2C281&ref=nb_sb_noss_2");
    }
    public void vases()
    {
        Application.OpenURL("https://www.ikea.com/in/en/search/products/?q=flower%20vase");
    }
    public void names()
    {
        if(dashboard.activeInHierarchy==true)
        {
            dashboard.SetActive(false);
        }else{
            dashboard.SetActive(true);
        }
    }
}

