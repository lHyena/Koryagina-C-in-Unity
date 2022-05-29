using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Maze
{
    public class Main : MonoBehaviour
    {
        private ListExecuteObject _interactiveObject; 
        private InputController _inputController;

        [SerializeField] private GameObject _player;
        void Awake()
        {
            _inputController = new InputController(_player.GetComponent<Unit>());// обращаемся к базовому классу чз дочерний
            _interactiveObject = new ListExecuteObject();// создание листа перечисляемых объектов

            _interactiveObject.AddExecuteObject(_inputController);// добавляем _inputController в этот лист
        }

        // Update is called once per frame
        void Update()
        {
            for( int i= 0; i< _interactiveObject.Length; i++)
            {
                if (_interactiveObject[i] == null)
                {
                    continue;
                }

                _interactiveObject[i].Update();
            }
        }
    }
}
