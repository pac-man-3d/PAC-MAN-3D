using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScore : MonoBehaviour
{ 
public Text countText;
private int count;

// Start is called before the first frame update
void Start()
{
    count = 0;
    SetCountText();
}

// Update is called once per frame
void Update()
{

}

private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Ammo")
    {
        count = count + 1;
        SetCountText();
    }
}
void SetCountText()
{
    countText.text = "Ammo: " + count.ToString();
}
}

