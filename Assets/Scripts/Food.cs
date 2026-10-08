using UnityEngine;

public class Food : MonoBehaviour
{

    private int value;
    
    public void SetValue(int v)
    {
        value = v;
    }
    public int GetValue()
    {
        return value;
    }
}
