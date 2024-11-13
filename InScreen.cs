using UnityEngine;

public class InScreen : MonoBehaviour
{
    public float top;
    public float bottom;
    public float left;
    public float right;

    void LateUpdate()
    {
        var pos =transform.position;

        if(pos.x < this.left)   pos.x    = this.left;
        if(pos.x > this.right)  pos.x    = this.right;
        if(pos.y > this.top)    pos.y    = this.top;
        if(pos.y < this.bottom) pos.y    = this.bottom;

        transform.position = pos;
    }
}