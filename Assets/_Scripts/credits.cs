using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class credits : MonoBehaviour
{
    [SerializeField]
    public static int credit;
    public Text cretex;
    public Text negative;
    public Text positive;
    public Text bigWin;
    private float ntimer = 0;
    private float ptimer = 0;
    private float btimer = 0;

    private int num1;
    private int num2;
    private int num3;
    private float timer = 0;
    private int n1;
    private int n2;
    private int n3;
    private int creditInc;
    private int creditStay;
    private bool bigCheck;
    summonCoin sc;

    // Start is called before the first frame update
    void Start()
    {
        sc = GameObject.Find("summonCoin").GetComponent<summonCoin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == false)
        {
            cretex.text = "Credits: " + credit;
            
        }
        else
        {
            cretex.text = "Game Over!";
        }
        if (Input.GetMouseButtonDown(1) && timer < 0)
        {
            
            if (GameOver == false)
            {
                RandomGenerate();
                credit = credit - 1;
                CheckWin();
                negative.text = "-1";
                ntimer = 3;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && timer < 0)
        {
            
            if (GameOver == false)
            {

                TrueGenerate();
                credit = credit - 1;
                CheckWin();
                negative.text = "-1";
                ntimer = 3;
            }
        }
        if(credit <= 0 && timer < 0)
        {
            GameOver = true;
        }
    
        Hide.checkGameOver = GameOver;
        timer -= Time.deltaTime; 
        if(timer < 0)
        {
            RealSpin.stop = false;
            RealSpin2.stop = false;
            RealSpin3.stop = false;
            RealSpin.readyToStop = false;
            RealSpin2.readyToStop = false;
            RealSpin3.readyToStop = false;
        }
        ntimer -= Time.deltaTime;
        if(ntimer < 0)
        {
           negative.text = "";
        }
        if(creditInc > 0 && timer < 1)
        {
            credit = credit + creditInc;
            creditStay = creditInc;
            creditInc = 0;
            print(creditInc);
            ptimer = 3;
            if(ptimer > 0 && creditStay > 0)
            {
                positive.text = "+" + creditStay;
                sc.Summon(creditStay);
                if(bigCheck == true)
                {
                    bigWin.text = "BIG WIN!!";
                    bigCheck = false;
                    btimer = 4f;

                }
            }
          
        }
        ptimer -= Time.deltaTime;
        btimer -= Time.deltaTime;
       if(ptimer < 0)
        {
            positive.text = "";
        }
       if(btimer < 0)
        {
            bigWin.text = "";
        }
    }
    public static bool GameOver = false;

    public void RandomGenerate()
    {
        num1 = Random.Range(1, 10);
        RealSpin.rotation = 360 + 36 * num1;
        RealSpin.stop = true;
        
        num2 = Random.Range(1, 10);
        RealSpin2.rotation1 = 360 + 36 * num2;
        RealSpin2.stop = true;
        
        num3 = Random.Range(1, 10);
        RealSpin3.rotation3 = 360 + 36 * num3;
        RealSpin3.stop = true;
        timer = 5.5f;
        
        

    }
    public void TrueGenerate()
    {
        num1 = 5;
        RealSpin.rotation = 360 + 36 * num1;
        RealSpin.stop = true;

        num2 = 5;
        RealSpin2.rotation1 = 360 + 36 * num2;
        RealSpin2.stop = true;

        num3 = 5;
        RealSpin3.rotation3 = 360 + 36 * num3;
        RealSpin3.stop = true;
        timer = 5.5f;
    }
    void CheckWin()
    {
        if(num1 > 5)
        {
            n1 = num1 - 5;
        }
        else
        {
            n1 = num1;
        }
        if(num2 > 5)
        {
            n2 = num2 - 5;
        }
        else
        {
            n2 = num2;
        }
        if(num3 > 5)
        {
            n3 = num3 - 5;
        }
        else
        {
            n3 = num3;
        }
        if(n1 == n2 && n1 == n3)
        {
            Increase3(n1);
        }
        else if (n1 == n2 && n1 != n3)
        {
            Increase2(n1);
        }
        else if(n1 == n3 && n1 != n2)
        {
            Increase2(n1);
        }
        else if(n2 == n3 && n2 != n1)
        {
            Increase2(n2);
        }
        else
        {
            creditStay = 0;
        }
        
    }
    void Increase3(int winNum)
    {
        if(winNum == 1)
        {
            creditInc = 5;
        }
        else if(winNum == 2)
        {
            creditInc = 10;
        }
        else if(winNum == 3)
        {
            creditInc = 30;
        }
        else if(winNum == 4)
        {
            creditInc = 20;
        }
        else if(winNum == 5)
        {
            creditInc = 250;
        }

        bigCheck = true;
    }
    void Increase2(int winNum2)
    {
        if (winNum2 == 1)
        {
            creditInc = 2;
        }
        else if (winNum2 == 2)
        {
            creditInc = +3;
        }
            else if (winNum2 == 3)
        {
            creditInc = 7;
        }
        else if (winNum2 == 4)
        {
            creditInc = 5;
        }
        else if (winNum2 == 5)
        {
            creditInc = 10;
        }
    }
   
}
