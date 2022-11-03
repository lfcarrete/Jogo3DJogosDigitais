using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float _baseSpeed = 10.0f;
   public float _gravidade = 9.8f;
   public float _sensitivity = 2.0f;
   private bool _Menu;

   //Referência usada para a câmera filha do jogador
   GameObject playerCamera;
   //Utilizada para poder travar a rotação no angulo que quisermos.
   float cameraRotation;
   CharacterController characterController;

   void Start()
   {
        characterController = GetComponent<CharacterController>();
        playerCamera = GameObject.Find("Main Camera");
        cameraRotation = 0.0f;
        this._Menu = false;
   }

   void Update()
   {
        if(!this._Menu){
          float x = Input.GetAxis("Horizontal");
          float z = Input.GetAxis("Vertical");
          
          //Verificando se é preciso aplicar a gravidade
          float y = 0;
          if(!characterController.isGrounded){
               y = -_gravidade;
          }
          
          Vector3 direction = transform.right * x + transform.up * y + transform.forward * z;

          characterController.Move(direction * _baseSpeed * Time.deltaTime);

          
          //Tratando movimentação do mouse
          float mouse_dX = Input.GetAxis("Mouse X")*_sensitivity;
          float mouse_dY = Input.GetAxis("Mouse Y")*_sensitivity;
          
          //Tratando a rotação da câmera
          cameraRotation -= mouse_dY;
          cameraRotation = Mathf.Clamp(cameraRotation, -100f, 100f);

          characterController.Move(direction * _baseSpeed * Time.deltaTime);
          transform.Rotate(Vector3.up, mouse_dX);

          playerCamera.transform.localRotation = Quaternion.Euler(cameraRotation, 0.0f, 0.0f);
        }

          if(Input.GetKeyDown(KeyCode.Escape)){
               this._Menu = !this._Menu;
          }
   }

}