using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Boss timer made with help from https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

public class VictoryScreen : Core
{
    public TextMeshProUGUI BossText;

    public TextMeshProUGUI TimeText;

    public TextMeshProUGUI ScoreText;

    public TextMeshProUGUI GradeText;

    private void Update()
    {
        BossText.SetText("Congratulations, fighter!\nYou have defeated " + GameInstanceManager.Main.CurrentBoss.ActorName + "!");

        float minutes = GameInstanceManager.Main.FightDuration / 60;

        float seconds = GameInstanceManager.Main.FightDuration % 60;

        TimeText.SetText("You defeated the boss in " + (int)minutes + ":" + (int)seconds);

        ScoreText.SetText("Score: " + GameInstanceManager.Main.FightScore);

        string fightGrade;

        if (GameInstanceManager.Main.FightScore >= 950) { fightGrade = "S"; }
        else if (GameInstanceManager.Main.FightScore >= 900) { fightGrade = "A"; }
        else if (GameInstanceManager.Main.FightScore >= 800) { fightGrade = "B"; }
        else if (GameInstanceManager.Main.FightScore >= 700) { fightGrade = "C"; }
        else if (GameInstanceManager.Main.FightScore >= 600) { fightGrade = "D"; }
        else if (GameInstanceManager.Main.FightScore >= 500) { fightGrade = "E"; }
        else { fightGrade = "F"; }

        GradeText.SetText("Your fight grade: " + fightGrade);
    }
}
