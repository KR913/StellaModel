using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Zodiac_Info
{
    public static string curr="";
    static string H1 = "The Greeks linked Aquarius with Ganymede, the cup bearer to the gods. According to lore, Ganymede was a good-looking young man who was the object of Zeus' affection and was brought to Mount Olympus, where he served as cup bearer to the gods and was granted eternal youth.";
    static string H2 = "The Greeks traditionally associated the Aries constellation with a ram. In Greek mythology, the ram was sacrificed to Zeus, the Greek leader of the gods. Its golden fleece later led to the journey of Jason and the Argonaunt, one of the greatest journeys in Greek mythology.";
    static string H3 = "The constellation of Cancer represents the giant crab Karkinos that attacked Hercules during the second of the 12 labors he performed as penance for killing his family. It was sent by the jealous goddess Hera to thwart Hercules as he battled the water serpent Hydra, but he killed it.";
    static string H4 = "The Greeks associate the constellation of Capricorn with Pan, the god of wild and nature. The god had a horrible shout that could frighten even the Titans. In the Battle of Marathon, Pan was said to have inspired panic in the hearts of the Persians. The word [Panic] derives from his name.";
    static string H5 = "The Gemini is identified as twin half-brothers Pollux and Castor known together as Dioscuri (Sons of Zeus). While Pollux was a divine son of Zeus, Castor is a mortal. Their bond was strong enough to move the heart of the chief god who helped them stay together even after the death of Castor.";
    static string H6 = "In Greek mythology, Leo is the Nemean Lion, which terrorized the citizens. It had claws sharper than any mortal weapons and a hide that could not punctured by iron, bronze or stone. Killing the lion was one of Hercules' 12 labors, which he had to perform as penance for killing his family.";
    static string H7 = "While the ancient Greeks viewed Libra as the claws of Scorpio reaching out, the constellation can also be viewed as the scale that represents justice, balance and harmony. The scale belonged to Dike, the goddess of justice, the spirit of moral order and fair judgment and the embodiment of Virgo.";
    static string H8 = "In the sky, Pisces is represented as two fish attached by a cord. The fish are apparently the Greek goddess Aphrodite and her son, Eros, who turned into fish and jumped into the Euphrates River to evade the fiery breath of the monster Typhon, the most awful monster the world had ever seen.";
    static string H9 = "The Greeks identify Sagittarius as a centaur, horse-human hybrid with the body of a man atop the four legs of a horse. The creature is aiming an arrow toward its neighbor Scorpio. The lore has Sagittarius the Archer shooting Scorpio the Scorpion, which had been sent to kill Orion the Hunter.";
    static string H10 = "Scorpio represents the scorpion sent by the god Apollo, Artemis's twin brother to kill Orion the giant hunter. The creature's sting was poisonous enough to kill the giant with one strike. After the battle, Zeus put Orion and Scorpio in the sky, but they are visible at different times of the year.";
    static string H11 = "The ancient Greeks associate Taurus with the chief god Zeus. When Zeus fell in love with the Phoenician Princess Europa, he transformed himself into a white bull with golden horns. As the princess was captured by his beauty and hopped into his back, the bull carried Europa away to Crete.";
    static string H12 = "Virgo is linked with Dike, who somtimes is referred as Astraea, the virgin goddess of justice. The celestial maiden was the last immortal to live with human. While she has left the Earth due to her disappointment in humanity, it was said that one day she will return, along with the utopian golden age.";
    public static string info()
    {
        string inf="";
        if (curr.Trim().Equals("Aquarius"))
        {
            inf = H1;
        }
        if (curr.Trim().Equals("Aries"))
        {
            inf = H2;
        }
        if (curr.Trim().Equals("Cancer"))
        {
            inf = H3;
        }
        if (curr.Trim().Equals("Capricorn"))
        {
            inf = H4;
        }
        if (curr.Trim().Equals("Gemini"))
        {
            inf = H5;
        }
        if (curr.Trim().Equals("Leo"))
        {
            inf = H6;
        }
        if (curr.Trim().Equals("Libra"))
        {
            inf = H7;
        }
        if (curr.Trim().Equals("Pisces"))
        {
            inf = H8;
        }
        if (curr.Trim().Equals("Sagittarius"))
        {
            inf = H9;
        }
        if (curr.Trim().Equals("Scorpio"))
        {
            inf = H10;
        }
        if (curr.Trim().Equals("Taurus"))
        {
            inf = H11;
        }
        if (curr.Trim().Equals("Virgo"))
        {
            inf = H12;
        }
        return inf;
    }
    public static string info(string _name)
    {
        string inf = "";
        if (_name.Trim().Equals("Aquarius"))
        {
            inf = H1;
        }
        if (_name.Trim().Equals("Aries"))
        {
            inf = H2;
        }
        if (_name.Trim().Equals("Cancer"))
        {
            inf = H3;
        }
        if (_name.Trim().Equals("Capricorn"))
        {
            inf = H4;
        }
        if (_name.Trim().Equals("Gemini"))
        {
            inf = H5;
        }
        if (_name.Trim().Equals("Leo"))
        {
            inf = H6;
        }
        if (_name.Trim().Equals("Libra"))
        {
            inf = H7;
        }
        if (_name.Trim().Equals("Pisces"))
        {
            inf = H8;
        }
        if (_name.Trim().Equals("Sagittarius"))
        {
            inf = H9;
        }
        if (_name.Trim().Equals("Scorpio"))
        {
            inf = H10;
        }
        if (_name.Trim().Equals("Taurus"))
        {
            inf = H11;
        }
        if (_name.Trim().Equals("Virgo"))
        {
            inf = H12;
        }
        return inf;
    }
    public static void update(string _name, string content)
    {
        if (_name.Trim().Equals("Aquarius"))
        {
            H1 = content;
        }
        if (_name.Trim().Equals("Aries"))
        {
            H2 = content;
        }
        if (_name.Trim().Equals("Cancer"))
        {
            H3 = content;
        }
        if (_name.Trim().Equals("Capricorn"))
        {
            H4 = content;
        }
        if (_name.Trim().Equals("Gemini"))
        {
            H5 = content;
        }
        if (_name.Trim().Equals("Leo"))
        {
            H6 = content;
        }
        if (_name.Trim().Equals("Libra"))
        {
            H7 = content;
        }
        if (_name.Trim().Equals("Pisces"))
        {
            H8 = content;
        }
        if (_name.Trim().Equals("Sagittarius"))
        {
            H9 = content;
        }
        if (_name.Trim().Equals("Scorpio"))
        {
            H10 = content;
        }
        if (_name.Trim().Equals("Taurus"))
        {
            H11 = content;
        }
        if (_name.Trim().Equals("Virgo"))
        {
            H12 = content;
        }
    }
    public static void SaveFile()
    {
        string destination = Application.persistentDataPath + "/Stella.dat";
        FileStream file;

        if (File.Exists(destination))
            file = File.OpenWrite(destination);
        else
            file = File.Create(destination);

        SavingFile data = new SavingFile(H1,H2,H3,H4,H5,H6,H7,H8,H9,H10,H11,H12);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public static void LoadFile()
    {
        string destination = Application.persistentDataPath + "/Stella.dat";
        FileStream file;

        if (File.Exists(destination))
            file = File.OpenRead(destination);
        else
            return;

        BinaryFormatter bf = new BinaryFormatter();
        SavingFile data = (SavingFile)bf.Deserialize(file);
        H1 = data.H1;
        H2 = data.H2;
        H3 = data.H3;
        H4 = data.H4;
        H5 = data.H5;
        H6 = data.H6;
        H7 = data.H7;
        H8 = data.H8;
        H9 = data.H9;
        H10 = data.H10;
        H11 = data.H11;
        H12 = data.H12;
        file.Close();
        
    }
}
