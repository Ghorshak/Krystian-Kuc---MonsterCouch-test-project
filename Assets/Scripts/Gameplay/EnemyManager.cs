using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private int enemyCount = 1000;
    [SerializeField]
    private GameObject enemyPrefab;

    void Start()
    {
        PrepareEnemies();
    }

    private void PrepareEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector2 position = GetEnemyRandomStartingPosition();
            Instantiate(enemyPrefab, position, Quaternion.identity, gameObject.transform);
        }
    }

    private Vector2 GetEnemyRandomStartingPosition()
    {
        float posX = Random.Range(Camera.main.ScreenToWorldPoint(Vector2.zero).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
        float posY = Random.Range(Camera.main.ScreenToWorldPoint(Vector2.zero).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);

        return new Vector2(posX, posY);
    }
}
