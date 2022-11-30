using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private EnemyData enemyData;

    private bool executingActions = true;

    void Update()
    {
        if (executingActions)
        {
            enemyData.EnemyBehaviour.Execute();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopExecutingActions();

        //turning off enemy collider
        if (collision.collider.tag == TagsUtils.TAGS.PLAYER)
        {
            collision.otherCollider.enabled = false;
        }
    }

    private void StopExecutingActions()
    {
        executingActions = false;
    }
}
