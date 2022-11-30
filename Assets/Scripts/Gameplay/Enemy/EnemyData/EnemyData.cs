using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField]
    private EnemyBehaviour enemyBehaviour;
    [SerializeField]
    private float _speed;

    public EnemyBehaviour EnemyBehaviour { get => enemyBehaviour; set => enemyBehaviour = value; }
}
