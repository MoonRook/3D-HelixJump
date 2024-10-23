using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class BallCollision : OneColliderTrigger
{
    
    public GameObject visualModel;
    // ������ �� ���������� ������ �������
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Segment")
        // ��������� ��������������� � ���������        
        {
            // �������� ���������� ����� ���������������            

            Vector3 contactPoint = collision.GetContact(0).point;

            // ������� ������ �� ������ ����            
            GameObject sprite = Instantiate(visualModel, new Vector3(contactPoint.x, transform.position.y, contactPoint.z), Quaternion.identity);

            // ���������� ������ � ���� ����            
            //sprite.GetComponent().material.color = ball_mat.color;

            // ������������ ������ ������� ����, ����� ��� �����           
            Vector3 spritePosition = sprite.transform.position;
            spritePosition.y += 0.1f;
            sprite.transform.position = spritePosition;

            // �������� ������������ ������ �� ��� Y            
            float randomRotation = Random.Range(0f, 360f);
            sprite.transform.rotation = Quaternion.Euler(0f, randomRotation, 0f);

            // ������ ������ �������� ��� ������ ��������           
            sprite.transform.parent = transform.parent;
        }
    }
}



   
