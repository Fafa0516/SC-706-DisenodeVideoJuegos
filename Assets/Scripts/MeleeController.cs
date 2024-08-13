using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{

    [SerializeField, Tooltip("Range interval for attacks")]
    float attackRange;

    [SerializeField, Tooltip("Amount of attack per Range")]
    float attackRate;


    private CharacterController2D _character;

    private float _attackTime;

    private void Awake()
    {
        _character = GetComponent<CharacterController2D>();
    }


    private void Update()
    {
        _attackTime -= Time.deltaTime;
        if (_attackTime < 0.0F)
        {
            _attackTime = 0.0F;
        }
        if (_attackTime == 0.0F)
        {
            if (Input.GetButton("Fire1"))
            {
                //_character.Punch();
            }
        }
    }
    
}
