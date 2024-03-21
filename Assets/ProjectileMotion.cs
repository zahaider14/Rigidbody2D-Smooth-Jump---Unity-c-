using DG.Tweening;
using UnityEngine;
public class ProjectileMotion : MonoBehaviour
{
    public float initialSpeed = 10f; // Initial speed of the projectile
    public float gravity = -9.81f;   // Acceleration due to gravity
    public Transform targetObject, target2;   // Transform of the target object

    private Rigidbody2D rb;
    private Vector2 initialPosition;
    private Vector2 targetPosition;
    private float timeToReachTarget;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.DOMoveX(target2.position.x, 3f);
    }

    public void Jump2()
    {
        transform.DOTogglePause();
        initialPosition = transform.position;
        targetPosition = targetObject.position;
        // Calculate time to reach target using projectile motion equation
        float displacementY = targetPosition.y - initialPosition.y;
        float verticalVelocity = Mathf.Sqrt(-2 * gravity * displacementY);
        timeToReachTarget = -verticalVelocity / gravity;

        // Calculate initial velocity using time to reach target and horizontal displacement
        float displacementX = targetPosition.x - initialPosition.x;
        float horizontalVelocity = displacementX / timeToReachTarget;

        // Set initial velocity of the rigidbody
        rb.velocity = new Vector2(horizontalVelocity, verticalVelocity);
    }
}
