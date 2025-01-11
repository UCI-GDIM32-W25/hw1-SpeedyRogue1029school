using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        //Provides movement for player character with corresponding Keyspress.
        if (Input.GetKey("w"))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            _playerTransform.Translate(-Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            _playerTransform.Translate(-Vector3.left * _speed * Time.deltaTime);
        }

        //Plants seed with corresponding keypress.
        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if(_numSeeds > 0)
        {
            //References player location to apply to plant location.
            Vector3 _plantpos = _playerTransform.position;
            _plantPrefab.transform.position = _plantpos;

            //creates coppy of plant gameobject and places copy down until _numSeeds <= 0.
            GameObject _plantPrefabCopy = Instantiate(_plantPrefab);
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            _numSeeds--;
            _numSeedsPlanted++;
            _numSeedsLeft--;
        }
    }
}
