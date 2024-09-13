Console.Clear();
string stadium = GetEnjoymentLevel();
stadium = GetStadiumRecommendations(stadium);

string gameRecommendations = GetGameRecommendations(stadium);

DisplayStadiumDetails(stadium, gameRecommendations);



static string GetEnjoymentLevel(){
Console.WriteLine("\nEnter your enjoyment level: Boring, Average, Fun, or Epic");

string enjoymentLevel = Console.ReadLine();
if (enjoymentLevel.ToLower() != "boring" && enjoymentLevel.ToLower() != "average"&& enjoymentLevel.ToLower() !="fun" && enjoymentLevel.ToLower() !="epic"){
    Console.Clear();
    Console.WriteLine("That is not a valid selection, please enter a valid input");
    enjoymentLevel = GetEnjoymentLevel();
}
Console.Clear();
return enjoymentLevel;

}


static string GetStadiumRecommendations(string enjoymentLevel){
    if (enjoymentLevel.ToLower() == "boring"){
        enjoymentLevel =  "Neyland Stadium";
    } else if(enjoymentLevel.ToLower() == "average"){
       enjoymentLevel = "Jordan-Hare Stadium";
    }else if (enjoymentLevel.ToLower() == "fun"){
       enjoymentLevel = "Tiger Stadium";
    } else if (enjoymentLevel.ToLower() == "epic"){
       enjoymentLevel =  "Saban Field at Bryant-Denny Stadium";
    }
return enjoymentLevel;
}

static string GetGameRecommendations(string stadium){
    if(stadium == "Neyland Stadium"){
        stadium = "Kent State";
    } else if(stadium == "Jordan-Hare Stadium"){
        stadium = "Kentucky";
    } else if(stadium == "Tiger Stadium"){
        stadium = "Alabama";
    } else if(stadium == "Saban Field at Bryant-Denny Stadium"){
        stadium = "Auburn";
    }

    return stadium;

}


static void DisplayStadiumDetails(string stadium, string gameRecommendations){
    Console.WriteLine($"You should attend the {gameRecommendations} game at {stadium}");
}