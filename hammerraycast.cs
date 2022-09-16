using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hammerraycast : MonoBehaviour
{
    [SerializeField]
    private Camera characterCamera;
    public float Distance = 25;
    public Image cross;
    


    
    public GameObject hammerbutonuyeri;
    public static bool hammerraycastislesin = true;
    public static bool eldekibaltadi = false;
    private hammercontroller raycastedObj;
    public void Start()
    {

    }

    public void Update()
    {

        if (hammerraycastislesin)
        {
            Ray ray = new Ray(characterCamera.transform.position, characterCamera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Distance) && hit.collider.tag == "qutuhammer")
            {

                cross.color = Color.red;
                hammerbutonuyeri.SetActive(true);
                
                        if (eldekibaltadi)
                             {
                                raycastedObj = hit.collider.gameObject.GetComponent<hammercontroller>();
                                raycastedObj.PlayAnimation();
                                eldekibaltadi = false;
                                hammerbutonuyeri.SetActive(false);
                             }
            }
            else
            {
                hammerbutonuyeri.SetActive(false);
            }


        }

    }

    public void  hammerbutonu()
    {
        eldekibaltadi = true;
        

    }
}
