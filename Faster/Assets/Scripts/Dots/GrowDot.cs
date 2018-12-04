using UnityEngine;

public class GrowDot : MonoBehaviour
{
    public Vector3 firstScale;
    public Vector3 secondScale;
    public int count;

    private float firstSpeed = 10;
    protected float speed;

    protected Vector3 target;

    void Start()
    {
        transform.localScale = firstScale;
        target = secondScale;

        speed = firstSpeed;
    }

    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, target, Time.deltaTime * speed);

        if (transform.localScale == target)
        {
            if (count > 1)
            {
                count--;
                if (target == firstScale)
                {
                    fromFirstToSecond();
                }
                else if (target == secondScale)
                {
                    fromSecondToFirst();
                }
            }
            else
            {
                EndTrigger();
            }
        }
    }

    private void fromFirstToSecond()
    {
        target = secondScale;
    }

    protected virtual void fromSecondToFirst()
    {
        target = firstScale;
    }

    protected virtual void EndTrigger()
    {
        
    }
}