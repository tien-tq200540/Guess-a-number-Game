using UnityEngine;

public class TienMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        //For override   
    }
}
