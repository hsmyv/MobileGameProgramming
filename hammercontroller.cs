using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammercontroller : MonoBehaviour
{
    private Animator qutuhammer;
    public static bool hammercollider = false;
    public static bool butonabasildi = false;
    public AudioSource ses;
    public bool animasiya = true;
    public GameObject text;
    public bool textsozu;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }
    private void Awake()
    {
        qutuhammer = gameObject.GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAnimation()
    {
        if (animasiya) 
        {
            if (butonabasildi)
            {
                //if (hammercollider)
                //{
                ses.Play();
                animasiya = false;
                qutuhammer.Play("qutuhammer", 0, 0.0f);
                hammerraycast.hammerraycastislesin = false;
                //  }

            }
            else
            {
                textsozu = true;
            text.SetActive(true);
            StartCoroutine(textsozu1());
            }
            
        }
        else
        {
            butonabasildi = false;
            
        }
    }

    IEnumerator textsozu1()
    {
        yield return new WaitForSeconds(2);
        if (textsozu)
        {
            text.SetActive(false);
        }
    }
    
}
