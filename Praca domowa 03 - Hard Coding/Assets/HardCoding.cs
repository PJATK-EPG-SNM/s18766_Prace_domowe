using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    void Start()
    {
         //ZADANIE1
        int a;
        int b;
        float c;
        //inicjalizacja
        a = 10;
        b = 20;
        c = 15.3f;

        //ZADANIE2
        bool d;
        bool e;
        //inicjalizacja 
        d=true;
        e=false;

        //ZADANIE3
        string f;
        string g;
        //inicjalizacja
        f="Programuję w C#";
        g="EPG";

        //ZADANIE4
        Debug.Log(" a: "+a+" b: "+b+" c: "+c+" d: "+d+" e: "+e+" f: "+f+" g: "+g);

        //ZADANIE5
        if(a == c){Debug.Log("Tak");}else{Debug.Log("Nie");};
        if(a != c){Debug.Log("Tak");}else{Debug.Log("Nie");};
        if(a > c){Debug.Log("Tak");}else{Debug.Log("Nie");};
        if(a >= c){Debug.Log("Tak");}else{Debug.Log("Nie");};
        if(a < c){Debug.Log("Tak");}else{Debug.Log("Nie");};
        if(a <= c){Debug.Log("Tak");}else{Debug.Log("Nie");};

        //ZADANIE6
        if(Equals (f, g)){Debug.Log("Takie same");}else{Debug.Log("Różne");};

        //ZADANIE7
        Koniunkcja();
        Alternatywa();
    }

        //ZADANIE8

    public void Alternatywa(){
    bool a=true, b=true, c=false, alt1,alt2,alt3;
    if(a || b){alt1=true;}else{alt1=false;}
    if(b || c){alt2=true;}else{alt2=false;}
    if(a || c){alt3=true;}else{alt3=false;}
    Debug.Log("Alternatywa: alt1: "+alt1+ " alt2: "+alt2+ " alt3: "+alt3);
	}
    
    public void Koniunkcja(){
    bool a=true, b=true, c=false, alt1,alt2,alt3;
    if(a && b){alt1=true;}else{alt1=false;}
    if(b && c){alt2=true;}else{alt2=false;}
    if(a && c){alt3=true;}else{alt3=false;}
    Debug.Log("Koniunkcja: alt1: "+alt1+ " alt2: "+alt2+ " alt3: "+alt3);
	}

    void Update()
    {
        
    }
}
