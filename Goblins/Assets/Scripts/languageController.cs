using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languageController : MonoBehaviour
{
    // Сокращение кнопок MM - MainManu
    [NonSerialized] public static string MMButton1, MMButton2, MMButton3, MMButton4, MMText1, MMButton5, MMButton6;
    
    // Сокрашение кнопок MS - MainScene
    [NonSerialized] public static string MSText1, MSButton1, MSText2,  MSText3,  MSText4,  MSText5, MSText6, MSText7, MSText8, MSText9, MSText10, MSButton2, MSText12, MSButton3, MSButton4, MSText15, MSText16, MSText17, MSText18,  MSButton5, MSButton6, MSButton7;    
    
    //Сокрашение кнопок D - DownloadSene
    [NonSerialized] public static string DText1;
    
    //Сокрашение кнопок Sound - панель вука
    [NonSerialized] public static string SoundBotton1, SoundText1, SoundText2, SoundText3;
    private string path;
    private List<string> values = new List<string> ();
    private bool writeLanguage = true;
    
    
    void Start()
    {
        MMButton1 = "Начать игру";
        MMButton2 = "Загрузить карты";
        MMButton3 = "Выбор языка";
        MMButton4 = "Выход";

        MMText1 = "База данных карт обновлена до последней версии";

        MMButton5 = "Русский";
        MMButton6 = "Английский";

        MSText1 = "Начало игры";
        MSButton1 = "Начать игру";
        
        MSText2 = "Выберите параметр";
        MSText3 = "Сила";
        MSText4 = "Ловкость";
        MSText5 = "Интеллект";

        MSText6 = "Победил игрок";
        MSText7 = "Победил компьютер";
        MSText8 = "Ничья";
        MSText9 = "Игрок";
        MSText10 = "Компьютер";
        MSButton2 = "Следующий раунд";

        MSText12 = "Выбор хода";
        MSButton3 = "Ваш ход";
        MSButton4 = "Предоставить ход компьютеру";

        MSText15 = "Компьютер выбрал способность";

        MSText16 = "Победа";
        MSText17 = "Порожение";
        MSText18 = "Ничья";
        MSButton5 = "Новая игра";
        MSButton6 = "Главное меню";

        MSButton7 = "Продолжить игру";
        DText1 = "Загрузка";

        SoundBotton1 = "Звук";
        SoundText1 = "Музыка";
        SoundText2 = "Кнопки";
        SoundText3 = "вкл/выул звук";
    }

    
    void Update()
    {   
        if(writeLanguage) {
            if (path != null) {
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                    fileInf.CopyTo(@"Assets\Language\Language.txt", true);
            }

            if(File.Exists(@"Assets\Language\Language.txt"))
                readFile(@"Assets\Language\Language.txt");

            writeLanguage = false;
        }



        
        if(values.Count > 0) {
            // Сцена главного меню
                // Главное меню
            MMButton1 = values[0];
            MMButton2 = values[1];
            MMButton3 = values[2];
            MMButton4 = values[3];
                // Меню загрузки карт
            MMText1 =  values[4];
                // Меню выбора языка
            MMButton5 =  values[5];
            MMButton6 =  values[6];

            // Главная сцена
                // endchois
            MSText1 = values[7];
            MSButton1 = values[8];
                // abilityChois и abilityFon
            MSText2 = values[9];
            MSText3 = values[10];
            MSText4 = values[11];
            MSText5 = values[12];
                // count
            MSText6 = values[13];
            MSText7 = values[14];
            MSText8 = values[15];
            MSText9 = values[16];
            MSText10 = values[17];
            MSButton2 = values[18];

                // choiseMove
            MSText12 = values[19];
            MSButton3 = values[20];
            MSButton4 = values[21];

                // abilityComputerChoise
            MSText15 = values[22];

                // finalCount
            MSText16 = values[23];
            MSText17 = values[24];
            MSText18 = values[25];      
            MSButton5 = values[26];
            MSButton6 = values[27];
            
                // menu
            MSButton7 = values[28];

            // Download
            DText1 = values[29];

            // soundPanel
            SoundBotton1 = values[30];
            SoundText1 = values[31];
            SoundText2 = values[32];
            SoundText3 = values[33];
        }
    }

    public void Russian() {
        deleteFile();
        path = @"Assets\Language\Russian\Language.txt";
        writeLanguage = true;
        //readFile(path);
    }
    public void English() {
        deleteFile();
        path = @"Assets\Language\English\Language.txt";
        writeLanguage = true;
        //readFile(path);
    }
    public void readFile(string path) {
        values.Clear();
        using (StreamReader sr = new StreamReader(path)) {
            string line;
            while((line = sr.ReadLine()) != null)
                values.Add(line);
        }
    }
    public void deleteFile() {
        FileInfo fileInf = new FileInfo(@"Assets\Language\Language.txt");
        if (fileInf.Exists)
            {
            fileInf.Delete();
            }
    }
}