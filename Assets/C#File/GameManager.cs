using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static Character;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GameManager : MonoBehaviour
{
    public List<Player> players;
    public List<Monster> monsters;
    public Boss boss;

    void Start()
    {
        InitializeGame();
        SaveGameDataToCSV();
    }

    void InitializeGame()
    {
        players = new List<Player>
        {
            new Player("Player1", 100, 20, 10, 5),
            new Player("Player2", 120, 18, 12, 7),
            new Player("Player3", 80, 25, 8, 6)
        };

        monsters = new List<Monster>
        {
            new Monster("Monster1", 80, 15, 5, 4),
            new Monster("Monster2", 100, 12, 8, 3),
            new Monster("Monster3", 120, 10, 10, 2)
        };

        boss = new Boss("Boss", 200, 30, 20, 8);
    }

    void SaveGameDataToCSV()
    {
        string filePath = Application.dataPath + "/GameData.csv";
        StreamWriter writer = new StreamWriter(filePath);

        WriteCharacterDataToCSV(players, writer);
        WriteCharacterDataToCSV(monsters, writer);
        WriteCharacterDataToCSV(new List<Character> { boss }, writer);

        writer.Close();
        Debug.Log("게임 데이터가 CSV 파일로 저장되었습니다.");
    }

    void WriteCharacterDataToCSV(List<Character> characters, StreamWriter writer)
    {
        foreach (Character character in characters)
        {
            string data = $"{character.Name},{character.Health},{character.Attack},{character.Defense},{character.Speed}";
            writer.WriteLine(data);
        }
    }
}
