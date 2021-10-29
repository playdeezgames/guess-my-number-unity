using Assets.Scipts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Thingie : MonoBehaviour
{
    private Tilemap tileMap;
    private StateMachine stateMachine;

    void Start()
    {
        tileMap = GetComponentInChildren<Tilemap>();
        stateMachine = new StateMachine();
        Terminal.HandleInputLine = stateMachine.HandleInput;
        stateMachine.Refresh();
    }

    void UpdateTerminal()
    {
        for(int row = 0; row<Terminal.Rows;++row)
        {
            for(int column=0;column<Terminal.Columns;++column)
            {
                var plot = new Vector3Int(column-Terminal.Columns/2, -row+Terminal.Rows/2-1,0);
                tileMap.SetTile(plot, Tiles.Read(Terminal.GetCell(column, row)));
            }
        }
    }

    void Update()
    {
        Terminal.Write(Input.inputString, true);
        UpdateTerminal();
    }
}
