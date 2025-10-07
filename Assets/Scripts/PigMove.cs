using UnityEngine;

public class PigMove : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed = 5f;

    private void LateUpdate() {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);

        if(direction.magnitude > 2){
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
