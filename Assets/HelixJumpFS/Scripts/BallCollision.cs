using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class BallCollision : OneColliderTrigger
{
    
    public GameObject visualModel;
    // ссылка на визуальную модель спрайта
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Segment")
        // проверяем соприкосновение с сегментом        
        {
            // получаем координаты точки соприкосновения            

            Vector3 contactPoint = collision.GetContact(0).point;

            // создаем спрайт на высоте мяча            
            GameObject sprite = Instantiate(visualModel, new Vector3(contactPoint.x, transform.position.y, contactPoint.z), Quaternion.identity);

            // окрашиваем спрайт в цвет мяча            
            //sprite.GetComponent().material.color = ball_mat.color;

            // приподнимаем спрайт немного выше, чтобы был виден           
            Vector3 spritePosition = sprite.transform.position;
            spritePosition.y += 0.1f;
            sprite.transform.position = spritePosition;

            // случайно поворачиваем спрайт по оси Y            
            float randomRotation = Random.Range(0f, 360f);
            sprite.transform.rotation = Quaternion.Euler(0f, randomRotation, 0f);

            // делаем спрайт дочерним для уровня вращения           
            sprite.transform.parent = transform.parent;
        }
    }
}



   
