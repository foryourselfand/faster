using UnityEngine;

public abstract class GrowButton : MonoBehaviour
{
    public float firstSpeed;
    public float secondSpeed;
    public Vector3 down;

    protected Vector3 target;
    protected Vector3 up;
    private float speed;

    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
        speed = firstSpeed;
        up = new Vector3(1, 1, 1);
        target = up;
    }

    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, target, Time.deltaTime * speed);

        if (transform.localScale == target)
        {
            if (target == up)
            {
                speed = secondSpeed;
                fromUpToDown();
            }
            else if (target == down)
            {
                fromDownToUp();
            }
        }
    }

    public abstract void fromUpToDown();

    public abstract void fromDownToUp();
}