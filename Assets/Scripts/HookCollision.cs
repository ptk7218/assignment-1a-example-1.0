using UnityEngine;

public class HookCollision : MonoBehaviour
{
    public HandleFishingHook hook;
    [SerializeField]
    SpriteRenderer hookSprite;
    [SerializeField]
    private Sprite hookWithBait;
    [SerializeField]
    private Sprite defaultHook;
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.collider.tag == "Fish")
        {
            hook.SetPointScore(10);

        }
        else if (collision.collider.tag == "Barrel" || collision.collider.tag == "Shark")
        {
            HeartControl.health--;
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        int newPoint = hook.GetPointScore() + 10;

        if (hook.getFishingRodControll())
        {
            if (col.tag == "Fish")
            {
                hook.SetPointScore(10);
                testPointScore(newPoint);
            }
            else if (col.tag == "Barrel" || col.tag == "Shark")
            {
                HeartControl.health--;
                hookSprite.sprite = defaultHook;
                hook.setEnableFishingRodControll(false);
            }
        }
        
    }

    public void testPointScore(int point) {
        if (point != hook.GetPointScore()) {
            Debug.Log("Points not adding correctly");
        } else {
            Debug.Log("Points are adding correctly");
        }
    }
}
