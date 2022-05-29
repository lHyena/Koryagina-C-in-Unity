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
            _inputController = new InputController(_player.GetComponent<Unit>());// ���������� � �������� ������ �� ��������
            _interactiveObject = new ListExecuteObject();// �������� ����� ������������� ��������

            _interactiveObject.AddExecuteObject(_inputController);// ��������� _inputController � ���� ����
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
