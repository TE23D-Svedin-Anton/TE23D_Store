using System.Runtime.ConstrainedExecution;

int DinaStålar = 100;

while (DinaStålar > 0)
{
    Console.WriteLine("TJO AMO!");
    Console.WriteLine($"Whalla du har {DinaStålar}Kr kvar din fattig lapp");
    Console.WriteLine("Äcklig banan 10kr");
    Console.WriteLine("Vanlig banan 20Kr");
    Console.WriteLine("As cool banan 50kr");

    Console.WriteLine("VAD DU KÖPA! Eller du gå?");
    
    string Vadmanskaköpa = "";
    while (Vadmanskaköpa != "Äcklig banan" && Vadmanskaköpa != "Vanlig banan" && Vadmanskaköpa != "As cool banan")
    {
        Vadmanskaköpa = Console.ReadLine();
    }

    int prispervara = 0;

    if(Vadmanskaköpa == "Äcklig banan")
    {
        prispervara = 10;
    }
    else if(Vadmanskaköpa == "Vanlig banan")
    {
        prispervara = 20;
    }
    else if(Vadmanskaköpa == "As cool banan")
    {
        prispervara = 50;
    }

    Console.WriteLine("Hur många du köpa!");
    int hurmångaköpa = 0;
    while(hurmångaköpa == 0)
    {
        string num = Console.ReadLine();
        bool success = int.TryParse(num, out hurmångaköpa);
        if(success == false)
        {
            Console.WriteLine("AMO! En siffra");
        }
    }

    int totalkostnad = prispervara * hurmångaköpa;

    if (totalkostnad <= DinaStålar)
    {
        Console.WriteLine("JA! Mycket Bra");
        DinaStålar -= totalkostnad;
    }
    else
    {
        Console.WriteLine("NEJ! De Du inte har råd med");
    }
}

Console.WriteLine("AJABAJA! Dina pengar borta");
Console.WriteLine("HEJDÅ!");
Console.ReadLine();