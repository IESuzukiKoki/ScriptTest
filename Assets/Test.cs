using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private int[] testarray = { 30, 20, 50, 10, 80 }; //課題用配列

    public class Boss
    {
        private int hp = 100;   // 体力
        private int power = 25; // 攻撃力
        private int _mp = 53;    //MP          

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }

        public void Magic(int mp)
        {
            //MPチェック
            if (_mp >= mp)
            {
                //MP減少
                _mp -= mp;
                Debug.Log("魔法攻撃をした。残りMPは" + _mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }

        }


    }



    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //10回ループ
        for (int i = 0; i <= 10; i++)
        {
            //魔法用関数を呼び出す
            lastboss.Magic(5);
        }

        //配列の要素数分繰り返す
        for (int i = 0; i < testarray.Length; i++)
        {
            Debug.Log("課題インクリメント:" + testarray[i]);
        }

        //配列の要素数分繰り返す
        for (int i = testarray.Length - 1; i >= 0; i--)
        {
            Debug.Log("課題デクリメント" + testarray[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
