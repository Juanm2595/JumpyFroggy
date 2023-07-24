using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enlace : MonoBehaviour
{
    
    public void enlaceOpen(string enlace){
        Application.OpenURL(enlace);
    }
}
