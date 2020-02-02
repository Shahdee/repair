using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    private Vector2 offset;

    private void OnMouseDown() 
    {
        offset.x = transform.position.x - GetMouseWorldPosition().x;
        offset.y = transform.position.y - GetMouseWorldPosition().y;
        SoundRandomContainer soundContainer = GetComponent<IngredientVisual>().soundTake;
        soundContainer?.Play();
    }

    private void OnMouseDrag() 
    {
        transform.position = GetMouseWorldPosition() + offset;
    }

    private Vector2 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        SoundRandomContainer soundContainer = GetComponent<IngredientVisual>().soundPut;
        soundContainer?.Play();
    }
}
