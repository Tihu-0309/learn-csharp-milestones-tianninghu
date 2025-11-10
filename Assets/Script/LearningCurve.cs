using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Birthday = 3.9f;
    public string FirstName = "Tia";
    public bool IsAuthor = true;

    // Single - line comment - Chapter 2 task

    /* Multi-line comment
        chapter 2 task */

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        Debug.Log($"A string can have variables like {FirstName} inserted. directly!");
    }

    /// <summary>
    /// Chapter 2 task - summary comment
    /// computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + Birthday);
    }
}
