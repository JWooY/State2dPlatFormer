using UnityEngine;

public class Circle : Shape
{

    public override void Start() // virtual�� override �ؼ� �θ��� Start�� ������
    {
        base.Start();  // base.Start()�� �θ��� Start�� ������

        Debug.Log("���� ���� ��ӹ��� �ڽ��̴�.");


    }
}
