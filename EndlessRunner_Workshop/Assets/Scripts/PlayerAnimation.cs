using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer sprite;
    [SerializeField]
    private Vector3 rotDegrees;

    public void FlapAnimation()
    {
        sprite.gameObject.transform.rotation = Quaternion.Euler(rotDegrees);
    }

    public void FallAnimation()
    {
		sprite.gameObject.transform.Rotate(new Vector3(0, 0, -100 * Time.deltaTime));
		if (sprite.gameObject.transform.eulerAngles.z < 270 && sprite.gameObject.transform.eulerAngles.z > 90)
		{
			sprite.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
		}
        
	}
}
