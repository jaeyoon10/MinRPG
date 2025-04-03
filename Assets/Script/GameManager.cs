using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //체력 : 100

    //공격 1: 20
    //공격 2: 30


    //플레이어 MP : 50 공격 1 : 20 MP 소모 x
    // 공격 2 : 30  mp ; 20 플레이어의 MP가 20 이하면 실행 자체 안됨
    public GameObject enemy;

    public Image img;
    public Slider playerHpSlider, playerMpSlider, enemyHpSlider;
    public Button attack, attack2, attack3;

    int attack1count = 0;
    int attack2count = 0;
    int attack3count = 0;


    int attackDamage1 = 10;
    int attackDamage2 = 30;
    int attackDamage3 = 40;
    int attack2Mp = 20;
    int attack3Mp = 50;

    private void Start()
    {
        
        attack.onClick.AddListener(Attack1);
        attack2.onClick.AddListener(Attack2);
        attack3.onClick.AddListener(Attack3);

        playerHpSlider.maxValue = 100;
        playerHpSlider.value = 100;

        playerMpSlider.maxValue = 80;
        playerMpSlider.value = 80;

        enemyHpSlider.maxValue = 100;
        enemyHpSlider.value = 100;  

        img.gameObject.SetActive(false);

    }

    private void Update()
    {
        EnemyAttack();
    }
    public void Attack1()
    {
       enemyHpSlider.value -= attackDamage1;
        if (enemyHpSlider.value <= 0)
        {
            Debug.Log("몬스터를 잡았습니다.");
            Destroy(enemy);
            img.gameObject.SetActive(true);
        }
        attack1count++;
    }

    public void Attack2() 
    { 
        if (playerMpSlider.value< 20)
        {
            Debug.Log("MP가 부족합니다");
            return;
        }
        playerMpSlider.value -= attack2Mp;
        enemyHpSlider.value -= attackDamage2;

        if (enemyHpSlider.value <= 0)
        {
            Debug.Log("몬스터를 잡았습니다.");
            Destroy(enemy);
            img.gameObject.SetActive(true);

        }
        attack2count++;

    }

    public void Attack3()
    {
        if (playerMpSlider.value< 50)
        {
            Debug.Log("MP가 부족합니다.");
            return;
        }
        playerMpSlider.value -= attack3Mp;
        enemyHpSlider.value -= attackDamage3;

        if(enemyHpSlider.value <= 0)
        {
            Debug.Log("몬스터를 잡았습니다.");
            Destroy(enemy);
            img.gameObject.SetActive(true);
        }
        attack3count++;
    }

    void EnemyAttack()
    {
        if(attack1count >= 3)
        {
            playerHpSlider.value -= attackDamage1;
            attack1count = 0;
        }
        else if (attack2count >= 2) 
        {
            playerHpSlider.value -= attackDamage2;
            attack2count = 0;
        }
        else if(attack3count >= 1)
        {
            playerHpSlider.value -= attackDamage3;
            attack3count = 0;
        }
        if ( playerHpSlider.value <= 0)
        {
            Debug.Log("플레이어가 사망하였습니다");
        }
    }

}
