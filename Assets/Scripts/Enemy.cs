using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovingObject
{
    public int playerDamage;

    private Animator animator;
    private Transform target;
    private bool skipMove;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        // base.AttemptMove<T>(xDir, yDir);
        GameManager.instance.AddEnemyToList(this);
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        base.Start();
    }

    public void MoveEnemy()
    {
        int xDir = 0;
        int yDir = 0;

        if(Mathf.Abs (target.position.x - transform.position.x) < float.Epsilon)
				
            yDir = target.position.y > transform.position.y ? 1 : -1;
			
        else
            xDir = target.position.x > transform.position.x ? 1 : -1;
			
        AttemptMove <Player> (xDir, yDir);
    }

    protected override void OnCantMove<T>(T component)
    {
        // throw new System.NotImplementedException();
        Player hitPlayer = component as Player;
        hitPlayer.LoseFood (playerDamage);
        animator.SetTrigger("enemyAttack");
    }

    protected override void AttemptMove<T>(int xDir, int yDir)
    {
        if (skipMove)
        {
            skipMove = false;
            return;
        }
        
        base.AttemptMove<T>(xDir, yDir);
        skipMove = true;
    }
}
