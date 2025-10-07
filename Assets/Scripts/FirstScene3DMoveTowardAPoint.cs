using UnityEngine;

public class FirstScene3DMoveTowardAPoint : MonoBehaviour
{
    Vector3 goal;
    public float speed = 1.0f;
    public float accuracy = 1.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goal = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            goal = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
            Debug.Log("Current position vector: " + goal.ToString());
        }

        this.transform.LookAt(goal);

        if (Vector3.Distance(transform.position, goal) > accuracy)
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
