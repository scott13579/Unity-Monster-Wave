using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private Turret turret;
    private ItemManager itemManager;
    
    private Animator anim;

    public float speed;
    public float hp;

    public bool isMove;

    public void OnHit(float damage)
    {
        Hit(damage);
    }
    protected virtual void Init()
    {
        anim = GetComponent<Animator>();
        
        turret = FindObjectOfType<Turret>();
        itemManager = FindObjectOfType<ItemManager>();
    }
    
    void Start()
    {
        Init();
        
        // anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }
    
    protected virtual void Hit(float damage)
    {
        CancelInvoke("DelayMove");
        
        hp -= damage;
        isMove = false;

        if (hp <= 0)
        {
            anim.SetTrigger("dead");
            this.GetComponent<Collider>().enabled = false;

            turret.SetTarget(this.transform);
            
            GameObject dropItem = itemManager.CreateItem();
            
            dropItem.transform.SetPositionAndRotation(this.transform.position, Quaternion.identity);
            
            float ranFloatX = Random.Range(-1f, 1f);
            float ranFloatZ = Random.Range(-1f, 1f);
            Vector3 ranVector3 = new Vector3(ranFloatX, 6f, ranFloatZ);
            int ranInt = Random.Range(0, 360);
            Vector3 ranQuaternion = Quaternion.Euler(ranInt, ranInt, ranInt).eulerAngles;
            
            dropItem.GetComponent<Rigidbody>().AddForce(ranVector3, ForceMode.Impulse); // 드롭아이템 위로 뜨는 기능
            
            dropItem.GetComponent<Rigidbody>().AddTorque(ranQuaternion, ForceMode.Impulse);
            
            Destroy(this.gameObject, 5f);
        }
        else
        {
            anim.SetTrigger("hit");
            Invoke("DelayMove", 0.5f);
        }
    }

    private void DelayMove()
    {
        isMove = true;
    }
    
    protected void Move()
    {
        if (isMove)
        {
            this.transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        }
    }
}