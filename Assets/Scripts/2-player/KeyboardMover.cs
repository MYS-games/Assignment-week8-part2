using UnityEngine;

/**
 * This component allows the player to move by clicking the arrow keys.
 */
public class KeyboardMover : MonoBehaviour
{
    protected Vector3 min = new Vector3(-1000, -1000, -1000);
    protected Vector3 NewPosition()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return transform.position + Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return transform.position + Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return transform.position + Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            return transform.position + Vector3.up;
        }
        else
        {
            return transform.position;
        }
    }
    protected Vector3 NewPositionAfterX() ///checks if we pressed the X key for carving 
    {
        if (Input.GetKey(KeyCode.X))
        {

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                return transform.position + Vector3.left;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                return transform.position + Vector3.right;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                return transform.position + Vector3.down;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                return transform.position + Vector3.up;
            }
            else
            {
                return transform.position;
            }
        }
      
        else return min;

    }


    void Update()
    {
        var pos = NewPositionAfterX();
        if (NewPositionAfterX() == min)
        {
            Debug.Log(" X not pressed");
            transform.position = NewPosition();
        }
        else transform.position = pos;
    }
}
